using Microsoft.AspNetCore.Mvc;
using System.Linq;
using ForgingAhead.Models;

namespace ForgingAhead.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context) {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = _context.Characters.Where(e => e.IsActive).ToList();
            return View(model);
        }

        [HttpGet]
        public IActionResult Error()
        {
            return View();
        }
    }
}
