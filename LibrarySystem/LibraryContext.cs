using LibrarySystem.Models;
using Microsoft.EntityFrameworkCore;

public class LibraryContext : DbContext
{
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=LibraryDB;Trusted_Connection=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Part 1.1: Fluent API Many-to-Many
        modelBuilder.Entity<Book>()
            .HasMany(b => b.Authors)
            .WithMany(a => a.Books);

        // Part 1.3: Concurrency Token
        modelBuilder.Entity<Book>()
            .Property(b => b.RowVersion)
            .IsRowVersion();

        // Unique Constraint
        modelBuilder.Entity<Book>()
            .HasIndex(b => b.Isbn)
            .IsUnique();
    }
}