using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;

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
        ViewData["Title"] = "Quests";
        return View("Index", _context.Quests.ToList());
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

    public IActionResult Details(string name)
    {
        var model = _context.Quests.FirstOrDefault(p => p.Name == name);      
        Console.WriteLine(model);
        return View( model );
    }

    public IActionResult Edit(string name)
    {
        ViewData["title"] = $"Edit {name}";
        var model = _context.Quests.FirstOrDefault(p => p.Name == name);      
        return View( model );
    }



    public IActionResult Update(Quest quest) {
        _context.Entry(quest).State = EntityState.Modified;        
        return RedirectToAction("Index");
    }

    public IActionResult Delete(string questName) {
        var toDelete = _context.Quests.FirstOrDefault(p => p.Name == questName);
        if (toDelete != null) {
            _context.Quests.Remove(toDelete);
            _context.SaveChanges();
        }
        return RedirectToAction("Index");
    }

  }
}

