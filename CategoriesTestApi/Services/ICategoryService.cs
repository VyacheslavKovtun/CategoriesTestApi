using CategoriesTestApi.Models;

namespace CategoriesTestApi.Services
{
    public interface ICategoryService
    {
        public IEnumerable<Category> GetCategories();

        public Category? GetCategoryById(int id);

    }
}
