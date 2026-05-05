using LibrarySystem.Models;
using Microsoft.EntityFrameworkCore;

public class BookRepository
{
    private readonly LibraryContext _context = new LibraryContext();

    // Part 1.2: Eager Loading implementation
    public async Task<List<Book>> GetAllBooksAsync()
    {
        // By creating a new context here, it forces EF Core to pull fresh data from SQL!
        using (var context = new LibraryContext())
        {
            return await context.Books
                .Include(b => b.Authors)
                .ToListAsync();
        }
    }

    public async Task<List<Book>> SearchBooksAsync(string term)
    {
        using (var context = new LibraryContext())
        {
            return await context.Books
                .Include(b => b.Authors)
                .Where(b => b.Title.Contains(term) || b.Isbn.Contains(term))
                .ToListAsync();
        }
    }

    public async Task<List<Book>> GetBooksByAuthorAsync(int authorId)
    {
        using (var context = new LibraryContext())
        {
            // Part 1.2: Eager Loading using .Include
            return await context.Books
                .Include(b => b.Authors)
                .Where(b => b.Authors.Any(a => a.Id == authorId))
                .ToListAsync();
        }
    }
}