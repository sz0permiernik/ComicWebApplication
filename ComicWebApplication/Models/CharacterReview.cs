using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComicWebApplication.Models
{
    public class CharacterReview
    {
        [Key]
        public int ReviewID { get; set; }
        [ForeignKey("User")]
        public int? UserID { get; set; }
        public User? User { get; set; }
        [ForeignKey("Character")]
        public int? CharacterID { get; set; }
        public Character? Character { get; set; }
        public int? Rating { get; set; }
        public string? Comment { get; set; }
        public DateTime? ReviewDate { get; set; }
    }
}
