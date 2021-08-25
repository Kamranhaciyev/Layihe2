using FinalLayihesi.Data;
using FinalLayihesi.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalLayihesi.Controllers
{
    public class TestimonialsController : Controller
    {
        private readonly AppDbContext _context;
        public TestimonialsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewModelTestimonials model = new ViewModelTestimonials() 
            {
                Testimonials = _context.Testimonials.ToList()
            };

            return View(model);
        }
    }
}
