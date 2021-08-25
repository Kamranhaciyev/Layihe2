using FinalLayihesi.Data;
using FinalLayihesi.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalLayihesi.Controllers
{
    public class ServicesController : Controller
    {
        private readonly AppDbContext _context;
        public ServicesController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewModelServices model = new ViewModelServices()
            {
                Process = _context.Processes.ToList(),
                Businesses = _context.Businesses.ToList(),
                Services = _context.Services.ToList(),
                SendMessage = _context.SendMessages.FirstOrDefault()
            };
            return View(model);
        }
        public IActionResult Single()
        {
            return View();
        }
    }
}
