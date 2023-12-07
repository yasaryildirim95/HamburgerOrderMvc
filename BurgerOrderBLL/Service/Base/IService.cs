using BurgerAppDtos.Base;
using BurgerOrderBLL.ReuqestResponse;
using BurgerOrderEntity.Abstract;
using BurgerOrderEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerOrderBLL.Service.Base
{
    public interface IService<T, TDto> where T : class, IEntity where TDto : class, IDTO
    {
        Response Insert(TDto dto);
        Response Update(TDto dto);
        Response Delete(TDto dto);
        Response<TDto> Get(string id);
        Response<IEnumerable<TDto>> GetAll();
    }
}
