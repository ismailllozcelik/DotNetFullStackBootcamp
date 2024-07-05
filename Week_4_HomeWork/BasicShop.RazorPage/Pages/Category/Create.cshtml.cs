using BasicShop.RazorPage.Models.Categories.ViewModels;
using BasicShop.RazorPage.Models.Category;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BasicShop.RazorPage.Pages.Category
{
    public class CreateModel : PageModel
    {
        [BindProperty] public CreateViewModel CreateViewModel { get; set; } = new();

        private readonly ICategoryService _categoryService;
        public CreateModel(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _categoryService.Add(CreateViewModel);
            return RedirectToPage("List");
        }
    }
}
