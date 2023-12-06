using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BurgerOrderViewModel;
using AutoMapper;
using BurgerOrderBLL.Service.Contrate;
using BurgerAppDtos.Concrate;
using BurgerOrderEntity.Concrete;
using System.Security.AccessControl;
using Microsoft.AspNetCore.Authorization;

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

        [HttpGet]
        public IActionResult List()
        {
            var ListMenuAction = _menuService.GetAll();
            if (ListMenuAction.IsSuccess)
            {
                return View(ListMenuAction.Context);
            }
            return View();
        }

        [HttpPost]
        public IActionResult Create(MenuDto newMenuDto) 
        {
            


            var res = _menuService.Insert(newMenuDto);
            if (res.IsSuccess)
            {

                return View();
            }
            return View();
            
        }
        [HttpGet]
        public IActionResult Create()
        {
            
            return View();

        }


        [HttpPost]
        public IActionResult Edit(MenuDto DeletedMenuDto)
        {

            var EditAction = _menuService.Update(DeletedMenuDto);
            if (EditAction.IsSuccess)
            {
                return View();
            }
            return View();
        }

        public IActionResult Delete(MenuDto DeletedMenuDto)
        {

            var DeleteAction = _menuService.Delete(DeletedMenuDto);
            if (DeleteAction.IsSuccess)
            {
                return View();
            }
            return View();
        }


    }
}
