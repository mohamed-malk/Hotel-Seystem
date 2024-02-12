using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hotel_System.Migrations
{
    /// <inheritdoc />
    public partial class RemoveMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -1);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "Age", "Attend", "Email", "Gender", "NId", "Name", "Password", "Salary", "UserName" },
                values: new object[,]
                {
                    { -2, "Fayoum", 18, 26, "mostafa@gmail.com", true, "01234567891235", "Mostafa Yasser", "Mostafa23Malk26", 1000f, "mosMalk" },
                    { -1, "Fayoum", 21, 26, "mohamed@gmail.com", true, "01234567891234", "Mohamed Yasser", "Mohamed23Malk26", 1000f, "mohMalk" }
                });
        }
    }
}
