using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookstore.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }

        [Display(Name = "Author")]
        public int AuthorId { get; set; }

        // Navigation property
        [ForeignKey("AuthorId")]
        public Author Author { get; set; }
    }
} 