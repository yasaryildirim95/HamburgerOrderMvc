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
    public class ExtraManager : BaseManager<Extra,ExtraDto>, IExtraService
    {
        public ExtraManager(IMapper mapper, IUow uow) : base(mapper, uow)
        {
            
        }
    }
}
