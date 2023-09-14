using blazorEcom.Server.Data;
using Microsoft.EntityFrameworkCore;

namespace blazorEcom.Server.Services.ProductService
{
    public class ProductService : IProductService
	{
        private readonly DataContext _dataContext;

        public ProductService(DataContext dataContext)
		{
            _dataContext = dataContext;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductAsync()
        {
            var response = new ServiceResponse<List<Product>>
            { 
                Data = await _dataContext.Products.ToListAsync()
            };

            return response;
        }
    }
}

