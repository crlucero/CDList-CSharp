using Microsoft.AspNetCore.Mvc;

namespace CDList.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}