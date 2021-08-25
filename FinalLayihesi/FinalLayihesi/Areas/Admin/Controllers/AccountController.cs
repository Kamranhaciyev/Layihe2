using FinalLayihesi.Data;
using FinalLayihesi.Models;
using FinalLayihesi.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crypto = BCrypt.Net.BCrypt;
namespace FinalLayihesi.Areas.Admin.Controllers
{
    [Area("admin")]
    public class AccountController : Controller
    {
        

        private readonly AppDbContext _context;

        public AccountController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }


        /* [AuthCustomer]*/
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        /* [AuthUser]*/
        [HttpPost]
        public IActionResult Login(VmUser model)
        {
            if (ModelState.IsValid)
            {
                User user = _context.Users.FirstOrDefault(c => c.Email == model.Email);
                if (user != null)
                {
                    if (Crypto.Verify(model.Password, user.Password))
                    {
                        string userObj = JsonConvert.SerializeObject(user);
                        HttpContext.Session.SetString("ValidUser", userObj);
                        return RedirectToAction("index", "home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Password duzgun deyil!");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Email movcud deyil!");
                }
            }
            return View(model);
        }
        /*
                    [HttpGet]
                    public IActionResult Register()
                    {
                        return View();
                    }*/

        /*   [HttpPost]
           public IActionResult Register(User model)
           {
               if (ModelState.IsValid)
               {
                   if (model.ConfirmPassword == null)
                   {
                       ModelState.AddModelError("ConfirmPassword", "Required");
                       return View(model);
                   }

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

                       return RedirectToAction("login", "account");
                   }
                   else
                   {
                       ModelState.AddModelError("ConfirmPassword", "Password not match!");
                       return View(model);
                   }
               }
               else
               {
                   return View(model);
               }

           }*/

    }
}
