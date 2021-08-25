using FinalLayihesi.Data;
using FinalLayihesi.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalLayihesi.Controllers
{
    public class OurpeopleController : Controller
    {
        private readonly AppDbContext _context;
        public OurpeopleController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewModelTeam model = new ViewModelTeam()
            {
                Teams = _context.Teams.ToList(),
                Team = _context.Teams.FirstOrDefault()
            };
            return View(model);
        }
    }
}
