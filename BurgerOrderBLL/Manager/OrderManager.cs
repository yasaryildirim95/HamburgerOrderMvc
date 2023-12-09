using AutoMapper;
using BurgerAppDtos.Concrate;
using BurgerOrderBLL.ReuqestResponse;
using BurgerOrderBLL.Service.Contrate;
using BurgerOrderDAL.Abstract;
using BurgerOrderEntity.Concrete;
using BurgerOrderEntity.Enums;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace BurgerOrderBLL.Manager
{
	public class OrderManager : BaseManager<Order, OrderDto>, IOrderService
	{
		private readonly IExtraService _extra;
		private readonly IProductSizeService _productSizeService;
		public OrderManager(IMapper mapper, IUow uow, IProductSizeService productSizeService, IExtraService extra) : base(mapper, uow)
		{
			_productSizeService = productSizeService;
			_extra = extra;
		}

		public async Task<decimal> CalculateOrderPrice(MenuDto selectedMenu, List<string> extras, int amount,string sizeId) 
		{
			var smenu = selectedMenu;
			decimal totalPrice = 0;
			int menuPrice = smenu.PriceForMedium;
			int a = amount;
			var size = _productSizeService.Get(sizeId).Context;
			decimal productSize = size.PriceMultiplier;
			int selectedExtraTotal = 0;
			if(extras[0] != null)
			{
				string[] selectedExtras = extras[0].Split(",");

				foreach (var item in selectedExtras)
				{
					if (item != null)
					{
						var extra = _extra.Get(item);

						var selectedExtra = extra.Context.Price;

						selectedExtraTotal += selectedExtra;
					}

				}
			}
			else
			{
				selectedExtraTotal = 0;
			}

			totalPrice = (((menuPrice * productSize) +selectedExtraTotal) * a);

			return totalPrice;
		}
	}
}
