using BurgerAppDtos.Concrate;
using BurgerOrderBLL.Service.Base;
using BurgerOrderEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerOrderBLL.Service.Contrate
{
    public interface IOrderService : IService<Order, OrderDto>
    {
        Task<decimal> CalculateOrderPrice(MenuDto selectedMenu, List<string> extras, int amount, string sizeId);
    }
}
