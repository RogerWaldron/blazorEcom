using System;
using Microsoft.AspNetCore.Mvc;

namespace blazorEcom.Server.Controllers
{
	[Route("api/controller")]
	[ApiController]
	public class ProductController : ControllerBase
	{

        private static List<Product> Products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Title = "Event-Driven Architecture uses topics not queues",
                Description = "Event streams are more complex. They’re typically time-ordered, interrelated, and must be processed as a group.",
                ImageUrl = "https://images.pexels.com/photos/9883024/pexels-photo-9883024.jpeg?auto=compress&cs=tinysrgb&w=336&h200=&dpr=2",
                Price = 4.99m
            },
            new Product
            {
                Id = 2,
                Title = "Azure Service Bus, a brokered messaging model",
                Description = "Messages are reliably stored in a broker (the queue) until received by the consumer. The queue guarantees First-In/First-Out (FIFO) message delivery, respecting the order in which messages were added to the queue.",
                ImageUrl = "https://images.pexels.com/photos/17503523/pexels-photo-17503523/free-photo-of-cart-with-restaurant-menu-wine-bottles.jpeg?auto=compress&cs=tinysrgb&w=336&h=200&dpr=2",
                Price = 9.99m
            },
            new Product
            {
                Id = 3,
                Title = "Automated ML (AutoML)",
                Description = "A cutting edge technology that automates the process of building best performing models for your Machine Learning scenario. All you have to do is load your data, and AutoML takes care of the rest of the model building process.",
                ImageUrl = "https://images.pexels.com/photos/15447298/pexels-photo-15447298/free-photo-of-retro-cassette-records-in-stacks.jpeg?auto=compress&cs=tinysrgb&w=336&h=200&dpr=2",
                Price = 19.99m
            },
        };

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            return Ok(Products);
        }
	}
}

