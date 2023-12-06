using Microsoft.AspNetCore.Identity;
using BurgerOrderEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BurgerAppDtos.Concrate;
using BurgerOrderBLL.Service.Contrate;
using System.Security.Claims;
using BurgerOrderBLL.ReuqestResponse;
using Microsoft.VisualBasic;

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

        public async Task<Response> DeleteUserAsync(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
            {
                return Response.Failure("User not found");
            }

            var result = await _userManager.DeleteAsync(user);
            return Response.Success("Successed");
        }

        public async Task<(Response,AppUser)> GetAppUserByIdAsync(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if(user == null)
            {
                return (Response.Failure("User couldn't find"),null);
            }
            return (Response.Success("User fined"),user);
        }

        public async Task<(Response,UserProfileDto)> GetProfileInfo(string id)
        {
            
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return (Response.Failure("Profile couldn't find"),null);

            }
            var userProfileDto = _mapper.Map<UserProfileDto>(user);

            return (Response.Success("Succesed"),userProfileDto);


        }

        public async Task<Response> Login(UserLoginDto dto)
        {
            var user = await _userManager.FindByEmailAsync(dto.Email);
            if (user == null)
            {
                return Response.Failure("Email or password not found");

            }

            var result = await _signInManager.CheckPasswordSignInAsync(user, dto.Password, false);
            if (!result.Succeeded)
            {

                return Response.Failure("Email or password not found");
            }
            return Response.Success("Successed");
        }

        public async Task<Response> Register(UserRegisterDto dto)
        {
            var user = _mapper.Map<AppUser>(dto);
            var result = await _userManager.CreateAsync(user,dto.Password);
            if (!result.Succeeded)
            {

                return Response.Failure("Register Failed"); ;
            }
            return Response.Success("Successed");

        }

        public async Task<Response> SignOut()
        {
            await _signInManager.SignOutAsync();
            return Response.Success("Sucessed");
        }

        public async Task<Response> UserProfileUpdate(UserProfileDto userProfileDto)
        {
            var user = await _userManager.FindByIdAsync(userProfileDto.Id);
            if (user != null)
            {
                if (userProfileDto.CurrentPassword != null)
                {
                    var isVerified = _userManager.CheckPasswordAsync(user, userProfileDto.CurrentPassword);
                    if (isVerified != null)
                    {
                        var result = await _userManager.ChangePasswordAsync(user, userProfileDto.CurrentPassword, userProfileDto.NewPassword);

                        if (result.Succeeded)
                        {
                            await _userManager.UpdateSecurityStampAsync(user);
                            await _signInManager.SignOutAsync();
                            await _signInManager.PasswordSignInAsync(user, userProfileDto.NewPassword, true, false);

                            _mapper.Map(userProfileDto, user);

                            await _userManager.UpdateAsync(user);
                            return Response.Success("Update Sucessed");
                        }
                        return Response.Failure("Update Failed");
                    }
                    return Response.Failure("Password didnt match");
                }
                return Response.Failure("Password Couldn't be empty");
            }
            return Response.Failure("User Couldn't Find");
        }


    }
}
