using System.ComponentModel.DataAnnotations;

namespace BookAPI.Models
{
  public class Book
  {
    public int BookId {get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public int Rating { get; set; }
    public bool Read { get; set; }
  }
}