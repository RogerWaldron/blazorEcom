using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace blazorEcom.Server.Migrations
{
    /// <inheritdoc />
    public partial class Categories_fixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Price",
                value: 19.99m);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 5, 2, "The Matrix is a 2003 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and as the second installment in the Matrix franchise, Six months after the events of The Matrix, Neo and Trinity are now romantically involved. Morpheus receives a message from Captain Niobe of the Logos calling an emergency meeting of all ships of Zion. An army of Sentinels is tunneling towards Zion and will reach it within 72 hours. Commander Lock orders all ships to return to Zion to prepare, but Morpheus asks one ship to remain to contact the Oracle. Within the Matrix, the lone ship's crew is encountered by the former Agent Smith, who copies himself over the body of crew member Bane and uses the phone line to leave the Matrix.", "https://upload.wikimedia.org/wikipedia/en/b/ba/Poster_-_The_Matrix_Reloaded.jpg", 19.99m, "The Matrix Reloaded" },
                    { 6, 2, "The Matrix is a 2003 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and as the third installment in the Matrix franchise, Picking up immediately where Reloaded ended, Neo and Bane still lie unconscious in the medical bay of the ship Hammer. Inside the Matrix, Neo is trapped in a subway station named Mobil Ave, a transition zone between the Matrix and the machine world. He meets a \"family\" of programs, including a girl named Sati.", "https://upload.wikimedia.org/wikipedia/en/3/34/Matrix_revolutions_ver7.jpg", 19.99m, "The Matrix Revolutions" },
                    { 7, 2, "The Matrix is a 2021 science fiction action film written and directed by the Lana Wachowski, and produced by Lana Wachowski. Starring Keanu Reeves, Carrie-Anne Moss, and is the final installment in the Matrix franchise.", "https://upload.wikimedia.org/wikipedia/en/5/50/The_Matrix_Resurrections.jpg", 19.99m, "The Matrix Resurrections" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Price",
                value: 0m);
        }
    }
}
