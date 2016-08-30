using Microsoft.AspNetCore.Mvc;
using System;

namespace CharacterSheetAppGrunt.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      var name = "Sword";      
      return View("Index", name);
    }

    public IActionResult Create(String equipmentName) {
        return View();
    }
  }

}
