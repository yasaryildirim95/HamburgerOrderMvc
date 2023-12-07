using BurgerAppDtos.Concrate;
using BurgerOrderBLL.Manager;
using BurgerOrderBLL.Service.Contrate;
using Microsoft.AspNetCore.Mvc;

namespace BurgerOrderMVC.Controllers
{
    public class OrderController : Controller
    {
        private readonly IExtraService extrasService;
        private readonly IMenuService menuService;
        private readonly IOrderService orderService;

        public OrderController(IExtraService extrasService, IMenuService menuService, IOrderService orderService)
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

        [HttpPost]
        public IActionResult Order(OrderDto orderDTO)
            {
            var res = orderService.Insert(orderDTO);

            return View();
        }
    }
}
