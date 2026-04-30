using System.Collections.Generic;

namespace LibrarySystem.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigation property for Many-to-Many
        public virtual ICollection<Book> Books { get; set; } = new List<Book>();
    }
}