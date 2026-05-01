using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibrarySystem.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Isbn { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }
        public bool IsReference { get; set; }
        public int Year { get; set; }

        [Timestamp] // Part 1.3: Concurrency Token
        public byte[] RowVersion { get; set; }

        public virtual ICollection<Author> Authors { get; set; } = new List<Author>();

        // Part 4.2: Refactoring Challenge - Descriptive property
        public bool IsProcessable => Status == "Available" && !IsReference && Year > 2000;
    }
}