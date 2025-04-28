using System;

namespace OOPFinalsProject.Models
{
    public class Book
    {
        public int BookId { get; set; }  // Primary Key
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublishedDate { get; set; }
    }
}
