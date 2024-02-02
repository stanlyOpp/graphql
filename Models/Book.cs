namespace graphql_library_management.Models;
public class Book
{
    public int BookId { get; set; }
    public string Title { get; set; }
    public string Genre { get; set; }
    public DateTime PublishedDate { get; set; }
    public int AuthorId { get; set; }
    public string Synopsis { get; set; }
    public string CoverImageUrl { get; set; }
    public Author Author { get; set; }
    public int Rating { get; set; }
    public string Description { get; set; }
}
