using BurgerAppDtos.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerOrderBLL.Service
{
    public interface IAccountService
    {
        public Task<bool> Register(UserRegisterDto dto);
        public Task<bool> Login(UserLoginDto dto);
        public Task<bool> UpdateUserInfo(UserUpdateDto dto);
        public Task<bool> SignOut();
    }
}
