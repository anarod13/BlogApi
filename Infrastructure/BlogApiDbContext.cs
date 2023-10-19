using Microsoft.EntityFrameworkCore;
using BlogApi.Models;

namespace BlogApi.Infrastructure;

public class BlogApiDbContext : DbContext
{
    public BlogApiDbContext(DbContextOptions<BlogApiDbContext> options)
        : base(options) { }

    public DbSet<Note> Notes { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Section> Sections { get; set; }
}
