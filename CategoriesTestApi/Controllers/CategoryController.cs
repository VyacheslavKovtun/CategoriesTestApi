using CategoriesTestApi.Models;
using CategoriesTestApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CategoriesTestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService) 
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public IEnumerable<Category> GetCategories()
        {
            return _categoryService.GetCategories();
        }

        [HttpGet("{id}")]
        public Category Get(int id)
        {
            Category? category = _categoryService.GetCategoryById(id);

            if (category == null)
                throw new Exception("Category was not found");

            return category;
        }
    }
}
