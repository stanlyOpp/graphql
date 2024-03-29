﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using graphql_library_management.Models;

#nullable disable

namespace graphql_library_management.Migrations
{
    [DbContext(typeof(BookDbContext))]
    [Migration("20240202012331_AddSeedCoverURL")]
    partial class AddSeedCoverURL
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("graphql_library_management.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Biography")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Biography = "Biography of Alice Johnson",
                            BirthDate = new DateTime(1993, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Jane Smith"
                        },
                        new
                        {
                            Id = 2,
                            Biography = "Biography of Jane Smith",
                            BirthDate = new DateTime(1995, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Bob Brown"
                        },
                        new
                        {
                            Id = 3,
                            Biography = "Biography of Jane Smith",
                            BirthDate = new DateTime(1984, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Bob Brown"
                        },
                        new
                        {
                            Id = 4,
                            Biography = "Biography of Alice Johnson",
                            BirthDate = new DateTime(1973, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "John Doe"
                        },
                        new
                        {
                            Id = 5,
                            Biography = "Biography of Eve Wilson",
                            BirthDate = new DateTime(1980, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Jane Smith"
                        },
                        new
                        {
                            Id = 6,
                            Biography = "Biography of Alice Johnson",
                            BirthDate = new DateTime(2000, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Eve Wilson"
                        },
                        new
                        {
                            Id = 7,
                            Biography = "Biography of Jane Smith",
                            BirthDate = new DateTime(1989, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Jane Smith"
                        },
                        new
                        {
                            Id = 8,
                            Biography = "Biography of Eve Wilson",
                            BirthDate = new DateTime(1970, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Eve Wilson"
                        },
                        new
                        {
                            Id = 9,
                            Biography = "Biography of Jane Smith",
                            BirthDate = new DateTime(1977, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Alice Johnson"
                        },
                        new
                        {
                            Id = 10,
                            Biography = "Biography of Bob Brown",
                            BirthDate = new DateTime(1974, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Alice Johnson"
                        },
                        new
                        {
                            Id = 11,
                            Biography = "Biography of John Doe",
                            BirthDate = new DateTime(1996, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "John Doe"
                        },
                        new
                        {
                            Id = 12,
                            Biography = "Biography of Bob Brown",
                            BirthDate = new DateTime(2000, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Eve Wilson"
                        },
                        new
                        {
                            Id = 13,
                            Biography = "Biography of Alice Johnson",
                            BirthDate = new DateTime(1987, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "John Doe"
                        },
                        new
                        {
                            Id = 14,
                            Biography = "Biography of Bob Brown",
                            BirthDate = new DateTime(1976, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Eve Wilson"
                        },
                        new
                        {
                            Id = 15,
                            Biography = "Biography of Jane Smith",
                            BirthDate = new DateTime(1994, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Eve Wilson"
                        },
                        new
                        {
                            Id = 16,
                            Biography = "Biography of John Doe",
                            BirthDate = new DateTime(1972, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Alice Johnson"
                        },
                        new
                        {
                            Id = 17,
                            Biography = "Biography of Alice Johnson",
                            BirthDate = new DateTime(1995, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Alice Johnson"
                        },
                        new
                        {
                            Id = 18,
                            Biography = "Biography of Alice Johnson",
                            BirthDate = new DateTime(1973, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Alice Johnson"
                        },
                        new
                        {
                            Id = 19,
                            Biography = "Biography of Jane Smith",
                            BirthDate = new DateTime(1997, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Jane Smith"
                        },
                        new
                        {
                            Id = 20,
                            Biography = "Biography of Eve Wilson",
                            BirthDate = new DateTime(1989, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Alice Johnson"
                        });
                });

            modelBuilder.Entity("graphql_library_management.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("CoverImageUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Genre")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("PublishedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Synopsis")
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.HasKey("BookId");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            AuthorId = 16,
                            CoverImageUrl = "https://cdn-shop.ookbee.com/Books/AmarinBooks/2020/20201026044459/Thumbnails/Cover.jpg",
                            Description = "Description D",
                            Genre = "Fiction",
                            PublishedDate = new DateTime(2000, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rating = 1,
                            Synopsis = "Synopsis D",
                            Title = "Book A"
                        },
                        new
                        {
                            BookId = 2,
                            AuthorId = 13,
                            CoverImageUrl = "https://cdn-shop.ookbee.com/Books/AmarinBooks/2020/20201026044459/Thumbnails/Cover.jpg",
                            Description = "Description A",
                            Genre = "Fiction",
                            PublishedDate = new DateTime(2005, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rating = 3,
                            Synopsis = "Synopsis D",
                            Title = "Book E"
                        },
                        new
                        {
                            BookId = 3,
                            AuthorId = 9,
                            CoverImageUrl = "https://cdn-shop.ookbee.com/Books/AmarinBooks/2020/20201026044459/Thumbnails/Cover.jpg",
                            Description = "Description C",
                            Genre = "Science Fiction",
                            PublishedDate = new DateTime(2011, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rating = 5,
                            Synopsis = "Synopsis D",
                            Title = "Book B"
                        },
                        new
                        {
                            BookId = 4,
                            AuthorId = 20,
                            CoverImageUrl = "https://cdn-shop.ookbee.com/Books/AmarinBooks/2020/20201026044459/Thumbnails/Cover.jpg",
                            Description = "Description E",
                            Genre = "Romance",
                            PublishedDate = new DateTime(2006, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rating = 3,
                            Synopsis = "Synopsis A",
                            Title = "Book D"
                        },
                        new
                        {
                            BookId = 5,
                            AuthorId = 7,
                            CoverImageUrl = "https://cdn-shop.ookbee.com/Books/AmarinBooks/2020/20201026044459/Thumbnails/Cover.jpg",
                            Description = "Description C",
                            Genre = "Fantasy",
                            PublishedDate = new DateTime(2019, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rating = 4,
                            Synopsis = "Synopsis D",
                            Title = "Book B"
                        },
                        new
                        {
                            BookId = 6,
                            AuthorId = 16,
                            CoverImageUrl = "https://cdn-shop.ookbee.com/Books/AmarinBooks/2020/20201026044459/Thumbnails/Cover.jpg",
                            Description = "Description C",
                            Genre = "Fiction",
                            PublishedDate = new DateTime(2008, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rating = 5,
                            Synopsis = "Synopsis D",
                            Title = "Book B"
                        },
                        new
                        {
                            BookId = 7,
                            AuthorId = 12,
                            CoverImageUrl = "https://cdn-shop.ookbee.com/Books/AmarinBooks/2020/20201026044459/Thumbnails/Cover.jpg",
                            Description = "Description A",
                            Genre = "Fantasy",
                            PublishedDate = new DateTime(2000, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rating = 2,
                            Synopsis = "Synopsis D",
                            Title = "Book D"
                        },
                        new
                        {
                            BookId = 8,
                            AuthorId = 3,
                            CoverImageUrl = "https://cdn-shop.ookbee.com/Books/AmarinBooks/2020/20201026044459/Thumbnails/Cover.jpg",
                            Description = "Description D",
                            Genre = "Science Fiction",
                            PublishedDate = new DateTime(2000, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rating = 1,
                            Synopsis = "Synopsis B",
                            Title = "Book B"
                        },
                        new
                        {
                            BookId = 9,
                            AuthorId = 1,
                            CoverImageUrl = "https://cdn-shop.ookbee.com/Books/AmarinBooks/2020/20201026044459/Thumbnails/Cover.jpg",
                            Description = "Description E",
                            Genre = "Mystery",
                            PublishedDate = new DateTime(2011, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rating = 4,
                            Synopsis = "Synopsis D",
                            Title = "Book B"
                        },
                        new
                        {
                            BookId = 10,
                            AuthorId = 7,
                            CoverImageUrl = "https://cdn-shop.ookbee.com/Books/AmarinBooks/2020/20201026044459/Thumbnails/Cover.jpg",
                            Description = "Description A",
                            Genre = "Mystery",
                            PublishedDate = new DateTime(2021, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rating = 3,
                            Synopsis = "Synopsis A",
                            Title = "Book B"
                        },
                        new
                        {
                            BookId = 11,
                            AuthorId = 18,
                            CoverImageUrl = "https://cdn-shop.ookbee.com/Books/AmarinBooks/2020/20201026044459/Thumbnails/Cover.jpg",
                            Description = "Description C",
                            Genre = "Fiction",
                            PublishedDate = new DateTime(2011, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rating = 1,
                            Synopsis = "Synopsis C",
                            Title = "Book A"
                        },
                        new
                        {
                            BookId = 12,
                            AuthorId = 15,
                            CoverImageUrl = "https://cdn-shop.ookbee.com/Books/AmarinBooks/2020/20201026044459/Thumbnails/Cover.jpg",
                            Description = "Description B",
                            Genre = "Romance",
                            PublishedDate = new DateTime(2008, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rating = 5,
                            Synopsis = "Synopsis D",
                            Title = "Book E"
                        },
                        new
                        {
                            BookId = 13,
                            AuthorId = 20,
                            CoverImageUrl = "https://cdn-shop.ookbee.com/Books/AmarinBooks/2020/20201026044459/Thumbnails/Cover.jpg",
                            Description = "Description A",
                            Genre = "Fiction",
                            PublishedDate = new DateTime(2011, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rating = 3,
                            Synopsis = "Synopsis B",
                            Title = "Book D"
                        },
                        new
                        {
                            BookId = 14,
                            AuthorId = 20,
                            CoverImageUrl = "https://cdn-shop.ookbee.com/Books/AmarinBooks/2020/20201026044459/Thumbnails/Cover.jpg",
                            Description = "Description D",
                            Genre = "Fantasy",
                            PublishedDate = new DateTime(2015, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rating = 5,
                            Synopsis = "Synopsis D",
                            Title = "Book B"
                        },
                        new
                        {
                            BookId = 15,
                            AuthorId = 6,
                            CoverImageUrl = "https://cdn-shop.ookbee.com/Books/AmarinBooks/2020/20201026044459/Thumbnails/Cover.jpg",
                            Description = "Description A",
                            Genre = "Fiction",
                            PublishedDate = new DateTime(2002, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rating = 3,
                            Synopsis = "Synopsis C",
                            Title = "Book A"
                        },
                        new
                        {
                            BookId = 16,
                            AuthorId = 8,
                            CoverImageUrl = "https://cdn-shop.ookbee.com/Books/AmarinBooks/2020/20201026044459/Thumbnails/Cover.jpg",
                            Description = "Description B",
                            Genre = "Fiction",
                            PublishedDate = new DateTime(2009, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rating = 3,
                            Synopsis = "Synopsis E",
                            Title = "Book B"
                        },
                        new
                        {
                            BookId = 17,
                            AuthorId = 20,
                            CoverImageUrl = "https://cdn-shop.ookbee.com/Books/AmarinBooks/2020/20201026044459/Thumbnails/Cover.jpg",
                            Description = "Description D",
                            Genre = "Fiction",
                            PublishedDate = new DateTime(2009, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rating = 2,
                            Synopsis = "Synopsis D",
                            Title = "Book D"
                        },
                        new
                        {
                            BookId = 18,
                            AuthorId = 16,
                            CoverImageUrl = "https://cdn-shop.ookbee.com/Books/AmarinBooks/2020/20201026044459/Thumbnails/Cover.jpg",
                            Description = "Description D",
                            Genre = "Mystery",
                            PublishedDate = new DateTime(2000, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rating = 5,
                            Synopsis = "Synopsis E",
                            Title = "Book B"
                        },
                        new
                        {
                            BookId = 19,
                            AuthorId = 11,
                            CoverImageUrl = "https://cdn-shop.ookbee.com/Books/AmarinBooks/2020/20201026044459/Thumbnails/Cover.jpg",
                            Description = "Description B",
                            Genre = "Science Fiction",
                            PublishedDate = new DateTime(2019, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rating = 4,
                            Synopsis = "Synopsis B",
                            Title = "Book A"
                        },
                        new
                        {
                            BookId = 20,
                            AuthorId = 7,
                            CoverImageUrl = "https://cdn-shop.ookbee.com/Books/AmarinBooks/2020/20201026044459/Thumbnails/Cover.jpg",
                            Description = "Description E",
                            Genre = "Science Fiction",
                            PublishedDate = new DateTime(2012, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rating = 1,
                            Synopsis = "Synopsis D",
                            Title = "Book C"
                        });
                });

            modelBuilder.Entity("graphql_library_management.Models.Book", b =>
                {
                    b.HasOne("graphql_library_management.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("graphql_library_management.Models.Author", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
