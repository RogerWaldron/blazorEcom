﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using blazorEcom.Server.Data;

#nullable disable

namespace blazorEcom.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230914124459_Categories")]
    partial class Categories
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("blazorEcom.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Visible")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Deleted = false,
                            Name = "Books",
                            Url = "books",
                            Visible = true
                        },
                        new
                        {
                            Id = 2,
                            Deleted = false,
                            Name = "Movies",
                            Url = "movies",
                            Visible = true
                        },
                        new
                        {
                            Id = 3,
                            Deleted = false,
                            Name = "Video Games",
                            Url = "video-games",
                            Visible = true
                        });
                });

            modelBuilder.Entity("blazorEcom.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Event streams are more complex. They’re typically time-ordered, interrelated, and must be processed as a group.",
                            ImageUrl = "https://images.pexels.com/photos/9883024/pexels-photo-9883024.jpeg?auto=compress&cs=tinysrgb&w=336&h200=&dpr=2",
                            Price = 4.99m,
                            Title = "Event-Driven Architecture uses topics not queues"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Messages are reliably stored in a broker (the queue) until received by the consumer. The queue guarantees First-In/First-Out (FIFO) message delivery, respecting the order in which messages were added to the queue.",
                            ImageUrl = "https://images.pexels.com/photos/17503523/pexels-photo-17503523/free-photo-of-cart-with-restaurant-menu-wine-bottles.jpeg?auto=compress&cs=tinysrgb&w=336&h=200&dpr=2",
                            Price = 9.99m,
                            Title = "Azure Service Bus, a brokered messaging model"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "A cutting edge technology that automates the process of building best performing models for your Machine Learning scenario. All you have to do is load your data, and AutoML takes care of the rest of the model building process.",
                            ImageUrl = "https://images.pexels.com/photos/15447298/pexels-photo-15447298/free-photo-of-retro-cassette-records-in-stacks.jpeg?auto=compress&cs=tinysrgb&w=336&h=200&dpr=2",
                            Price = 19.99m,
                            Title = "Automated ML (AutoML)"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Description = "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg",
                            Price = 0m,
                            Title = "The Matrix"
                        });
                });

            modelBuilder.Entity("blazorEcom.Shared.Product", b =>
                {
                    b.HasOne("blazorEcom.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}