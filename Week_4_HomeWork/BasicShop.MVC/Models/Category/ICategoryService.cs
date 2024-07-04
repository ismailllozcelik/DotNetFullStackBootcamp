namespace BasicShop.MVC.Models.Category
{
    public interface ICategoryService
    {
        void Add(Category category);
        void Update(Category category);
        IEnumerable<Category> GetAll();
        void Delete(int id);
        Category GetById(int id);

    }
}
