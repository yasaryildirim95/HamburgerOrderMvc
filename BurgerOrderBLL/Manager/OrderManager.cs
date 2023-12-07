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
        private readonly IExtraService _extra;
        public OrderManager(IMapper mapper,IUow uow) : base(mapper, uow) 
        {
        
        
        }
       


        public async Task<decimal> CalculateOrderPrice(Menu selectedMenu, List<string> extras, Order order,ProductSize size) 
        {
            int menuPrice = selectedMenu.PriceForMedium;
            
            int amount = order.Amount;
            decimal productSize = size.PriceMultiplier;
            int selectedExtraTotal = 0;
            foreach (var item in extras)
            {
                if (item != null)
                {
                    var extra =  _extra.Get(item);
                  
                    var selectedExtra = extra.Context.Price;

                    selectedExtraTotal += selectedExtra;
                }
                
            }
           




            order.TotalPrice = (((menuPrice * productSize) +selectedExtraTotal) * amount);

            return order.TotalPrice;

        }

        
    }
}
