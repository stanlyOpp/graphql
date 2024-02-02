namespace graphql_library_management.Models;

public class RequestBook
{
    public string Title { get; set; }
    public int AuthorId { get; set; }
    public string CoverImageUrl { get; set; }
    public int Rating { get; set; }
    public string Description { get; set; }
}