using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace graphql_library_management.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedValueAuthorPerson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Biography", "BirthDate", "Name" },
                values: new object[,]
                {
                    { 1, "Biography of John Doe", new DateTime(1982, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane Smith" },
                    { 2, "Biography of Jane Smith", new DateTime(1970, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bob Brown" },
                    { 3, "Biography of Bob Brown", new DateTime(1986, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alice Johnson" },
                    { 4, "Biography of Bob Brown", new DateTime(1986, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane Smith" },
                    { 5, "Biography of Jane Smith", new DateTime(1975, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eve Wilson" },
                    { 6, "Biography of Bob Brown", new DateTime(1983, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eve Wilson" },
                    { 7, "Biography of Eve Wilson", new DateTime(1983, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane Smith" },
                    { 8, "Biography of Alice Johnson", new DateTime(1978, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Doe" },
                    { 9, "Biography of John Doe", new DateTime(1984, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane Smith" },
                    { 10, "Biography of Eve Wilson", new DateTime(1991, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alice Johnson" },
                    { 11, "Biography of John Doe", new DateTime(1975, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane Smith" },
                    { 12, "Biography of Bob Brown", new DateTime(1977, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Doe" },
                    { 13, "Biography of Bob Brown", new DateTime(1976, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bob Brown" },
                    { 14, "Biography of Eve Wilson", new DateTime(1988, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane Smith" },
                    { 15, "Biography of Eve Wilson", new DateTime(1979, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alice Johnson" },
                    { 16, "Biography of John Doe", new DateTime(1971, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eve Wilson" },
                    { 17, "Biography of Jane Smith", new DateTime(1973, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alice Johnson" },
                    { 18, "Biography of Jane Smith", new DateTime(1985, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane Smith" },
                    { 19, "Biography of Alice Johnson", new DateTime(1983, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bob Brown" },
                    { 20, "Biography of Alice Johnson", new DateTime(1995, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bob Brown" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
