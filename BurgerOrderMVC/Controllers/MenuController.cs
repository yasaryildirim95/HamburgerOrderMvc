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
    [Authorize(Roles = "Admin")]
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
            
            if (newMenuDto.ImageFile != null && newMenuDto.ImageFile.Length > 0)
            {
                
                var imageUrl = SaveImageFile(newMenuDto.ImageFile);

               
                newMenuDto.ImageURL = imageUrl;
            }
            var res = _menuService.Insert(newMenuDto);
            if (res.IsSuccess)
            {
                return RedirectToAction("List");
            }
            return View();
        }


        private string SaveImageFile(IFormFile imageFile)
        {
            
            var fileName = Guid.NewGuid().ToString() + "_" + imageFile.FileName;

            
            var imagePath = Path.Combine("wwwroot", "images", fileName);

            
            using (var stream = new FileStream(imagePath, FileMode.Create))
            {
                imageFile.CopyTo(stream);
            }

            
            return "/images/" + fileName;
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
