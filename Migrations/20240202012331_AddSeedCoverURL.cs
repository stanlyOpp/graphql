using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace graphql_library_management.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedCoverURL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Books",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Synopsis",
                table: "Books",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Genre",
                table: "Books",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Books",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CoverImageUrl",
                table: "Books",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Authors",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Biography",
                table: "Authors",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Biography", "BirthDate", "Name" },
                values: new object[] { "Biography of Alice Johnson", new DateTime(1993, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane Smith" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Biography", "BirthDate", "Name" },
                values: new object[] { "Biography of Jane Smith", new DateTime(1995, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bob Brown" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Biography", "BirthDate", "Name" },
                values: new object[] { "Biography of Jane Smith", new DateTime(1984, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bob Brown" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Biography", "BirthDate", "Name" },
                values: new object[] { "Biography of Alice Johnson", new DateTime(1973, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Doe" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Biography", "BirthDate" },
                values: new object[] { "Biography of Eve Wilson", new DateTime(1980, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BirthDate", "Name" },
                values: new object[] { new DateTime(2000, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eve Wilson" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Biography", "BirthDate", "Name" },
                values: new object[] { "Biography of Jane Smith", new DateTime(1989, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane Smith" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Biography", "BirthDate", "Name" },
                values: new object[] { "Biography of Eve Wilson", new DateTime(1970, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eve Wilson" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Biography", "BirthDate" },
                values: new object[] { "Biography of Jane Smith", new DateTime(1977, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Biography", "BirthDate", "Name" },
                values: new object[] { "Biography of Bob Brown", new DateTime(1974, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alice Johnson" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BirthDate", "Name" },
                values: new object[] { new DateTime(1996, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Doe" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Biography", "BirthDate", "Name" },
                values: new object[] { "Biography of Bob Brown", new DateTime(2000, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eve Wilson" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Biography", "BirthDate", "Name" },
                values: new object[] { "Biography of Alice Johnson", new DateTime(1987, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Doe" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Biography", "BirthDate" },
                values: new object[] { "Biography of Bob Brown", new DateTime(1976, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Biography", "BirthDate", "Name" },
                values: new object[] { "Biography of Jane Smith", new DateTime(1994, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eve Wilson" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Biography", "BirthDate", "Name" },
                values: new object[] { "Biography of John Doe", new DateTime(1972, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alice Johnson" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BirthDate", "Name" },
                values: new object[] { new DateTime(1995, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alice Johnson" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Biography", "BirthDate" },
                values: new object[] { "Biography of Alice Johnson", new DateTime(1973, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Biography", "BirthDate" },
                values: new object[] { "Biography of Jane Smith", new DateTime(1997, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Biography", "BirthDate", "Name" },
                values: new object[] { "Biography of Eve Wilson", new DateTime(1989, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alice Johnson" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "AuthorId", "CoverImageUrl", "Description", "PublishedDate", "Rating", "Title" },
                values: new object[] { 16, "https://cdn-shop.ookbee.com/Books/AmarinBooks/2020/20201026044459/Thumbnails/Cover.jpg", "Description D", new DateTime(2000, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Book A" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                columns: new[] { "AuthorId", "CoverImageUrl", "Description", "Genre", "PublishedDate", "Rating", "Synopsis", "Title" },
                values: new object[] { 13, "https://cdn-shop.ookbee.com/Books/AmarinBooks/2020/20201026044459/Thumbnails/Cover.jpg", "Description A", "Fiction", new DateTime(2005, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Synopsis D", "Book E" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                columns: new[] { "AuthorId", "CoverImageUrl", "Description", "PublishedDate", "Rating", "Synopsis", "Title" },
                values: new object[] { 9, "https://cdn-shop.ookbee.com/Books/AmarinBooks/2020/20201026044459/Thumbnails/Cover.jpg", "Description C", new DateTime(2011, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Synopsis D", "Book B" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4,
                columns: new[] { "AuthorId", "CoverImageUrl", "Description", "PublishedDate", "Rating", "Title" },
                values: new object[] { 20, "https://cdn-shop.ookbee.com/Books/AmarinBooks/2020/20201026044459/Thumbnails/Cover.jpg", "Description E", new DateTime(2006, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Book D" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5,
                columns: new[] { "AuthorId", "CoverImageUrl", "Genre", "PublishedDate", "Synopsis", "Title" },
                values: new object[] { 7, "https://cdn-shop.ookbee.com/Books/AmarinBooks/2020/20201026044459/Thumbnails/Cover.jpg", "Fantasy", new DateTime(2019, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Synopsis D", "Book B" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6,
                columns: new[] { "AuthorId", "CoverImageUrl", "Description", "Genre", "PublishedDate", "Rating", "Title" },
                values: new object[] { 16, "https://cdn-shop.ookbee.com/Books/AmarinBooks/2020/20201026044459/Thumbnails/Cover.jpg", "Description C", "Fiction", new DateTime(2008, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Book B" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7,
                columns: new[] { "AuthorId", "CoverImageUrl", "Description", "Genre", "PublishedDate", "Rating", "Synopsis", "Title" },
                values: new object[] { 12, "https://cdn-shop.ookbee.com/Books/AmarinBooks/2020/20201026044459/Thumbnails/Cover.jpg", "Description A", "Fantasy", new DateTime(2000, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Synopsis D", "Book D" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8,
                columns: new[] { "AuthorId", "CoverImageUrl", "Description", "PublishedDate", "Rating", "Synopsis", "Title" },
                values: new object[] { 3, "https://cdn-shop.ookbee.com/Books/AmarinBooks/2020/20201026044459/Thumbnails/Cover.jpg", "Description D", new DateTime(2000, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Synopsis B", "Book B" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9,
                columns: new[] { "AuthorId", "CoverImageUrl", "Description", "Genre", "PublishedDate", "Rating", "Synopsis", "Title" },
                values: new object[] { 1, "https://cdn-shop.ookbee.com/Books/AmarinBooks/2020/20201026044459/Thumbnails/Cover.jpg", "Description E", "Mystery", new DateTime(2011, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Synopsis D", "Book B" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10,
                columns: new[] { "AuthorId", "CoverImageUrl", "Description", "Genre", "PublishedDate", "Rating", "Title" },
                values: new object[] { 7, "https://cdn-shop.ookbee.com/Books/AmarinBooks/2020/20201026044459/Thumbnails/Cover.jpg", "Description A", "Mystery", new DateTime(2021, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Book B" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 11,
                columns: new[] { "AuthorId", "CoverImageUrl", "Description", "Genre", "PublishedDate", "Synopsis", "Title" },
                values: new object[] { 18, "https://cdn-shop.ookbee.com/Books/AmarinBooks/2020/20201026044459/Thumbnails/Cover.jpg", "Description C", "Fiction", new DateTime(2011, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Synopsis C", "Book A" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 12,
                columns: new[] { "AuthorId", "CoverImageUrl", "Description", "Genre", "PublishedDate", "Rating", "Synopsis", "Title" },
                values: new object[] { 15, "https://cdn-shop.ookbee.com/Books/AmarinBooks/2020/20201026044459/Thumbnails/Cover.jpg", "Description B", "Romance", new DateTime(2008, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Synopsis D", "Book E" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 13,
                columns: new[] { "AuthorId", "CoverImageUrl", "Description", "Genre", "PublishedDate", "Rating", "Title" },
                values: new object[] { 20, "https://cdn-shop.ookbee.com/Books/AmarinBooks/2020/20201026044459/Thumbnails/Cover.jpg", "Description A", "Fiction", new DateTime(2011, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Book D" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 14,
                columns: new[] { "AuthorId", "CoverImageUrl", "Genre", "PublishedDate", "Rating", "Synopsis", "Title" },
                values: new object[] { 20, "https://cdn-shop.ookbee.com/Books/AmarinBooks/2020/20201026044459/Thumbnails/Cover.jpg", "Fantasy", new DateTime(2015, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Synopsis D", "Book B" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 15,
                columns: new[] { "AuthorId", "CoverImageUrl", "Description", "Genre", "PublishedDate", "Rating", "Title" },
                values: new object[] { 6, "https://cdn-shop.ookbee.com/Books/AmarinBooks/2020/20201026044459/Thumbnails/Cover.jpg", "Description A", "Fiction", new DateTime(2002, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Book A" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 16,
                columns: new[] { "AuthorId", "CoverImageUrl", "Genre", "PublishedDate", "Rating", "Title" },
                values: new object[] { 8, "https://cdn-shop.ookbee.com/Books/AmarinBooks/2020/20201026044459/Thumbnails/Cover.jpg", "Fiction", new DateTime(2009, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Book B" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 17,
                columns: new[] { "AuthorId", "CoverImageUrl", "Description", "Genre", "PublishedDate", "Synopsis", "Title" },
                values: new object[] { 20, "https://cdn-shop.ookbee.com/Books/AmarinBooks/2020/20201026044459/Thumbnails/Cover.jpg", "Description D", "Fiction", new DateTime(2009, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Synopsis D", "Book D" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 18,
                columns: new[] { "AuthorId", "CoverImageUrl", "Genre", "PublishedDate", "Title" },
                values: new object[] { 16, "https://cdn-shop.ookbee.com/Books/AmarinBooks/2020/20201026044459/Thumbnails/Cover.jpg", "Mystery", new DateTime(2000, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book B" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 19,
                columns: new[] { "AuthorId", "CoverImageUrl", "Description", "Genre", "PublishedDate", "Rating", "Synopsis", "Title" },
                values: new object[] { 11, "https://cdn-shop.ookbee.com/Books/AmarinBooks/2020/20201026044459/Thumbnails/Cover.jpg", "Description B", "Science Fiction", new DateTime(2019, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Synopsis B", "Book A" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 20,
                columns: new[] { "AuthorId", "CoverImageUrl", "Description", "PublishedDate", "Rating", "Synopsis", "Title" },
                values: new object[] { 7, "https://cdn-shop.ookbee.com/Books/AmarinBooks/2020/20201026044459/Thumbnails/Cover.jpg", "Description E", new DateTime(2012, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Synopsis D", "Book C" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Title",
                keyValue: null,
                column: "Title",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Books",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Synopsis",
                keyValue: null,
                column: "Synopsis",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Synopsis",
                table: "Books",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Genre",
                keyValue: null,
                column: "Genre",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Genre",
                table: "Books",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Description",
                keyValue: null,
                column: "Description",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Books",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "CoverImageUrl",
                keyValue: null,
                column: "CoverImageUrl",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "CoverImageUrl",
                table: "Books",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Name",
                keyValue: null,
                column: "Name",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Authors",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Biography",
                keyValue: null,
                column: "Biography",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Biography",
                table: "Authors",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

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
                columns: new[] { "Biography", "BirthDate", "Name" },
                values: new object[] { "Biography of Jane Smith", new DateTime(1993, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane Smith" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Biography", "BirthDate" },
                values: new object[] { "Biography of Bob Brown", new DateTime(1973, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BirthDate", "Name" },
                values: new object[] { new DateTime(1995, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alice Johnson" });

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
                columns: new[] { "Biography", "BirthDate", "Name" },
                values: new object[] { "Biography of Jane Smith", new DateTime(1987, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Doe" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Biography", "BirthDate" },
                values: new object[] { "Biography of Eve Wilson", new DateTime(1992, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Biography", "BirthDate", "Name" },
                values: new object[] { "Biography of Eve Wilson", new DateTime(1986, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Doe" });

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
                columns: new[] { "Biography", "BirthDate", "Name" },
                values: new object[] { "Biography of Bob Brown", new DateTime(1986, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eve Wilson" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Biography", "BirthDate" },
                values: new object[] { "Biography of Eve Wilson", new DateTime(1975, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Biography", "BirthDate", "Name" },
                values: new object[] { "Biography of Eve Wilson", new DateTime(1992, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alice Johnson" });

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
                columns: new[] { "BirthDate", "Name" },
                values: new object[] { new DateTime(1990, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Doe" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Biography", "BirthDate" },
                values: new object[] { "Biography of Bob Brown", new DateTime(1985, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Biography", "BirthDate" },
                values: new object[] { "Biography of John Doe", new DateTime(1976, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Biography", "BirthDate", "Name" },
                values: new object[] { "Biography of Alice Johnson", new DateTime(1990, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eve Wilson" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "AuthorId", "CoverImageUrl", "Description", "PublishedDate", "Rating", "Title" },
                values: new object[] { 17, "https://example.com/book-covers/book1.jpg", "Description B", new DateTime(2022, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Book D" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                columns: new[] { "AuthorId", "CoverImageUrl", "Description", "Genre", "PublishedDate", "Rating", "Synopsis", "Title" },
                values: new object[] { 6, "https://example.com/book-covers/book2.jpg", "Description D", "Mystery", new DateTime(2006, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Synopsis A", "Book D" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                columns: new[] { "AuthorId", "CoverImageUrl", "Description", "PublishedDate", "Rating", "Synopsis", "Title" },
                values: new object[] { 10, "https://example.com/book-covers/book3.jpg", "Description A", new DateTime(2020, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Synopsis C", "Book D" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4,
                columns: new[] { "AuthorId", "CoverImageUrl", "Description", "PublishedDate", "Rating", "Title" },
                values: new object[] { 2, "https://example.com/book-covers/book4.jpg", "Description C", new DateTime(2006, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Book C" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5,
                columns: new[] { "AuthorId", "CoverImageUrl", "Genre", "PublishedDate", "Synopsis", "Title" },
                values: new object[] { 18, "https://example.com/book-covers/book5.jpg", "Fiction", new DateTime(2010, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Synopsis E", "Book D" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6,
                columns: new[] { "AuthorId", "CoverImageUrl", "Description", "Genre", "PublishedDate", "Rating", "Title" },
                values: new object[] { 17, "https://example.com/book-covers/book6.jpg", "Description E", "Mystery", new DateTime(2002, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Book D" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7,
                columns: new[] { "AuthorId", "CoverImageUrl", "Description", "Genre", "PublishedDate", "Rating", "Synopsis", "Title" },
                values: new object[] { 9, "https://example.com/book-covers/book7.jpg", "Description B", "Science Fiction", new DateTime(2015, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Synopsis B", "Book E" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8,
                columns: new[] { "AuthorId", "CoverImageUrl", "Description", "PublishedDate", "Rating", "Synopsis", "Title" },
                values: new object[] { 5, "https://example.com/book-covers/book8.jpg", "Description E", new DateTime(2000, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Synopsis D", "Book A" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9,
                columns: new[] { "AuthorId", "CoverImageUrl", "Description", "Genre", "PublishedDate", "Rating", "Synopsis", "Title" },
                values: new object[] { 13, "https://example.com/book-covers/book9.jpg", "Description B", "Romance", new DateTime(2017, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Synopsis B", "Book A" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10,
                columns: new[] { "AuthorId", "CoverImageUrl", "Description", "Genre", "PublishedDate", "Rating", "Title" },
                values: new object[] { 14, "https://example.com/book-covers/book10.jpg", "Description D", "Science Fiction", new DateTime(2014, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Book E" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 11,
                columns: new[] { "AuthorId", "CoverImageUrl", "Description", "Genre", "PublishedDate", "Synopsis", "Title" },
                values: new object[] { 20, "https://example.com/book-covers/book11.jpg", "Description A", "Fantasy", new DateTime(2019, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Synopsis A", "Book B" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 12,
                columns: new[] { "AuthorId", "CoverImageUrl", "Description", "Genre", "PublishedDate", "Rating", "Synopsis", "Title" },
                values: new object[] { 20, "https://example.com/book-covers/book12.jpg", "Description E", "Mystery", new DateTime(2002, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Synopsis E", "Book D" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 13,
                columns: new[] { "AuthorId", "CoverImageUrl", "Description", "Genre", "PublishedDate", "Rating", "Title" },
                values: new object[] { 13, "https://example.com/book-covers/book13.jpg", "Description D", "Science Fiction", new DateTime(2020, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Book B" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 14,
                columns: new[] { "AuthorId", "CoverImageUrl", "Genre", "PublishedDate", "Rating", "Synopsis", "Title" },
                values: new object[] { 5, "https://example.com/book-covers/book14.jpg", "Mystery", new DateTime(2016, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Synopsis E", "Book A" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 15,
                columns: new[] { "AuthorId", "CoverImageUrl", "Description", "Genre", "PublishedDate", "Rating", "Title" },
                values: new object[] { 2, "https://example.com/book-covers/book15.jpg", "Description D", "Mystery", new DateTime(2020, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Book E" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 16,
                columns: new[] { "AuthorId", "CoverImageUrl", "Genre", "PublishedDate", "Rating", "Title" },
                values: new object[] { 17, "https://example.com/book-covers/book16.jpg", "Fantasy", new DateTime(2006, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Book C" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 17,
                columns: new[] { "AuthorId", "CoverImageUrl", "Description", "Genre", "PublishedDate", "Synopsis", "Title" },
                values: new object[] { 9, "https://example.com/book-covers/book17.jpg", "Description A", "Science Fiction", new DateTime(2013, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Synopsis C", "Book E" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 18,
                columns: new[] { "AuthorId", "CoverImageUrl", "Genre", "PublishedDate", "Title" },
                values: new object[] { 12, "https://example.com/book-covers/book18.jpg", "Romance", new DateTime(2001, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book C" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 19,
                columns: new[] { "AuthorId", "CoverImageUrl", "Description", "Genre", "PublishedDate", "Rating", "Synopsis", "Title" },
                values: new object[] { 6, "https://example.com/book-covers/book19.jpg", "Description E", "Romance", new DateTime(2003, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Synopsis C", "Book D" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 20,
                columns: new[] { "AuthorId", "CoverImageUrl", "Description", "PublishedDate", "Rating", "Synopsis", "Title" },
                values: new object[] { 16, "https://example.com/book-covers/book20.jpg", "Description C", new DateTime(2002, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Synopsis B", "Book B" });
        }
    }
}
