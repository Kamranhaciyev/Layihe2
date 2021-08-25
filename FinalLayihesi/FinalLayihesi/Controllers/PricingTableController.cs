using FinalLayihesi.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalLayihesi.Controllers
{
    public class PricingTableController : Controller
    {
        private readonly AppDbContext _context;
        public PricingTableController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
