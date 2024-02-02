using graphql_library_management.Models;
using Microsoft.EntityFrameworkCore;

namespace graphql_library_management.GraphQL;
public class Query
{
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Book> GetBooks([Service] BookDbContext context)
    {
        return context.Books.Include(e => e.Author);
    }

    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Author> GetAuthors([Service] BookDbContext context)
    {
        return context.Authors.Include(e => e.Books);
    }

    [UsePaging(MaxPageSize = 10)]
    [UseSorting]
    [UseFiltering]
    public IQueryable<Book> GetBooksPagination([Service] BookDbContext context)
    {
        return context.Books.Include(e => e.Author);
    }
}
