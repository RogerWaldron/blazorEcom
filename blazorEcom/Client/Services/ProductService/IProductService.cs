﻿using blazorEcom.Shared;

namespace blazorEcom.Client.Services.ProductService
{
    public interface IProductService
	{
		List<Product> Products { get; set; }

		Task GetProducts();
	}
}

