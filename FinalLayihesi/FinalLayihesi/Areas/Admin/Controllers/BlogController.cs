using FinalLayihesi.Data;
using FinalLayihesi.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FinalLayihesi.Areas.Admin.Controllers
{
    [Area ("admin")]
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;

        public BlogController(AppDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            List<Blog> blogs = _context.Blogs.Include(g => g.Categories).Include(u => u.User).Include(tb => tb.TagToBlogs).ThenInclude(t => t.Tags).ToList();
            return View(blogs);

           
        }

        [HttpGet]
        public IActionResult Create()
        {
            List<Categories> categories = _context.Categories.ToList();
            categories.Insert(0, new Categories() { Id = 0, Name = "Select" });
            ViewBag.Categories = categories;

            List<Tags> tags = _context.Tags.ToList();
            ViewBag.Tags = tags;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Blog model)
        {
            if (ModelState.IsValid)
            {
                if (model.CategoryId == 0)
                {
                    ModelState.AddModelError("CategoryId", "Categoriya secmelisiniz!");
                    List<Categories> categories = _context.Categories.ToList();
                    categories.Insert(0, new Categories() { Id = 0, Name = "Select" });
                    ViewBag.Categories = categories;
                    List<Tags> tags = _context.Tags.ToList();
                    ViewBag.Tags = tags;
                    return View(model);
                }
                if (model.ImageFile.ContentType == "image/png" || model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/gif")
                {
                    if (model.ImageFile.Length <= 2097152)
                    {
                        string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMyyyyHHmmss") + "-" + model.ImageFile.FileName;
                        string filePath = Path.Combine(_hostingEnvironment.WebRootPath, "Uploads/Images", fileName);
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            model.ImageFile.CopyTo(stream);
                        }

                        model.MainImage = fileName;
                        model.UserId = JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("ValidUser")).Id;
                        model.AddedDate = DateTime.Now;

                        _context.Blogs.Add(model);
                        _context.SaveChanges();

                        foreach (var item in model.TagIds)
                        {
                            TagToBlog tagToBlog = new TagToBlog()
                            {
                                BlogId = model.Id,
                                TagId = item
                            };

                            _context.TagToBlogs.Add(tagToBlog);
                        }

                        _context.SaveChanges();

                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError("ImageFile", "Siz maksimum 2 Mb hecmde fayllari upload ede bilersiniz!");
                    }
                }
                else
                {
                    ModelState.AddModelError("ImageFile", "Siz yalniz .jpeg, .png, .gif tipli fayllari upload ede bilersiniz!");
                }
                //return Content(model.ImageFile.Length.ToString());
            }
            return View(model);
        }


        [HttpGet]
        public IActionResult Update(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Blog blog = _context.Blogs.Include(t => t.TagToBlogs).FirstOrDefault(i => i.Id == id);
            if (blog == null)
            {
                return NotFound();
            }

            List<Categories> categories = _context.Categories.ToList();
            categories.Insert(0, new Categories() { Id = 0, Name = "Select" });
            ViewBag.Categories = categories;

            List<Tags> tags = _context.Tags.ToList();
            ViewBag.Tags = tags;

            List<int> tagIds = new List<int>();

            foreach (var item in blog.TagToBlogs)
            {
                tagIds.Add(item.TagId);
            }

            blog.TagIds = tagIds.ToArray();

            return View(blog);
        }

        [HttpPost]
        public IActionResult Update(Blog model)
        {
            if (ModelState.IsValid)
            {
                if (model.ImageFile != null)
                {
                    if (model.CategoryId == 0)
                    {
                        ModelState.AddModelError("CategoryId", "Categoriya secmelisiniz!");
                        List<Categories> categories = _context.Categories.ToList();
                        categories.Insert(0, new Categories() { Id = 0, Name = "Select" });
                        ViewBag.Categories = categories;
                        List<Tags> tags = _context.Tags.ToList();
                        ViewBag.Tags = tags;
                        return View(model);
                    }
                    if (model.ImageFile.ContentType == "image/png" || model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/gif")
                    {
                        if (model.ImageFile.Length <= 2097152)
                        {
                            string oldFilePath = Path.Combine(_hostingEnvironment.WebRootPath, "Uploads/Images", model.MainImage);
                            if (System.IO.File.Exists(oldFilePath))
                            {
                                System.IO.File.Delete(oldFilePath);
                            }

                            string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMyyyyHHmmss") + "-" + model.ImageFile.FileName;
                            string filePath = Path.Combine(_hostingEnvironment.WebRootPath, "Uploads/Images", fileName);

                            //model.ImageFile.CopyTo(new FileStream(filePath, FileMode.Create));

                            using (var stream = new FileStream(filePath, FileMode.Create))
                            {
                                model.ImageFile.CopyTo(stream);
                            }

                            model.MainImage = fileName;

                            _context.Entry(model).State = EntityState.Modified;
                            _context.Entry(model).Property(a => a.UserId).IsModified = false;
                            _context.Entry(model).Property(a => a.AddedDate).IsModified = false;

                            _context.SaveChanges();

                            //Delete all tags
                            foreach (var item in _context.Blogs.Include(a => a.TagToBlogs).FirstOrDefault(i => i.Id == model.Id).TagToBlogs)
                            {
                                _context.TagToBlogs.Remove(item);
                            }
                            _context.SaveChanges();

                            //Add new tags
                            foreach (var item in model.TagIds)
                            {
                                TagToBlog tagToBlog = new TagToBlog()
                                {
                                    BlogId = model.Id,
                                    TagId = item
                                };

                                _context.TagToBlogs.Add(tagToBlog);
                            }
                            _context.SaveChanges();

                            return RedirectToAction("Index");
                        }
                        else
                        {
                            ModelState.AddModelError("ImageFile", "Siz maksimum 2 Mb hecmde fayllari upload ede bilersiniz!");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("ImageFile", "Siz yalniz .jpeg, .png, .gif tipli fayllari upload ede bilersiniz!");
                    }
                }
                else
                {
                    if (model.CategoryId == 0)
                    {
                        ModelState.AddModelError("CategoryId", "Categoriya secmelisiniz!");
                        List<Categories> categories = _context.Categories.ToList();
                        categories.Insert(0, new Categories() { Id = 0, Name = "Select" });
                        ViewBag.Categories = categories;
                        List<Tags> tags = _context.Tags.ToList();
                        ViewBag.Tags = tags;
                        return View(model);
                    }

                    _context.Entry(model).State = EntityState.Modified;
                    _context.Entry(model).Property(a => a.UserId).IsModified = false;
                    _context.Entry(model).Property(a => a.AddedDate).IsModified = false;

                    _context.SaveChanges();

                    //Delete all tags
                    foreach (var item in _context.Blogs.Include(a => a.TagToBlogs).FirstOrDefault(i => i.Id == model.Id).TagToBlogs)
                    {
                        _context.TagToBlogs.Remove(item);
                    }
                    _context.SaveChanges();

                    //Add new tags
                    foreach (var item in model.TagIds)
                    {
                        TagToBlog tagToBlog = new TagToBlog()
                        {
                            BlogId = model.Id,
                            TagId = item
                        };

                        _context.TagToBlogs.Add(tagToBlog);
                    }
                    _context.SaveChanges();

                    return RedirectToAction("Index");
                }

                //return Content(model.ImageFile.Length.ToString());
            }
            return View(model);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Blog blog = _context.Blogs.Include(a => a.TagToBlogs).FirstOrDefault(i => i.Id == id);
            if (blog == null)
            {
                return NotFound();
            }

            //Delete image
            string oldFilePath = Path.Combine(_hostingEnvironment.WebRootPath, "Uploads/Images", blog.MainImage);
            if (System.IO.File.Exists(oldFilePath))
            {
                System.IO.File.Delete(oldFilePath);
            }


            //Delete tags
            foreach (var item in blog.TagToBlogs)
            {
                _context.TagToBlogs.Remove(item);
            }

            _context.Blogs.Remove(blog);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
