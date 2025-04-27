using System.ComponentModel.DataAnnotations;
using Finals_Project_Group5.Models;

namespace Finals_Project_Group5.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        public string Description { get; set; }
    }
}
