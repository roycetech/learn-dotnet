using Microsoft.AspNetCore.Mvc;
using System;
using CharacterSheetAppGrunt.Models;

namespace CharacterSheetAppGrunt.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      return View("Index", Equipment.GetAll());
    }

    public IActionResult Create(String equipmentName) {
        Equipment.Create(equipmentName);
        return RedirectToAction("Index");
    }
  }

}
