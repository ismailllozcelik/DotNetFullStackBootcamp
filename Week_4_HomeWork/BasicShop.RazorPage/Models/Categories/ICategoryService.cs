using BasicShop.RazorPage.Models.Categories.ViewModels;

namespace BasicShop.RazorPage.Models.Category
{
    public interface ICategoryService
    {
        IEnumerable<ListViewModel> GetAll();
        Category GetById(int id); 
        void Add(CreateViewModel category);
        void Update(EditViewModel category);
        void Delete(int id);

    }
}
