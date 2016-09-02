using Microsoft.AspNetCore.Mvc;
using ForgingAhead.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ForgingAhead
{
    public class CharacterController : Controller
    {


        private readonly ApplicationDbContext _context;


        public CharacterController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewData["Title"] = "Characters";
            return View(_context.Characters.ToList());
        }

        [HttpGet]
        public IActionResult GetActive()
        {
            var model = _context.Characters.Where(e => e.IsActive).ToList();
            return View(model);
        }

        [HttpGet]
        [Route("Character/{name}/Details")]
        public IActionResult Details(string name)
        {
            var model = _context.Characters.FirstOrDefault(e => e.Name == name);
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Character character)
        {
            if (_context.Characters.Any(e => e.Name == character.Name)) {
                ModelState.AddModelError("Name", "Name is already in use.");
            }
            if (!ModelState.IsValid)
            {
                return View(character);
            }
            _context.Characters.Add(character);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Update(Character character)
        {
            _context.Entry(character).State = EntityState.Modified;
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(string name)
        {
            var toDelete = _context.Characters.FirstOrDefault(n => n.Name == name);
            if (toDelete != null)
            {
                _context.Characters.Remove(toDelete);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}