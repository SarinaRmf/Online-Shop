using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HW22.Infra.Db.SqlServer.Ef.Migrations
{
    /// <inheritdoc />
    public partial class chanhePhoto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImagePath",
                value: "/Images/Products/1.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImagePath",
                value: "/Images/Products/product-02");
        }
    }
}
