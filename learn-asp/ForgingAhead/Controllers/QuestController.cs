using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using ForgingAhead.Models;

namespace ForgingAhead.Controllers
{
  public class QuestController : Controller
  {
    private readonly ApplicationDbContext _context;
    

    public QuestController(ApplicationDbContext context )
    {
      _context = context;
    }

    public IActionResult Index()
    {
      return View();
    }

    [HttpGet]
    public IActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Create(Quest quest)
    {
      _context.Quests.Add(quest);   
      _context.SaveChanges(); 
      return RedirectToAction("Index");
    }
  }
}

