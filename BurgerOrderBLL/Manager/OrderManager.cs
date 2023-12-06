﻿using AutoMapper;
using BurgerAppDtos.Concrate;
using BurgerOrderBLL.ReuqestResponse;
using BurgerOrderBLL.Service.Contrate;
using BurgerOrderDAL.Abstract;
using BurgerOrderEntity.Concrete;
using BurgerOrderEntity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerOrderBLL.Manager
{
    public class OrderManager : BaseManager<Order, OrderDto>, IOrderService
    {
        public OrderManager(IMapper mapper,IUow uow) : base(mapper, uow) 
        {
        
        
        }
       


        public async Task<decimal> CalculateOrderPrice(Menu selectedMenu, List<Extras>extras, Order order,ProductSize size) 
        {
            int menuPrice = selectedMenu.PriceForMedium;
            
            int amount = order.Amount;
            decimal productSize = size.PriceMultiplier;
            int selectedExtra = extras.Sum(extra => extra.Price);




            order.TotalPrice = (((menuPrice * productSize) +selectedExtra ) * amount);

            return order.TotalPrice;

        }
    }
}
