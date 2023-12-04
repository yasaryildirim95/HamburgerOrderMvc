﻿using BurgerAppDtos.User;
using BurgerOrderBLL.Service;
using Microsoft.AspNetCore.Identity;
using BurgerOrderEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;


namespace BurgerOrderBLL.Manager
{
    public class AccountManager : IAccountService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AccountManager(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        private readonly IMapper _mapper;
        public Task<bool> Login(UserLoginDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Register(UserRegisterDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SignOut()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateUserInfo(UserUpdateDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
