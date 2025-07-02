using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CrudService.Migrations
{
    /// <inheritdoc />
    public partial class seedcategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "id", "DisplayOrder", "name" },
                values: new object[,]
                {
                    { 1, 1, "kiran" },
                    { 2, 2, "samiksha" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2);
        }
    }
}
