
using BasicShop.MVC.Models.Category.ViewModels;

namespace BasicShop.MVC.Models.Category
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public void Add(CreateViewModel category)
        {
            var categoryToAdd = new Category
            {
                Id = new Random().Next(1, 1000),
                Name = category.Name,
                Description = category.Description
            };
          
            _categoryRepository.Add(categoryToAdd);
        }

        public void Delete(int id)
        {
            _categoryRepository.Delete(id);

        }

        public IEnumerable<ListViewModel> GetAll()
        {
            return _categoryRepository.GetAll().Select(c => new ListViewModel
            {
                Id = c.Id,
                Name = c.Name,
                Description = c.Description
            });
        }

        public Category GetById(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public void Update(Category category)
        {
            _categoryRepository.Update(category);
        }
    }
}
