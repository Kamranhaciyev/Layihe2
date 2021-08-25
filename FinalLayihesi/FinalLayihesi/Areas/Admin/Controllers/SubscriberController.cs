using Microsoft.AspNetCore.Mvc;
using FinalLayihesi.Data;
using System.Linq;

namespace FinalLayihesi.Areas.Admin.Controllers
{
    public class SubscriberController : Controller
    {
        private readonly AppDbContext _context;
        public SubscriberController(AppDbContext context)
        {
            _context = context;
        }

        [Area("admin")]
        public IActionResult Index()
        {
            return View(_context.Subscribers.ToList());
        }
    }
}
