using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HW22.Infra.Db.SqlServer.Ef.Migrations
{
    /// <inheritdoc />
    public partial class configrolesuserRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "911fb0ff-b74c-4863-94b9-6626a46f4898");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "887fe687-a42c-4532-9b49-de26fad17e7f");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff89b17b-a803-4ac1-91db-cc8fc6b66fff", "AQAAAAIAAYagAAAAEMM58qKIFL22PZFon3m/tQmjFiruTFw5kADAMG0Bc9+emuZrzAram/avE92NTVbckQ==", "14bc1c37-25ea-45d9-be2b-68e523069bb8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "731c8b9b-a76e-4ad5-827a-836f0aef51b0", "AQAAAAIAAYagAAAAEMIe7ug0uhcrMYTFTfL1iPz12IoKDPxcuTZ5CkA8SmNFK16ibXEJuBF9a/sd5+82gw==", "706ff98c-a15c-458c-ba85-cbff520d85b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4babd690-65df-4aa2-b39d-4723e177e1ce", "AQAAAAIAAYagAAAAEBJX9Xtp545c5+MhbUZthTJ55pE6f23EFGvo5Cq83Xrw8/c9uha+/nUDp+3hnPPm1g==", "1d183e99-e36a-4857-bea2-849d8be316e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5726751-8c43-48ee-9b15-4bb65b862280", "AQAAAAIAAYagAAAAEMjBNcxQJSeevlLlP99bAX6nZpOaKG9G6Z/Q4LYMfYTHsNwdGm8x3HBh4wOh3v/itg==", "afbb7b6f-8ada-4a04-a72f-c06f7c7f93d1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "dad7e804-bea4-4755-85d1-b4e66754d7be");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "27f2f1b7-40b3-4a2c-8417-25917ad0e824");

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
    }
}
