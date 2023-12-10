using BurgerAppDtos.Concrate;
using BurgerOrderBLL.Manager;
using BurgerOrderBLL.ReuqestResponse;
using BurgerOrderBLL.Service.Contrate;
using BurgerOrderEntity.Concrete;
using BurgerOrderViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BurgerOrderMVC.Controllers
{
    public class UserController : Controller
    {
        private readonly IAccountService _accountService;

        public UserController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(UserLoginDto userLoginDto)
        {

            if(ModelState.IsValid)
            {


                var result = await _accountService.Login(userLoginDto);

                if (result.IsSuccess)
                {

                    return RedirectToAction("Index", "Home");

                }
                ViewBag.isSuccess = result.IsSuccess;
                ViewBag.message = result.Message;


                foreach(var item in result.Errors) 
                {
                    ModelState.AddModelError("", item.Description);
                }
            }

            return View(userLoginDto);
        }

        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Register(UserRegisterDto userRegisterDto)
        {
            
            var res = await _accountService.Register(userRegisterDto);

            return RedirectToAction("Login");
        }

        public async Task<IActionResult> Logout(string returnUrl = null)
        {
            var res = await _accountService.SignOut();
            
            if (res.IsSuccess)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }


    }
}
