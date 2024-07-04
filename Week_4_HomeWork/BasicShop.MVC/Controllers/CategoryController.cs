using Microsoft.AspNetCore.Mvc;

namespace BasicShop.MVC.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
