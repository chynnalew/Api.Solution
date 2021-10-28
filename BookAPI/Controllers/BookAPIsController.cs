using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookAPI.Models;

namespace BookAPI.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class BookAPIsController : ControllerBase
  {
    private readonly BookAPIContext _db;

    public BookAPIsController(BookAPIContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Book>>> Get(string title, string author, string genre, int rating)
    {
      var query = _db.Books.AsQueryable();

      if(title != null)
      {
        query = query.Where(e => e.Title.ToLower() == title.ToLower());
      }

      if(author != null)
      {
        query = query.Where(e => e.Author.ToLower() == author.ToLower());
      }

      if(genre != null)
      {
        query = query.Where(e => e.Genre.ToLower() == genre.ToLower());
      }

      if(rating > 0)
      {
        query = query.Where(e => e.Rating == rating);
      }

      return await query.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Book>> GetBook(int id)
    {
      var book = await _db.Books.FindAsync(id);

      if (book == null)
      {
        return NotFound();
      }
      return book;
    }
    
    [HttpPut("{id}")]
    public async Task<ActionResult> Put(int id, Book book)
    {
      if(id != book.BookId)
      {
        return BadRequest();
      }
      _db.Entry(book).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch(DbUpdateConcurrencyException)
      {
        if(!BookExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }
      return NoContent();
    }

    [HttpPost]
    public async Task<ActionResult<Book>> Post(Book book)
    {
      _db.Books.Add(book);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetBook), new { id = book.BookId }, book);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteBook(int id)
    {
      var book = await _db.Books.FindAsync(id);
      if(book == null)
      {
        return NotFound();
      }

      _db.Books.Remove(book);
      await _db.SaveChangesAsync();
      return NoContent();
    }
  
    [ApiExplorerSettings(IgnoreApi = true)]
    private bool BookExists(int id)
    {
      return _db.Books.Any(e => e.BookId == id);
    }
  }
}
