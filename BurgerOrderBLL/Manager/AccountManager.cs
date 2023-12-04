using BurgerAppDtos.User;
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
 
        private readonly IMapper _mapper;

        public AccountManager(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IMapper mapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _mapper = mapper;
        }

        public async Task<bool> Login(UserLoginDto dto)
        {
            var user = await _userManager.FindByEmailAsync(dto.Email);
            if (user == null) 
            {
              return false;
            
            }

            var result = await _signInManager.CheckPasswordSignInAsync(user, dto.Password, false);
            if (!result.Succeeded) 
            {

                return false;
            }
            return true;
        }

        public async Task<bool> Register(UserRegisterDto dto)
        {
            var user = _mapper.Map<AppUser>(dto);
            var result = await _userManager.CreateAsync(user);
            if (!result.Succeeded) 
            {
             
                return false;
            }
            return true;

        }

        public async Task<bool> SignOut()
        {
            await _signInManager.SignOutAsync();    
            return true;
        }

        
    }
}
