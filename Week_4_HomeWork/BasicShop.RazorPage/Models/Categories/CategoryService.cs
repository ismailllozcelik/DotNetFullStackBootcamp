﻿using BasicShop.RazorPage.Models.Categories.ViewModels;

namespace BasicShop.RazorPage.Models.Category
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
            var categoryToDelete = _categoryRepository.GetById(id);
            if (categoryToDelete == null)
            {
                throw new Exception("Category not found");
            }
            _categoryRepository.Delete(id);
        }

        public IEnumerable<ListViewModel> GetAll()
        {
            return _categoryRepository.GetAll().Select(x => new ListViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description
            });
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
