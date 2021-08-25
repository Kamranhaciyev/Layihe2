using FinalLayihesi.Data;
using FinalLayihesi.Filters;
using FinalLayihesi.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Crypto = BCrypt.Net.BCrypt;
namespace FinalLayihesi.Areas.Admin.Controllers
{
    [Area("admin")]
    public class UserController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public UserController(AppDbContext context, IWebHostEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            List<User> users = _context.Users.ToList();

            return View(users);
           
        }

/*
        [AuthUser]*/
        public IActionResult Create()
        {
            return View();
        }

       /* [AuthUser]*/
        [HttpPost]
        public IActionResult Create(User model)
        {
            if (ModelState.IsValid)
            {

                if (model.Password == model.ConfirmPassword)
                {
                    User user = new User();
                    user.Name = model.Name;
                    user.Surname = model.Surname;
                    user.Email = model.Email;
                    user.AddedDate = DateTime.Now;
                    user.Password = Crypto.HashPassword(model.Password);
                    _context.Users.Add(user);
                    _context.SaveChanges();
                }
                else
                {
                    ModelState.AddModelError("ConfirmPassword", "Password duzgun deyil!");
                    return View(model);
                }
            }

            return View(model);
        }

      /*  [AuthUser]*/
        [HttpGet]
        public IActionResult Update(int? id)
        {
            User user = _context.Users.Find(id);
            /*  ViewBag.Country = _context.Countries.ToList();*/


            return View(user);
        }

       /* [AuthUser]*/
        [HttpPost]
        public IActionResult Update(User model)
        {

            if (ModelState.IsValid)
            {
                if (model.ImageFile != null)
                {
                    if (model.ImageFile.ContentType == "image/png" || model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/gif")
                    {
                        if (model.ImageFile.Length <= 2097152)
                        {
                            if (model.Image != null)
                            {
                                string oldFilePath = Path.Combine(_hostingEnvironment.WebRootPath, "Uploads/Images", model.Image);
                                if (System.IO.File.Exists(oldFilePath))
                                {
                                    System.IO.File.Delete(oldFilePath);
                                }
                            }


                            string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMyyyyHHmmss") + "-" + model.ImageFile.FileName;
                            string filePath = Path.Combine(_hostingEnvironment.WebRootPath, "Uploads/Images", fileName);

                            using (var stream = new FileStream(filePath, FileMode.Create))
                            {
                                model.ImageFile.CopyTo(stream);
                            }

                            model.Image = fileName;
                            model.Password = Crypto.HashPassword(model.Password);

                        }
                        else
                        {
                            ModelState.AddModelError("ImageFile", "You can upload maximum 2Mb size file!");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("ImageFile", "You can upload only png, jpeg and gif typed file!");
                    }
                }

                _context.Entry(model).State = EntityState.Modified;
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(model);


        }

       /* [AuthUser]*/
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            User user = _context.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }

            if (user.Image != null)
            {
                string oldFilePath = Path.Combine(_hostingEnvironment.WebRootPath, "Uploads/Images", user.Image);
                if (System.IO.File.Exists(oldFilePath))
                {
                    System.IO.File.Delete(oldFilePath);
                }
            }

            _context.Users.Remove(user);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }



     /*   [AuthUser]*/
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("ValidUser");
            return RedirectToAction("login", "account");
        }
    }
}
