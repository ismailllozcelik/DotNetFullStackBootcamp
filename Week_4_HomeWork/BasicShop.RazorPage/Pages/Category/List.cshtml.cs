using BasicShop.RazorPage.Models.Categories.ViewModels;
using BasicShop.RazorPage.Models.Category;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BasicShop.RazorPage.Pages.Category
{
    public class ListModel : PageModel
    {
        public IEnumerable<ListViewModel> CategoryList { get; set; }

        private readonly ICategoryService _categoryService;

        public ListModel(ICategoryService categoryService)
        {
            _categoryService = categoryService;
            CategoryList = _categoryService.GetAll();
        }
        


        public void OnGet()
        {

        }
    }
}
