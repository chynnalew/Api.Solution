using Microsoft.EntityFrameworkCore;

namespace BookAPI.Models
{
  public class BookAPIContext : DbContext
  {
    public BookAPIContext(DbContextOptions<BookAPIContext> options) : base(options) {}

    public DbSet<Book> Books { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Book>().HasData(
        new Book { BookId = 1, Title = "Harry Potter", Author = "J. K. Rowling", Genre = "Fantasy", Rating = 8, Read = true},
        new Book { BookId = 2, Title = "The Silent Patient", Author = "Alex Michaelides", Genre = "Thriller", Rating = 5, Read = false},
        new Book { BookId = 3, Title = "Do Androids Dream of Electric Sheep", Author = "Philip K. Dick", Genre = "Sci-Fi", Rating = 8, Read = true},
        new Book { BookId = 4, Title = "Silent Spring", Author = "Rachel Carson", Genre = "Non-Fiction", Rating = 8, Read = true}
      );
    }
  }
}
