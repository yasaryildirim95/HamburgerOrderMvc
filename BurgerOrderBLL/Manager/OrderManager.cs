using AutoMapper;
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
       


        public async Task<Response> CalculateOrderPrice(Menu selectedMenu, Extras extra, Order order) 
        {
            int menuPrice = selectedMenu.PriceForMedium;
            int extraprice = extra.Price;
            int amount = order.Amount;
            ProductSize menuSize = order.MenuSize;

            order.TotalPrice 
            


        
        
        }
    }
}
