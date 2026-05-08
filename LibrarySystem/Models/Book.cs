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

        [Timestamp] 
        public byte[] RowVersion { get; set; }

        public virtual ICollection<Author> Authors { get; set; } = new List<Author>();

        public bool IsProcessable => Status == "Available" && !IsReference && Year > 2000;
    }
}