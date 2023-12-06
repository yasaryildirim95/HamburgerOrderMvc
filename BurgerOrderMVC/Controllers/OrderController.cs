using BurgerOrderBLL.Manager;
using BurgerOrderBLL.Service.Contrate;
using Microsoft.AspNetCore.Mvc;

namespace BurgerOrderMVC.Controllers
{
    public class OrderController : Controller
    {
        private readonly IExtrasService extrasService;
        private readonly IMenuService menuService;
        private readonly IOrderService orderService;

        public OrderController(IExtrasService extrasService, IMenuService menuService, IOrderService orderService)
        {
            this.extrasService = extrasService;
            this.menuService = menuService;
            this.orderService = orderService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            var data = orderService.GetAll().Context;


            return View(data);
        }

        public IActionResult Order()
        {
            //TODO : ProductSizeService

            ViewBag.Extras = extrasService.GetAll().Context;
            ViewBag.Menus = menuService.GetAll().Context;


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
