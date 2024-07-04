
namespace BasicShop.RazorPage.Pages.Category
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public void Add(Category category)
        {
           _categoryRepository.Add(category);
        }

        public void Delete(int id)
        {
           var categoryToDelete = _categoryRepository.GetById(id);
            if (categoryToDelete == null)
            {
                throw new Exception("Category not found");
            }
            _categoryRepository.Delete(id);
        }

        public IEnumerable<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetById(int id)
        {
            var category = _categoryRepository.GetById(id);
            if (category == null)
            {
                throw new Exception("Category not found");
            }
            return category;
        }

        public void Update(Category category)
        {
            var updateToCategory = _categoryRepository.GetById(category.Id);
            if (updateToCategory == null)
            {
                throw new Exception("Category not found");
            }
            _categoryRepository.Update(category);
        }
    }
}
