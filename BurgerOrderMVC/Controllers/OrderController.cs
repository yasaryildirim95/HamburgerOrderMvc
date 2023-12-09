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
		private readonly IProductSizeService productSizeService;

		public OrderController(IExtraService extrasService, IMenuService menuService, IOrderService orderService,  IProductSizeService productSizeService)
		{
			this.extrasService = extrasService;
			this.menuService = menuService;
			this.orderService = orderService;
			this.productSizeService = productSizeService;
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

			ViewBag.Extras = extrasService.GetAll().Context;
			ViewBag.Menus = menuService.GetAll().Context;


			return View();
		}

		[HttpPost]
		public IActionResult Order(OrderDto orderDTO)
		{
			var res = orderService.Insert(orderDTO);
			if (res.IsSuccess)
			{
				return RedirectToAction("List");
			}
			return View();
		}

		[HttpPost]
		public IActionResult calculatePrice(string SizeId,  string Menu, List<string> Extras, int Amount)
		{
			try
			{
				var selectedmenu = menuService.Get(Menu).Context;
				var size = SizeId;
				


				var total = orderService.CalculateOrderPrice(selectedmenu, Extras, Amount, size);

				return Ok(total);
			}
			catch (Exception ex)
			{
				// Handle errors appropriately
				return BadRequest($"Error calculating order price: {ex.Message}");
			}
		}
	}
}
