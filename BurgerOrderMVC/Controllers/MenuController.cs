﻿using Microsoft.AspNetCore.Http;
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

        public MenuController(IMenuService menuService, IMapper mapper)
        {
            _menuService = menuService;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(MenuDto newMenuDto) 
        {
            newMenuDto.Id = Guid.NewGuid().ToString();

            var res = _menuService.Insert(newMenuDto);
            if (res.IsSuccess)
            {

                return RedirectToAction("List");
            }
            return View();
            
        }

        [HttpGet]
        public IActionResult Edit(string Id)
        {
            var getMenuAction = _menuService.Get(Id);
            if (getMenuAction.IsSuccess)
            {
                return View(getMenuAction.Context);
            }
            return View();
        }
        [HttpPost]
        public IActionResult Edit(MenuDto UpdatedDto)
        {
            var EditAction = _menuService.Update(UpdatedDto);
            if (EditAction.IsSuccess)
            {
                return RedirectToAction("List");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Delete(MenuDto DeletedMenuDto)
        {

            var DeleteAction = _menuService.Delete(DeletedMenuDto);
            if (DeleteAction.IsSuccess)
            {
                return RedirectToAction("List");
            }
            return View();
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


    }
}
