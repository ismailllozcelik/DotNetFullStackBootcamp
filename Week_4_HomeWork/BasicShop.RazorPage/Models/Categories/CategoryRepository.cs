namespace BasicShop.RazorPage.Models.Category
{
    public class CategoryRepository : ICategoryRepository
    {
        private static List<Category> CategoryList = new();
        public void Add(Category category)
        {
            CategoryList.Add(category);
        }

        public void Delete(int id)
        {
            var categoryToDelete = CategoryList.FirstOrDefault(x => x.Id == id);
            if (categoryToDelete != null)
            {
                CategoryList.Remove(categoryToDelete);
            }
        }

        public IEnumerable<Category> GetAll()
        {
            return CategoryList;
        }

        public Category GetById(int id)
        {
            var category = CategoryList.FirstOrDefault(x => x.Id == id);
            if (category == null)
            {
                throw new Exception("Category not found");
            }
            return category;
        }

        public void Update(Category category)
        {
            var updateToCategory = CategoryList.FirstOrDefault(x => x.Id == category.Id);
            if (updateToCategory == null)
            {
                throw new Exception("Category not found");
            }
            updateToCategory.Name = category.Name;
            updateToCategory.Description = category.Description;

        }
    }
}
