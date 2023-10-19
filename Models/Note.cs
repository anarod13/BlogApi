namespace BlogApi.Models;

public class Note
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }

    public int AuthorId { get; set; }
    public Author Author { get; set; }
    public List<Section> Sections { get; set; }
    public List<string> Tags { get; set; }
    public bool IsPublished { get; set; }
}

