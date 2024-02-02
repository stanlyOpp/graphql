namespace graphql_library_management.Models;
using Microsoft.EntityFrameworkCore;

public class BookDbContext : DbContext
{
    public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
    {
    }

    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>().HasData(
            GenerateAuthors(20)
        );
        modelBuilder.Entity<Book>().HasData(
            GenerateBooks(20)
        );
    }

    private List<Author> GenerateAuthors(int count)
    {
        var authors = new List<Author>();
        var random = new Random();

        for (int i = 1; i <= count; i++)
        {
            var author = new Author
            {
                Id = i,
                Name = GetRandomName(random),
                Biography = GetRandomBiography(random),
                BirthDate = GetRandomBirthDate(random),
                Books = new List<Book>()
            };

            authors.Add(author);
        }

        return authors;
    }

    private string GetRandomName(Random random)
    {
        // You can implement your own logic to generate random names.
        // For simplicity, let's assume you have a list of predefined names.
        var names = new List<string> { "John Doe", "Jane Smith", "Alice Johnson", "Bob Brown", "Eve Wilson" };
        return names[random.Next(names.Count)];
    }

    private string GetRandomBiography(Random random)
    {
        // You can implement your own logic to generate random biographies.
        // For simplicity, let's assume you have a list of predefined biographies.
        var biographies = new List<string>
        {
            "Biography of John Doe",
            "Biography of Jane Smith",
            "Biography of Alice Johnson",
            "Biography of Bob Brown",
            "Biography of Eve Wilson"
        };
        return biographies[random.Next(biographies.Count)];
    }

    private DateTime GetRandomBirthDate(Random random)
    {
        // You can implement your own logic to generate random birthdates.
        // For simplicity, let's assume a range of birthdates between 1970 and 2000.
        var startDate = new DateTime(1970, 1, 1);
        var endDate = new DateTime(2000, 12, 31);
        var range = (endDate - startDate).Days;
        return startDate.AddDays(random.Next(range));
    }

    private List<Book> GenerateBooks(int count)
    {
        var books = new List<Book>();
        var random = new Random();
        var imageUrlPrefix = "https://cdn-shop.ookbee.com/Books/AmarinBooks/2020/20201026044459/Thumbnails/Cover.jpg";

        for (int i = 1; i <= count; i++)
        {
            var book = new Book
            {
                BookId = i,
                Title = GetRandomTitle(random),
                Genre = GetRandomGenre(random),
                PublishedDate = GetRandomPublishedDate(random),
                AuthorId = random.Next(1, 21), // AuthorId between 1 and 20
                Synopsis = GetRandomSynopsis(random),
                CoverImageUrl = imageUrlPrefix, // Assuming you have public image URLs
                Rating = random.Next(1, 6), // Random rating between 1 and 5
                Description = GetRandomDescription(random)
            };

            books.Add(book);
        }

        return books;
    }

    private string GetRandomTitle(Random random)
    {
        // You can implement your own logic to generate random titles.
        // For simplicity, let's assume you have a list of predefined titles.
        var titles = new List<string> { "Book A", "Book B", "Book C", "Book D", "Book E" };
        return titles[random.Next(titles.Count)];
    }

    private string GetRandomGenre(Random random)
    {
        // You can implement your own logic to generate random genres.
        // For simplicity, let's assume you have a list of predefined genres.
        var genres = new List<string> { "Fiction", "Mystery", "Science Fiction", "Romance", "Fantasy" };
        return genres[random.Next(genres.Count)];
    }

    private DateTime GetRandomPublishedDate(Random random)
    {
        // You can implement your own logic to generate random published dates.
        // For simplicity, let's assume a range of published dates between 2000 and 2022.
        var startDate = new DateTime(2000, 1, 1);
        var endDate = new DateTime(2022, 12, 31);
        var range = (endDate - startDate).Days;
        return startDate.AddDays(random.Next(range));
    }

    private string GetRandomSynopsis(Random random)
    {
        // You can implement your own logic to generate random synopses.
        // For simplicity, let's assume you have a list of predefined synopses.
        var synopses = new List<string>
        {
            "Synopsis A",
            "Synopsis B",
            "Synopsis C",
            "Synopsis D",
            "Synopsis E"
        };
        return synopses[random.Next(synopses.Count)];
    }

    private string GetRandomDescription(Random random)
    {
        // You can implement your own logic to generate random descriptions.
        // For simplicity, let's assume you have a list of predefined descriptions.
        var descriptions = new List<string>
        {
            "Description A",
            "Description B",
            "Description C",
            "Description D",
            "Description E"
        };
        return descriptions[random.Next(descriptions.Count)];
    }
}