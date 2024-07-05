using BasicShop.RazorPage.Models.Categories.ViewModels;
using BasicShop.RazorPage.Models.Category;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BasicShop.RazorPage.Pages.Category
{
    public class EditModel : PageModel
    {
        [BindProperty] public EditViewModel EditViewModel { get; set; } = new();

        private readonly ICategoryService _categoryService;
        public EditModel(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
      
        public void OnGet(int id)
        {
            var category = _categoryService.GetById(id);
            EditViewModel.Description = category.Description;
            EditViewModel.Id = id;
            EditViewModel.Name = category.Name;

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _categoryService.Update(EditViewModel);
            return RedirectToPage("List");
        }
    }
}
