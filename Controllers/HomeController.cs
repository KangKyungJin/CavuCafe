using Microsoft.AspNetCore.Mvc;

namespace CavuCafe.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ViewResult Home()
        {
            return View();
        }
    }
}