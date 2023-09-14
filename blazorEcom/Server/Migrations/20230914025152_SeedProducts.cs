using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace blazorEcom.Server.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Event streams are more complex. They’re typically time-ordered, interrelated, and must be processed as a group.", "https://images.pexels.com/photos/9883024/pexels-photo-9883024.jpeg?auto=compress&cs=tinysrgb&w=336&h200=&dpr=2", 4.99m, "Event-Driven Architecture uses topics not queues" },
                    { 2, "Messages are reliably stored in a broker (the queue) until received by the consumer. The queue guarantees First-In/First-Out (FIFO) message delivery, respecting the order in which messages were added to the queue.", "https://images.pexels.com/photos/17503523/pexels-photo-17503523/free-photo-of-cart-with-restaurant-menu-wine-bottles.jpeg?auto=compress&cs=tinysrgb&w=336&h=200&dpr=2", 9.99m, "Azure Service Bus, a brokered messaging model" },
                    { 3, "A cutting edge technology that automates the process of building best performing models for your Machine Learning scenario. All you have to do is load your data, and AutoML takes care of the rest of the model building process.", "https://images.pexels.com/photos/15447298/pexels-photo-15447298/free-photo-of-retro-cassette-records-in-stacks.jpeg?auto=compress&cs=tinysrgb&w=336&h=200&dpr=2", 19.99m, "Automated ML (AutoML)" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
