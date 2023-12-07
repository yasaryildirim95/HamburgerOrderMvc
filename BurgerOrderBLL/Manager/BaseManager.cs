using AutoMapper;
using BurgerAppDtos.Base;
using BurgerOrderBLL.ReuqestResponse;
using BurgerOrderBLL.Service.Base;
using BurgerOrderDAL.Abstract;
using BurgerOrderDAL.UnitOfWork;
using BurgerOrderEntity.Abstract;
using BurgerOrderEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerOrderBLL.Manager
{
    public class BaseManager<T, TDto> : IService<T, TDto> where T : class, IEntity where TDto : class, IDTO
    {
        protected readonly IMapper _mapper;
        protected readonly IUow _uow;

        public BaseManager(IMapper mapper, IUow uow)
        {
            _mapper = mapper;
            _uow = uow;
        }

        public Response Delete(TDto dto)
        {
            try
            {
                var entity = _mapper.Map<T>(dto);
                _uow.GetRepository<T>().Delete(entity);
                _uow.SaveChanges();
                return Response.Success("Deletion was successful.");
            }
            catch
            {
                return Response.Failure("Deletion was unsuccessful");
            }
        }

        public Response<TDto> Get(string id)
        {
            try
            {
                var entity = _uow.GetRepository<T>().Get(id);
                var dto = _mapper.Map<TDto>(entity);
                return Response<TDto>.Success(dto, "Acquirement was successful.");
            }
            catch
            {
                return Response<TDto>.Failure("Acquirement was unsuccessful");
            }
        }

        public Response<IEnumerable<TDto>> GetAll()
        {
            try
            {
                var entities = _uow.GetRepository<T>().GetAll(true);
                var dtos = _mapper.Map<List<TDto>>(entities);
                return Response<IEnumerable<TDto>>.Success(dtos, "Acquirement was successful.");
            }
            catch
            {
                return Response<IEnumerable<TDto>>.Failure("Acquirement was unsuccessful");
            }
        }

        public Response Insert(TDto dto)
        {
            try
            {
                var entity = _mapper.Map<T>(dto);
                _uow.GetRepository<T>().Add(entity);
                _uow.SaveChanges();
                return Response.Success("Insertion was successful.");
            }
            catch
            {
                return Response.Failure("Insertion was unsuccessful");
            }
        }

        public Response Update(TDto dto)
        {
            try
            {
                var entity = _mapper.Map<T>(dto);
                _uow.GetRepository<T>().Update(entity);
                _uow.SaveChanges();
                return Response.Success("Updating was successful.");
            }
            catch
            {
                return Response.Failure("Updating was unsuccessful");
            }
        }
    }
}
