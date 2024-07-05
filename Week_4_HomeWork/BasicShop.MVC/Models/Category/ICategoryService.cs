using BasicShop.MVC.Models.Category.ViewModels;

namespace BasicShop.MVC.Models.Category
{
    public interface ICategoryService
    {
        void Add(CreateViewModel category);
        void Update(EditViewModel category);
        IEnumerable<ListViewModel> GetAll();
        void Delete(int id);
        Category GetById(int id);

    }
}
