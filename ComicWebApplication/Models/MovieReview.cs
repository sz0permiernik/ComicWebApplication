using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ComicWebApplication.Models
{
    public class MovieReview
    {
        [Key]
        public int ReviewID { get; set; }
        [ForeignKey("User")]
        public int? UserID { get; set; }
        public User? User { get; set; }
        [ForeignKey("Movie")]
        public int? MovieID { get; set; }
        public Movie? Movie { get; set; }
        public int? Rating { get; set; }
        public string? Comment { get; set; }
        public DateTime? ReviewDate { get; set; }
    }
}
