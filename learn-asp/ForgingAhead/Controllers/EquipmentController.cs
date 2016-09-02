using Microsoft.AspNetCore.Mvc;
using ForgingAhead.Models;
using System.Linq;

namespace ForgingAhead.Controllers
{
  public class EquipmentController : Controller
  {
    private readonly ApplicationDbContext _context;

    public EquipmentController(ApplicationDbContext context) {
        _context = context;
    }


    public IActionResult Index()
    {
        ViewData["Title"] = "Equipment";
        return View(_context.Equipment.ToList());
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Equipment equipment) {
        _context.Equipment.Add(equipment);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

  }

}
