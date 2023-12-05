using AutoMapper;
using BurgerAppDtos.Concrate;
using BurgerOrderBLL.Service.Contrate;
using BurgerOrderDAL.Abstract;
using BurgerOrderEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerOrderBLL.Manager
{
    public class OrderManager : BaseManager<Order, OrderDto>, IOrderService
    {
        public OrderManager(IMapper mapper, IUow uow) : base(mapper, uow)
        {
            
        }
    }
}
