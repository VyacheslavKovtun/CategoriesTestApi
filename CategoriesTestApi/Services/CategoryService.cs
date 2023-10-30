using CategoriesTestApi.Models;

namespace CategoriesTestApi.Services
{
    public class CategoryService: ICategoryService
    {
        private static readonly Category[] Categories = new[] { 
            new Category() { CategoryId = 1, CategoryName = "Fruits" },
            new Category() { CategoryId = 2, CategoryName = "Apples", ParentCategoryId = 1 },
            new Category() { CategoryId = 3, CategoryName = "Green Apples", ParentCategoryId = 2 },

            new Category() { CategoryId = 4, CategoryName = "Vegetables" },
            new Category() { CategoryId = 5, CategoryName = "Tomatoes", ParentCategoryId = 4 },
            new Category() { CategoryId = 6, CategoryName = "Red Tomatoes", ParentCategoryId = 5 },
            new Category() { CategoryId = 7, CategoryName = "Pink Tomatoes", ParentCategoryId = 5 },
            new Category() { CategoryId = 8, CategoryName = "Carrot", ParentCategoryId = 4 }
        };

        public IEnumerable<Category> GetCategories()
        {
            return Categories;
        }

        public Category? GetCategoryById(int id)
        {
            return Categories.FirstOrDefault(c => c.CategoryId == id);
        }
    }
}
