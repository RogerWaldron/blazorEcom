using System.Net.Http.Json;
using blazorEcom.Shared;

namespace blazorEcom.Client.Services.ProductService
{
    public class ProductService : IProductService
	{
        private readonly HttpClient _httpClient;


        public ProductService(HttpClient httpClient)
		{
            _httpClient = httpClient;
        }

        public List<Product> Products { get; set; } = new List<Product>();

        public async Task GetProducts()
        {
            var results = await _httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product");

            if(results != null && results.Data != null)
                Products = results.Data;
        }

        public async Task<ServiceResponse<Product>> GetProduct(int productId)
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<Product>>($"api/product/{productId}");

            return result;
        }
    }
}

