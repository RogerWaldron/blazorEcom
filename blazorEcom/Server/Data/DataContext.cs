using Microsoft.EntityFrameworkCore;

namespace blazorEcom.Server.Data
{
    public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{

		}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductVariant>()
                .HasKey(p => new { p.ProductId, p.ProductTypeId });

            modelBuilder.Entity<ProductType>().HasData(
                    new ProductType
                    {
                        Id = 1,
                        Name = "Ebook",
                    },
                    new ProductType
                    {
                        Id = 2,
                        Name = "Audiobook",
                    },
                    new ProductType
                    {
                        Id = 3,
                        Name = "Paperback",
                    },
                    new ProductType
                    {
                        Id = 4,
                        Name = "Hardback",
                    },
                    new ProductType
                    {
                        Id = 5,
                        Name = "Blu-ray",
                    },
                    new ProductType
                    {
                        Id = 6,
                        Name = "Digital Stream",
                    }
                );

            modelBuilder.Entity<ProductVariant>().HasData(
                    new ProductVariant
                    {
                        OriginalPrice = 29.99m,
                        Price = 9.99m,
                        ProductId = 1,
                        ProductTypeId = 1
                    },
                    new ProductVariant
                    {
                        OriginalPrice = 29.99m,
                        Price = 9.99m,
                        ProductId = 1,
                        ProductTypeId = 2
                    },
                    new ProductVariant
                    {
                        OriginalPrice = 29.99m,
                        Price = 19.99m,
                        ProductId = 1,
                        ProductTypeId = 3
                    },
                    new ProductVariant
                    {
                        OriginalPrice = 49.99m,
                        Price = 39.99m,
                        ProductId = 1,
                        ProductTypeId = 4
                    },
                    new ProductVariant
                    {
                        OriginalPrice = 19.99m,
                        Price = 9.19m,
                        ProductId = 4,
                        ProductTypeId = 5
                    },
                    new ProductVariant
                    {
                        OriginalPrice = 29.99m,
                        Price = 19.99m,
                        ProductId = 4,
                        ProductTypeId = 6
                    },
                    new ProductVariant
                    {
                        OriginalPrice = 19.99m,
                        Price = 9.19m,
                        ProductId = 5,
                        ProductTypeId = 5
                    },
                    new ProductVariant
                    {
                        OriginalPrice = 29.99m,
                        Price = 19.99m,
                        ProductId = 5,
                        ProductTypeId = 6
                    },
                    new ProductVariant
                    {
                        OriginalPrice = 19.99m,
                        Price = 9.19m,
                        ProductId = 6,
                        ProductTypeId = 5
                    },
                    new ProductVariant
                    {
                        OriginalPrice = 29.99m,
                        Price = 19.99m,
                        ProductId = 6,
                        ProductTypeId = 6
                    },
                    new ProductVariant
                    {
                        OriginalPrice = 29.99m,
                        Price = 19.19m,
                        ProductId = 7,
                        ProductTypeId = 5
                    },
                    new ProductVariant
                    {
                        OriginalPrice = 29.99m,
                        Price = 19.99m,
                        ProductId = 7,
                        ProductTypeId = 6
                    }
                );

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Books",
                    Url = "books"
                },
                new Category
                {
                    Id = 2,
                    Name = "Movies",
                    Url = "movies"
                },
                new Category
                {
                    Id = 3,
                    Name = "Video Games",
                    Url = "video-games"
                }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Event-Driven Architecture uses topics not queues",
                    Description = "Event streams are more complex. They’re typically time-ordered, interrelated, and must be processed as a group.",
                    ImageUrl = "https://images.pexels.com/photos/9883024/pexels-photo-9883024.jpeg?auto=compress&cs=tinysrgb&w=336&h200=&dpr=2",
                    CategoryId = 1
                },
                new Product
                {
                    Id = 2,
                    Title = "Azure Service Bus, a brokered messaging model",
                    Description = "Messages are reliably stored in a broker (the queue) until received by the consumer. The queue guarantees First-In/First-Out (FIFO) message delivery, respecting the order in which messages were added to the queue.",
                    ImageUrl = "https://images.pexels.com/photos/17503523/pexels-photo-17503523/free-photo-of-cart-with-restaurant-menu-wine-bottles.jpeg?auto=compress&cs=tinysrgb&w=336&h=200&dpr=2",
                    CategoryId = 1
                },
                new Product
                {
                    Id = 3,
                    Title = "Automated ML (AutoML)",
                    Description = "A cutting edge technology that automates the process of building best performing models for your Machine Learning scenario. All you have to do is load your data, and AutoML takes care of the rest of the model building process.",
                    ImageUrl = "https://images.pexels.com/photos/15447298/pexels-photo-15447298/free-photo-of-retro-cassette-records-in-stacks.jpeg?auto=compress&cs=tinysrgb&w=336&h=200&dpr=2",
                    CategoryId = 1
                },
                new Product
                {
                    Id = 4,
                    Title = "The Matrix",
                    Description = "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg",
                    CategoryId = 2
                },
                new Product
                {
                    Id = 5,
                    Title = "The Matrix Reloaded",
                    Description = "The Matrix is a 2003 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and as the second installment in the Matrix franchise, Six months after the events of The Matrix, Neo and Trinity are now romantically involved. Morpheus receives a message from Captain Niobe of the Logos calling an emergency meeting of all ships of Zion. An army of Sentinels is tunneling towards Zion and will reach it within 72 hours. Commander Lock orders all ships to return to Zion to prepare, but Morpheus asks one ship to remain to contact the Oracle. Within the Matrix, the lone ship's crew is encountered by the former Agent Smith, who copies himself over the body of crew member Bane and uses the phone line to leave the Matrix.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/ba/Poster_-_The_Matrix_Reloaded.jpg",
                    CategoryId = 2
                },
                new Product
                {
                    Id = 6,
                    Title = "The Matrix Revolutions",
                    Description = "The Matrix is a 2003 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and as the third installment in the Matrix franchise, Picking up immediately where Reloaded ended, Neo and Bane still lie unconscious in the medical bay of the ship Hammer. Inside the Matrix, Neo is trapped in a subway station named Mobil Ave, a transition zone between the Matrix and the machine world. He meets a \"family\" of programs, including a girl named Sati.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/3/34/Matrix_revolutions_ver7.jpg",
                    CategoryId = 2
                },
                new Product
                {
                    Id = 7,
                    Title = "The Matrix Resurrections",
                    Description = "The Matrix is a 2021 science fiction action film written and directed by the Lana Wachowski, and produced by Lana Wachowski. Starring Keanu Reeves, Carrie-Anne Moss, and is the final installment in the Matrix franchise.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/5/50/The_Matrix_Resurrections.jpg",
                    CategoryId = 2
                }
            );
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<ProductType> ProductTypes { get; set; }

        public DbSet<ProductVariant> ProductVariants { get; set; }
    }
}

