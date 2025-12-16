using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HW22.Infra.Db.SqlServer.Ef.Migrations
{
    /// <inheritdoc />
    public partial class removeIsAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "dcf2026f-5b6b-4398-bf10-0f31d0a394fb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "3caf51a1-ce89-4758-bf8b-14a8587af6b0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "415f0fc6-7a74-4e5d-aff6-a2a4653de6c5", "AQAAAAIAAYagAAAAEI3QcCewBTteVB/bNtgTX9HpMj10Wk45CHt/KrL4niJ2zEnLK/d0ABbPThZy+CIQrA==", "d5874820-81bf-4f9c-8351-d076ee58a73f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb290167-8b3a-4807-83b2-cf0f5d46d579", "AQAAAAIAAYagAAAAEKK3Ocsm5Y0rALrkQMFglbjXtuPf8pcg+FvGUr/UCMAhAQYUjPLc+yMbetlDYfg/3g==", "2befc708-c757-4328-964e-1f72ad3fb95a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30af6b85-19d5-4b52-afab-618a6dfb1bda", "AQAAAAIAAYagAAAAEAfBr/j0o6CkMnHV6oUlO+bDv2QG5CUJ8uUZNK0O0dGwKtBdDh2H0/DAGdGy88yIUA==", "f1c097d2-d955-4e0d-87e4-b0f476d2e55b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0340c9d-8e34-42e6-b2c6-c9cf6622f87f", "AQAAAAIAAYagAAAAEEflNpVnS8dDU9s3oD61v/g00SgJyp0X2lhlk0WHldX3lciuUUpwAqsPT9X1mf03Ww==", "c3a6a4d3-5f02-429e-bb41-699c73d672d7" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "IsAdmin", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff89b17b-a803-4ac1-91db-cc8fc6b66fff", true, "AQAAAAIAAYagAAAAEMM58qKIFL22PZFon3m/tQmjFiruTFw5kADAMG0Bc9+emuZrzAram/avE92NTVbckQ==", "14bc1c37-25ea-45d9-be2b-68e523069bb8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "IsAdmin", "PasswordHash", "SecurityStamp" },
                values: new object[] { "731c8b9b-a76e-4ad5-827a-836f0aef51b0", false, "AQAAAAIAAYagAAAAEMIe7ug0uhcrMYTFTfL1iPz12IoKDPxcuTZ5CkA8SmNFK16ibXEJuBF9a/sd5+82gw==", "706ff98c-a15c-458c-ba85-cbff520d85b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "IsAdmin", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4babd690-65df-4aa2-b39d-4723e177e1ce", false, "AQAAAAIAAYagAAAAEBJX9Xtp545c5+MhbUZthTJ55pE6f23EFGvo5Cq83Xrw8/c9uha+/nUDp+3hnPPm1g==", "1d183e99-e36a-4857-bea2-849d8be316e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "IsAdmin", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5726751-8c43-48ee-9b15-4bb65b862280", false, "AQAAAAIAAYagAAAAEMjBNcxQJSeevlLlP99bAX6nZpOaKG9G6Z/Q4LYMfYTHsNwdGm8x3HBh4wOh3v/itg==", "afbb7b6f-8ada-4a04-a72f-c06f7c7f93d1" });
        }
    }
}
