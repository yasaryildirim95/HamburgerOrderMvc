using Microsoft.AspNetCore.Mvc;

namespace BurgerOrderMVC.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Order()
        {

            List<string> extras = new List<string>();
            extras.Add("barbekü");
            extras.Add("ranch");
            List<string> menus = new List<string>();
            menus.Add("whoper");
            menus.Add("stek");





            ViewBag.Extras = extras;
            ViewBag.Menus = menus;


            return View();
        }
        //[HttpPost]
        //public IActionResult Order()
        //{

        //    List<string> extras = new List<string>();
        //    extras.Add("barbekü");
        //    extras.Add("ranch");
        //    List<string> menus = new List<string>();
        //    menus.Add("whoper");
        //    menus.Add("stek");





        //    ViewBag.Extras = extras;
        //    ViewBag.Menus = menus;


        //    return View();
        //}
    }
}
