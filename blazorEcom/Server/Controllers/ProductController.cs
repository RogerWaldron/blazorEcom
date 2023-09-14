using System;
using Microsoft.AspNetCore.Mvc;

namespace blazorEcom.Server.Controllers
{
	[Route("api/controller")]
	[ApiController]
	public class ProductController : ControllerBase
	{

        private static List<Product> Products = new();
 

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            return Ok(Products);
        }
	}
}

