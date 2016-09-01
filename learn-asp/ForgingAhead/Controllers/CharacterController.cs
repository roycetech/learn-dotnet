using Microsoft.AspNetCore.Mvc;
using ForgingAhead.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ForgingAhead {
    public class CharacterController : Controller {
        

        private readonly ApplicationDbContext _context;


        public CharacterController(ApplicationDbContext context) {
            _context = context;
        }

        public IActionResult Index() {
            return View(_context.Characters.ToList());
        }

        public IActionResult GetActive() {
            var model = _context.Characters.Where(e => e.IsActive).ToList();
            return View(model);
        }

        public IActionResult Details(string name) {
            var model = _context.Characters.FirstOrDefault(e => e.Name == name);
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
        return View();
        }

        [HttpPost]
        public IActionResult Create(Character character) {
            _context.Characters.Add(character);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Update(Character character) {
            _context.Entry(character).State = EntityState.Modified;
            return RedirectToAction("Index");
        }

        public IActionResult Delete(string name ) {
            var toDelete = _context.Characters.FirstOrDefault(n => n.Name == name);
            if (toDelete != null) {
                _context.Characters.Remove(toDelete);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");            
        }
    }
}