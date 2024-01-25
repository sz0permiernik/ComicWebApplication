using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ComicWebApplication.Models
{
    public class ComicReview
    {
        [Key]
        public int ReviewID { get; set; }
        [ForeignKey("User")]
        public int? UserID { get; set; }
        public User? User { get; set; }
        [ForeignKey("Comic")]
        public int? ComicID { get; set; }
        public Comic? Comic { get; set; }
        public int? Rating { get; set; }
        public string? Comment { get; set; }
        public DateTime? ReviewDate { get; set; }
    }
}
