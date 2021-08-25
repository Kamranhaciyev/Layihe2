using FinalLayihesi.Data;
using FinalLayihesi.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalLayihesi.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
        public AboutController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewModelAbout model = new ViewModelAbout() 
            {
                About = _context.Abouts.FirstOrDefault(),
                AboutCards = _context.AboutCards.ToList(),
                Companies = _context.Companies.ToList(),
                Testimonials = _context.Testimonials.ToList(),
                Results = _context.Results.FirstOrDefault(),
                ResultCards = _context.ResultCards.ToList()
            };
            return View(model);
        }
    }
}
