﻿using BurgerAppDtos.Concrate;
using BurgerOrderBLL.Manager;
using BurgerOrderBLL.Service.Contrate;
using BurgerOrderEntity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BurgerOrderMVC.Controllers
{
	public class OrderController : Controller
	{
		private readonly IExtraService extrasService;
		private readonly IMenuService menuService;
		private readonly IOrderService orderService;
		private readonly IProductSizeService productSizeService;
		private readonly UserManager<AppUser> userManager;
		


		public OrderController(IExtraService extrasService, IMenuService menuService, IOrderService orderService, IProductSizeService productSizeService, UserManager<AppUser> userManager)
		{
			this.extrasService = extrasService;
			this.menuService = menuService;
			this.orderService = orderService;
			this.productSizeService = productSizeService;
			this.userManager = userManager;
		}

		public IActionResult Index()
		{
			return View();
		}

        [Authorize(Roles = "Admin")]
        public IActionResult List()
		{
			var data = orderService.GetAll().Context;


			return View(data);
		}

		[Authorize]
        public IActionResult List2()
        {
            var data = orderService.GetAll().Context.Where(x=>x.AppUserId == User.FindFirstValue(ClaimTypes.NameIdentifier)).ToList();


            return View(data);
        }

        [Authorize]
		public IActionResult AddOrder()
		{

			ViewBag.Extras = extrasService.GetAll().Context;
			ViewBag.Menus = menuService.GetAll().Context;


			return View();
		}

		[HttpPost]
		public IActionResult AddOrder(OrderDto orderDTO)
		{
			orderDTO.AppUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

			orderDTO.Id = Guid.NewGuid().ToString();
			orderDTO.Name = orderDTO.AppUserId+orderDTO.Id;
			var res = orderService.Insert(orderDTO);
			if (res.IsSuccess)
			{
				if (User.IsInRole("Admin"))
				{
                    return RedirectToAction("List");
                }
				else
				{
                    return RedirectToAction("List2");
                }
				
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
		[HttpGet]
		public IActionResult OrderEdit(string id) 
		{
			ViewBag.Extras = extrasService.GetAll().Context;
			ViewBag.Menus = menuService.GetAll().Context;

			var getOrderAction = orderService.Get(id);
            if (getOrderAction.IsSuccess)
            {
                return View(getOrderAction.Context);
            }
            return View();


        }
		[HttpPost]
        public IActionResult OrderEdit(OrderDto updateOrderDto)
        {
            var EditAction = orderService.Update(updateOrderDto);
            if (EditAction.IsSuccess)
            {
                return RedirectToAction("List");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete(OrderDto deletedOrderDto)
        {

            var DeleteAction = orderService.Delete(deletedOrderDto);
            if (DeleteAction.IsSuccess)
            {
                return RedirectToAction("List");
            }
            return View();
        }

    }
}
