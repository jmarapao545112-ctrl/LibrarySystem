using System.Collections.Generic;

namespace LibrarySystem.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Isbn { get; set; }
        public string Status { get; set; }
        public bool IsReference { get; set; }
        public int Year { get; set; }
        public int Quantity { get; set; }

        // This property is used for Part 1.3 (Concurrency)
        public byte[] RowVersion { get; set; }

        // Navigation property for Many-to-Many
        public virtual ICollection<Author> Authors { get; set; } = new List<Author>();
    }
}