using Microsoft.EntityFrameworkCore;

namespace BookAPI.Models
{
  public class BookAPIContext : DbContext
  {
    public BookAPIContext(DbContextOptions<BookAPIContext> options) : base(options) {}

    public DbSet<Book> Books { get; set; }
  }
}
