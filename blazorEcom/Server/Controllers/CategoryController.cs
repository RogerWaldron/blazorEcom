using blazorEcom.Server.Services.CategoryService;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace blazorEcom.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Category>>> GetCategoriesAsync()
        {
            var result = await _categoryService.GetCategoriesAsync();

            return Ok(result);
        }

        [HttpGet("{categoryId}")]
        public async Task<ActionResult<Category>> GetCategoryAsync(int categoryId)
        {
            var result = await _categoryService.GetCategoryAsync(categoryId);

            return Ok(result);
        }
    }
}

