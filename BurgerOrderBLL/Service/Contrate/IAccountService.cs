using BurgerAppDtos.Concrate;
using BurgerOrderBLL.ReuqestResponse;
using BurgerOrderBLL.Service.Base;
using BurgerOrderEntity.Concrete;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerOrderBLL.Service.Contrate
{
    public interface IAccountService
    {
        Task<Response> DeleteUserAsync(string userId);
        Task<(Response,AppUser)> GetAppUserByIdAsync(string userId);
        Task<(Response,UserProfileDto)> GetProfileInfo(string id);
        Task<Response> Login(UserLoginDto dto);
        Task<Response> Register(UserRegisterDto dto);
        Task<Response> SignOut();
        Task<Response> UserProfileUpdate(UserProfileDto userProfileDto);
        
    }
}
