using blazorEcom.Server.Data;
using Microsoft.EntityFrameworkCore;

namespace blazorEcom.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
	{
        private readonly DataContext _dataContext;

        public CategoryService(DataContext dataContext) 
		{
            _dataContext = dataContext;
        }

        public async Task<ServiceResponse<List<Category>>> GetCategoriesAsync()
        {
            var response = new ServiceResponse<List<Category>>
            {
                Data = await _dataContext.Categories.ToListAsync()
            };

            return response;
        }

        public async Task<ServiceResponse<Category>> GetCategoryAsync(int categoryId)
        {
            var response = new ServiceResponse<Category>();
            var category = await _dataContext.Categories.FindAsync(categoryId);

            if (category == null)
            {
                response.Success = false;
                response.Message = "Failed to finid a category with that id";
            }
            else
            {
                response.Data = category;
            }

            return response;
        }
    }
}

