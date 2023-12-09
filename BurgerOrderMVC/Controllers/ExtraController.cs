using BurgerAppDtos.Concrate;
using BurgerOrderBLL.Service.Contrate;
using Microsoft.AspNetCore.Mvc;

namespace BurgerOrderMVC.Controllers
{
    public class ExtraController : Controller
    {
        private readonly IExtraService _extraService;

        public ExtraController(IExtraService extraService)
        {
            _extraService = extraService;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(ExtraDto newExtraDto) 
        {
            newExtraDto.Id = Guid.NewGuid().ToString();

            var res = _extraService.Insert(newExtraDto);
            if (res.IsSuccess)
            {

                return RedirectToAction("List");
            }
            return View();
            
        }

        [HttpGet]
        public IActionResult Edit(string Id)
        {
            var getMenuAction = _extraService.Get(Id);
            if (getMenuAction.IsSuccess)
            {
                return View(getMenuAction.Context);
            }
            return View();
        }
        [HttpPost]
        public IActionResult Edit(ExtraDto updateExtraDto)
        {
            var EditAction = _extraService.Update(updateExtraDto);
            if (EditAction.IsSuccess)
            {
                return RedirectToAction("List");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Delete(ExtraDto deletedExtraDto)
        {

            var DeleteAction = _extraService.Delete(deletedExtraDto);
            if (DeleteAction.IsSuccess)
            {
                return RedirectToAction("List");
            }
            return View();
        }

        [HttpGet]
        public IActionResult List()
        {
            var ListMenuAction = _extraService.GetAll();
            if (ListMenuAction.IsSuccess)
            {
                return View(ListMenuAction.Context);
            }
            return View();
        }
    }
}
