using AutoMapper;
using BurgerAppDtos.Concrate;
using BurgerOrderBLL.ReuqestResponse;
using BurgerOrderBLL.Service.Base;
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
    public class ProductSizeManager : BaseManager<ProductSize, ProductSizeDto>, IProductSizeService
    {
        public ProductSizeManager(IMapper mapper, IUow uow) : base(mapper, uow)
        {

        }

    }
}
