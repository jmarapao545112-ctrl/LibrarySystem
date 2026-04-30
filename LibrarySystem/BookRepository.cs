using LibrarySystem;
using LibrarySystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class BookRepository
{
    private readonly LibraryContext _context = new LibraryContext();

    // Part 1.2: Eager Loading implementation
    public async Task<List<Book>> GetAllBooksAsync()
    {
        return await _context.Books
            .Include(b => b.Authors) // This is "Eager Loading"
            .ToListAsync();
    }

    public async Task<List<Book>> SearchBooksAsync(string term)
    {
        return await _context.Books
            .Include(b => b.Authors)
            .Where(b => b.Title.Contains(term) || b.Isbn.Contains(term))
            .ToListAsync();
    }
}