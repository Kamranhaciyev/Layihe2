using FinalLayihesi.Data;
using FinalLayihesi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FinalLayihesi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger,AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public void Subscribe(string name, string email)
        {
            if (!String.IsNullOrEmpty(name) && !String.IsNullOrEmpty(email))
            {
                if(!_context.Subscribers.Any(s=>s.Email == email))
                {
                    _context.Subscribers.Add(new Subscriber { Email = email, Name = name });
                    _context.SaveChanges();
                }
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
