using Microsoft.AspNetCore.Mvc;


namespace CharacterSheetAppGrunt.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      var name = "Sword";
      
      return View("Index", name);
    }
  }
}
