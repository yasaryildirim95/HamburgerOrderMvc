using Microsoft.AspNetCore.Mvc;

namespace BurgerOrderMVC.Controllers
{
    public class HakkındaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
