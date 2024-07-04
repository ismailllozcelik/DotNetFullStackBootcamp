using BasicShop.MVC.Models.Category;
using BasicShop.MVC.Models.Category.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BasicShop.MVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {

            _categoryService = categoryService;
        }
        public IActionResult List()
        {
            var categories = _categoryService.GetAll();
            return View(categories);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            _categoryService.Add(model);

            return RedirectToAction(nameof(List));
        }
    }
}
