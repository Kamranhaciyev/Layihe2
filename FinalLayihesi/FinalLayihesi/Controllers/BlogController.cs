using FinalLayihesi.Data;
using FinalLayihesi.Models;
using FinalLayihesi.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalLayihesi.Controllers
{
    public class BlogController : Controller
    {

        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int? id, int? tagId, int? year, int? month, VmBlog VmFilter, string searchData, int page = 1)
        {

            TempData["Controller"] = "Blog";

            decimal pageItemCount = 4;
            ViewBag.Page = "blog";
           


            ViewBag.categoryId = id;
            IList<Blog> blogs = _context.Blogs.Include(saved => saved.Categories).Include(u => u.User).Where(b => (id != null ? b.CategoryId == id : true) &&
                                                            (tagId != null ? b.TagToBlogs.Any(t => t.TagId == tagId) : true) &&
                                                            (year != null ? b.AddedDate.Year == year : true) &&
                                                            (month != null ? b.AddedDate.Month == month : true)
                                                          ).Where(sr =>
                                                                  ((searchData != null ? sr.Title.Contains(searchData) : true) || (searchData != null ? sr.Categories.Name.Contains(searchData) : true)) &&
                                                                  (VmFilter.catId != null ? sr.CategoryId == VmFilter.catId : true))
                                                     .ToList();


            decimal b = Math.Ceiling(blogs.Count / pageItemCount);
            ViewBag.PageCount = Convert.ToInt32(b);
            ViewBag.ActivePage = page;
            ViewBag.prewPage = page - 1;
            ViewBag.nextPage = page + 1;

            List<Blog> products = blogs.OrderBy(p => p.Id)
                                                     .Skip((page - 1) * (int)pageItemCount).Take((int)pageItemCount)
                                                     .ToList();
            VmBlog model = new VmBlog()
            {
                Blogs = products,
                RecentPost = _context.Blogs.Include(c => c.User).OrderByDescending(o => o.AddedDate).Take(4).ToList(),
                Categories = _context.Categories.Include(b => b.Blogs).ToList(),        
                Tags = _context.TagToBlogs.Include(b => b.Tags).ToList(),
               
            };

            return View(model);
        }
        public IActionResult Single(int? id, int? tagId, int? year, int? month)
        {
            if (id == null)
            {
                return NotFound();
            }

            IList<Blog> blogs = _context.Blogs.Where(b => (id != null ? b.CategoryId == id : true) &&
                                                    (tagId != null ? b.TagToBlogs.Any(t => t.TagId == tagId) : true) &&
                                                    (year != null ? b.AddedDate.Year == year : true) &&
                                                    (month != null ? b.AddedDate.Month == month : true)
                                                    ).ToList();
           




            VmBlog model = new VmBlog()
            {
                Blog = _context.Blogs.Include(t => t.TagToBlogs).ThenInclude(t => t.Tags).Include(u => u.User).ThenInclude(us => us.SocialToUsers).ThenInclude(s => s.Social).FirstOrDefault(b => b.Id == id),
                Categories = _context.Categories.Include(b => b.Blogs).ToList(),
                RecentPost = _context.Blogs.OrderByDescending(o => o.AddedDate).Take(3).ToList(),
                Comment = _context.Comments.Where(c => c.BlogId == id).ToList(),
                Socials = _context.Socials.ToList(),
                Tags = _context.TagToBlogs.Include(t=>t.Tags).ToList(),
                VmDates = _context.Blogs.GroupBy(d => new
                {
                    Monthes = d.AddedDate.Month,
                    Years = d.AddedDate.Year
                })
                                       .Select(a => new VmDate
                                       {
                                           Year = a.Key.Years,
                                           Month = a.Key.Monthes,
                                           Count = a.Count()
                                       })
                                       .ToList()
            };
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }
    }
}
