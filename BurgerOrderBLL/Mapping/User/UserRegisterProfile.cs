﻿using AutoMapper;
using BurgerAppDtos.User;
using BurgerOrderEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerOrderBLL.Mapping.User
{
    internal class UserRegisterProfile : Profile
    {
        public UserRegisterProfile()
        {
            CreateMap<UserRegisterDto,AppUser>();
        }
    }
}