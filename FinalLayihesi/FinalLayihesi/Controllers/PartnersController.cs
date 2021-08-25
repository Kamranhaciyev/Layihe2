using FinalLayihesi.Data;
using FinalLayihesi.Models;
using FinalLayihesi.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalLayihesi.Controllers
{
    public class PartnersController : Controller
    {
        private readonly AppDbContext _context;
        public PartnersController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewModelPartners model = new ViewModelPartners()
            {
                Partners = _context.Partners.ToList()
            };
            return View(model);
        }
    }
}
