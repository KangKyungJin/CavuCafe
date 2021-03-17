using Microsoft.AspNetCore.Mvc;


namespace CavuCafe.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ViewResult Home()
        {
            ViewBag.apiKey = "";
            return View();
        }
    }
}