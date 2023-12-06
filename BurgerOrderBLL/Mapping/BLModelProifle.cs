using AutoMapper;
using BurgerAppDtos.Concrate;
using BurgerOrderEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerOrderBLL.Mapping
{
    public class BLModelProfile : Profile
    {
        public BLModelProfile()
        {
            //UserMapings
            CreateMap<UserLoginDto, AppUser>().ReverseMap();
            CreateMap<UserRegisterDto, AppUser>().ReverseMap();
            CreateMap<UserUpdateDto, AppUser>().ReverseMap();
            CreateMap<UserProfileDto, AppUser>().ReverseMap();

            //Other Mapings
            CreateMap<Menu, MenuDto>().ReverseMap();
            CreateMap<Order, OrderDto>().ReverseMap();
            CreateMap<Extras, ExtrasDto>().ReverseMap();
            CreateMap<ProductSize,ProductSizeDto>().ReverseMap();

        }
    }
}
