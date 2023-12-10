using Microsoft.AspNetCore.Mvc;

namespace BurgerOrderMVC.Controllers
{
    public class HakkindaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
