using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HW22.Infra.Db.SqlServer.Ef.Migrations
{
    /// <inheritdoc />
    public partial class configroles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "dad7e804-bea4-4755-85d1-b4e66754d7be", "Admin", "ADMIN" },
                    { 2, "27f2f1b7-40b3-4a2c-8417-25917ad0e824", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4bb3d167-9ae7-45b8-9408-7d17574ea47c", "AQAAAAIAAYagAAAAEHwDI95OPt1peApa0CWK82GANIrtOk+c1CNDZ8UsKdEy9bCy1yAQiI4DbZ3Ankxh9w==", "0c8b107e-4bb7-4a08-b463-f11812b8f89a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc45e8aa-182b-4340-85c0-d276e2ea8442", "AQAAAAIAAYagAAAAEHIu4gY7V8dMrLqT0cxI+mgzrv9eg/YfG2JtTRpyNzqcYMZrwGGbopYdjw2Up+IEPg==", "98dcc501-97eb-463c-b6c3-51ec7b6dc595" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ad94f5e-fd27-4f82-88af-c4eb94e54eeb", "AQAAAAIAAYagAAAAEH/z6/nbozwZSC8xv3fGqUswOO3SHvGXgbR7kinwvVUwnKoloxZbr62euj5a6iwl/Q==", "fdc8dd7e-5ae2-4640-95f0-a423daba663a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38422c40-c04d-4a61-88ad-269b988e95cf", "AQAAAAIAAYagAAAAEA6itIOykc4htuzhNXC14lNaMT/CbrvID7aLuU5weXBwPkTe3F+qsB6b3hDHkACzQA==", "edb76063-3a82-46ba-bc9c-f808015a7f60" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a232e3bb-e502-4db0-b56a-22357a74bd90", "AQAAAAIAAYagAAAAEEYoG89KOmKFHD1Pd1GaVS9qU0cHnlKOZICKwLf5oCYXUwEFyswEzj8HtYbqPxL2xg==", "7c6cd3f7-8331-48e4-853b-327af1f26092" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb2b2b8a-c738-487e-a2be-112b867bf24c", "AQAAAAIAAYagAAAAEDY/lGeYr7OUv7x3SCqyrL7B6sDsWCCxLrep+jLkOiX3bN7Ad8jIDsDs2pYH+J6c6Q==", "ad5dfbfb-1126-4d81-a913-3019bb663342" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0b7e210-5ca4-49f7-9932-3c560d5f3175", "AQAAAAIAAYagAAAAEIKutsTdEGDJ0P/YevQsE5/COOgSINARtosXddDuYveNgcV4XzsCvGi+KrBuwCKzcw==", "2f455115-e088-4afa-ae65-8e84376f37b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9ca129b-2b36-4611-b740-bb669f94e91b", "AQAAAAIAAYagAAAAEDZdlrWcbZpSXnBz9E/5MwMMLB9C5fqPLH4rDIizYwY/PKaPSsuQa+qR5T9YzvW8DQ==", "efb6a912-da7d-4f16-aa1f-2f34a1d2f708" });
        }
    }
}
