using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BurgerOrderViewModel;
using AutoMapper;
using BurgerOrderBLL.Service.Contrate;
using BurgerAppDtos.Concrate;
using BurgerOrderEntity.Concrete;

namespace BurgerOrderMVC.Controllers
{
    public class MenuController : Controller
    {
        private readonly IMenuService _menuService;
        private readonly IMapper _mapper;

        public MenuController(IMenuService menuService, IMapper mapper)
        {
            _menuService = menuService;
            _mapper = mapper;
        }

        public IActionResult CreateMenu(MenuDto newMenuDto) 
        {
            _menuService.Insert(newMenuDto);
            return View();
        }
    }
}
