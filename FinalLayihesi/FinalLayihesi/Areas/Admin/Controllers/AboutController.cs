using FinalLayihesi.Data;
using FinalLayihesi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalLayihesi.Areas.Admin.Controllers
{
    [Area("admin")]
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
        public AboutController(AppDbContext context)
        {
            _context = context;
        }

        
        public IActionResult Index()
        {
            return View(_context.Abouts.ToList());
        }

        [Route("Id")]
        public IActionResult Edit(int Id)
        {
            return View("~/Areas/Admin/Views/About/Edit.cshtml", _context.Abouts.Find(Id));
        }

        public IActionResult Editt(About about)
        {
            if (ModelState.IsValid)
            {
                _context.Abouts.Update(about);
                _context.SaveChanges();
                return RedirectToAction("Index","About");
            }
            return View(about);
        }

    }
}
