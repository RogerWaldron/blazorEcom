using blazorEcom.Server.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace blazorEcom.Server.Controllers
{
    [Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{

        private static readonly List<Product> _products = new();
        private readonly DataContext _dataContext;

        public ProductController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
 

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var products = await _dataContext.Products.ToListAsync();
            return Ok(products);
        }
	}
}

