using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace graphql_library_management.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedValueBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Biography", "BirthDate", "Name" },
                values: new object[] { "Biography of Jane Smith", new DateTime(1992, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Doe" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Biography", "BirthDate", "Name" },
                values: new object[] { "Biography of John Doe", new DateTime(1989, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Doe" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Biography", "BirthDate", "Name" },
                values: new object[] { "Biography of John Doe", new DateTime(1982, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eve Wilson" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Biography", "BirthDate" },
                values: new object[] { "Biography of Jane Smith", new DateTime(1993, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Biography", "BirthDate", "Name" },
                values: new object[] { "Biography of Bob Brown", new DateTime(1973, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane Smith" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Biography", "BirthDate", "Name" },
                values: new object[] { "Biography of Alice Johnson", new DateTime(1995, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alice Johnson" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Biography", "BirthDate", "Name" },
                values: new object[] { "Biography of John Doe", new DateTime(1977, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Doe" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Biography", "BirthDate" },
                values: new object[] { "Biography of Jane Smith", new DateTime(1987, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Biography", "BirthDate", "Name" },
                values: new object[] { "Biography of Eve Wilson", new DateTime(1992, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alice Johnson" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BirthDate", "Name" },
                values: new object[] { new DateTime(1986, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Doe" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BirthDate", "Name" },
                values: new object[] { new DateTime(1976, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bob Brown" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Biography", "BirthDate", "Name" },
                values: new object[] { "Biography of Eve Wilson", new DateTime(1998, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alice Johnson" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BirthDate", "Name" },
                values: new object[] { new DateTime(1986, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eve Wilson" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BirthDate", "Name" },
                values: new object[] { new DateTime(1975, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eve Wilson" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15,
                column: "BirthDate",
                value: new DateTime(1992, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Biography", "BirthDate", "Name" },
                values: new object[] { "Biography of Bob Brown", new DateTime(1999, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Doe" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Biography", "BirthDate", "Name" },
                values: new object[] { "Biography of Alice Johnson", new DateTime(1990, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Doe" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Biography", "BirthDate", "Name" },
                values: new object[] { "Biography of Bob Brown", new DateTime(1985, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alice Johnson" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Biography", "BirthDate", "Name" },
                values: new object[] { "Biography of John Doe", new DateTime(1976, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane Smith" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BirthDate", "Name" },
                values: new object[] { new DateTime(1990, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eve Wilson" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AuthorId", "CoverImageUrl", "Description", "Genre", "PublishedDate", "Rating", "Synopsis", "Title" },
                values: new object[,]
                {
                    { 1, 17, "https://example.com/book-covers/book1.jpg", "Description B", "Fiction", new DateTime(2022, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Synopsis D", "Book D" },
                    { 2, 6, "https://example.com/book-covers/book2.jpg", "Description D", "Mystery", new DateTime(2006, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Synopsis A", "Book D" },
                    { 3, 10, "https://example.com/book-covers/book3.jpg", "Description A", "Science Fiction", new DateTime(2020, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Synopsis C", "Book D" },
                    { 4, 2, "https://example.com/book-covers/book4.jpg", "Description C", "Romance", new DateTime(2006, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Synopsis A", "Book C" },
                    { 5, 18, "https://example.com/book-covers/book5.jpg", "Description C", "Fiction", new DateTime(2010, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Synopsis E", "Book D" },
                    { 6, 17, "https://example.com/book-covers/book6.jpg", "Description E", "Mystery", new DateTime(2002, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Synopsis D", "Book D" },
                    { 7, 9, "https://example.com/book-covers/book7.jpg", "Description B", "Science Fiction", new DateTime(2015, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Synopsis B", "Book E" },
                    { 8, 5, "https://example.com/book-covers/book8.jpg", "Description E", "Science Fiction", new DateTime(2000, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Synopsis D", "Book A" },
                    { 9, 13, "https://example.com/book-covers/book9.jpg", "Description B", "Romance", new DateTime(2017, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Synopsis B", "Book A" },
                    { 10, 14, "https://example.com/book-covers/book10.jpg", "Description D", "Science Fiction", new DateTime(2014, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Synopsis A", "Book E" },
                    { 11, 20, "https://example.com/book-covers/book11.jpg", "Description A", "Fantasy", new DateTime(2019, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Synopsis A", "Book B" },
                    { 12, 20, "https://example.com/book-covers/book12.jpg", "Description E", "Mystery", new DateTime(2002, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Synopsis E", "Book D" },
                    { 13, 13, "https://example.com/book-covers/book13.jpg", "Description D", "Science Fiction", new DateTime(2020, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Synopsis B", "Book B" },
                    { 14, 5, "https://example.com/book-covers/book14.jpg", "Description D", "Mystery", new DateTime(2016, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Synopsis E", "Book A" },
                    { 15, 2, "https://example.com/book-covers/book15.jpg", "Description D", "Mystery", new DateTime(2020, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Synopsis C", "Book E" },
                    { 16, 17, "https://example.com/book-covers/book16.jpg", "Description B", "Fantasy", new DateTime(2006, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Synopsis E", "Book C" },
                    { 17, 9, "https://example.com/book-covers/book17.jpg", "Description A", "Science Fiction", new DateTime(2013, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Synopsis C", "Book E" },
                    { 18, 12, "https://example.com/book-covers/book18.jpg", "Description D", "Romance", new DateTime(2001, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Synopsis E", "Book C" },
                    { 19, 6, "https://example.com/book-covers/book19.jpg", "Description E", "Romance", new DateTime(2003, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Synopsis C", "Book D" },
                    { 20, 16, "https://example.com/book-covers/book20.jpg", "Description C", "Science Fiction", new DateTime(2002, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Synopsis B", "Book B" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Biography", "BirthDate", "Name" },
                values: new object[] { "Biography of John Doe", new DateTime(1982, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane Smith" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Biography", "BirthDate", "Name" },
                values: new object[] { "Biography of Jane Smith", new DateTime(1970, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bob Brown" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Biography", "BirthDate", "Name" },
                values: new object[] { "Biography of Bob Brown", new DateTime(1986, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alice Johnson" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Biography", "BirthDate" },
                values: new object[] { "Biography of Bob Brown", new DateTime(1986, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Biography", "BirthDate", "Name" },
                values: new object[] { "Biography of Jane Smith", new DateTime(1975, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eve Wilson" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Biography", "BirthDate", "Name" },
                values: new object[] { "Biography of Bob Brown", new DateTime(1983, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eve Wilson" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Biography", "BirthDate", "Name" },
                values: new object[] { "Biography of Eve Wilson", new DateTime(1983, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane Smith" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Biography", "BirthDate" },
                values: new object[] { "Biography of Alice Johnson", new DateTime(1978, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Biography", "BirthDate", "Name" },
                values: new object[] { "Biography of John Doe", new DateTime(1984, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane Smith" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BirthDate", "Name" },
                values: new object[] { new DateTime(1991, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alice Johnson" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BirthDate", "Name" },
                values: new object[] { new DateTime(1975, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane Smith" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Biography", "BirthDate", "Name" },
                values: new object[] { "Biography of Bob Brown", new DateTime(1977, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Doe" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BirthDate", "Name" },
                values: new object[] { new DateTime(1976, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bob Brown" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BirthDate", "Name" },
                values: new object[] { new DateTime(1988, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane Smith" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15,
                column: "BirthDate",
                value: new DateTime(1979, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Biography", "BirthDate", "Name" },
                values: new object[] { "Biography of John Doe", new DateTime(1971, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eve Wilson" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Biography", "BirthDate", "Name" },
                values: new object[] { "Biography of Jane Smith", new DateTime(1973, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alice Johnson" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Biography", "BirthDate", "Name" },
                values: new object[] { "Biography of Jane Smith", new DateTime(1985, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane Smith" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Biography", "BirthDate", "Name" },
                values: new object[] { "Biography of Alice Johnson", new DateTime(1983, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bob Brown" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BirthDate", "Name" },
                values: new object[] { new DateTime(1995, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bob Brown" });
        }
    }
}
