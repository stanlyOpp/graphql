using graphql_library_management.Models;

namespace graphql_library_management.GraphQL;

public class Mutation
{
    public async Task<Book> AddBook(RequestBook bookRequest, [Service] BookDbContext context)
    {
        Book book = new()
        {
            Genre = "",
            Synopsis = "",
            Title = bookRequest.Title,
            PublishedDate = DateTime.UtcNow,
            AuthorId = bookRequest.AuthorId,
            CoverImageUrl = bookRequest.CoverImageUrl,
            Rating = bookRequest.Rating,
            Description = bookRequest.Description
        };
        context.Books.Add(book);
        await context.SaveChangesAsync();
        return book;
    }

    public async Task<Book> UpdateBook(int id, RequestBook bookRequest, [Service] BookDbContext context)
    {
        var existingBook = context.Books.Find(id);
        if (existingBook == null) return null;

        existingBook.Title = bookRequest.Title;
        existingBook.Description = bookRequest.Description;
        existingBook.Rating = bookRequest.Rating;
        existingBook.AuthorId = bookRequest.AuthorId;
        existingBook.CoverImageUrl = bookRequest.CoverImageUrl;

        context.Books.Update(existingBook);
        await context.SaveChangesAsync();
        return existingBook;
    }

    public async Task<bool> DeleteBook(int id, [Service] BookDbContext context)
    {
        var book = context.Books.Find(id);
        if (book == null) return false;

        context.Books.Remove(book);
        await context.SaveChangesAsync();
        return true;
    }
}
