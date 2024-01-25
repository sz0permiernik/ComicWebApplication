using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComicWebApplication.Models
{
    public class Achievement
    {
        [Key]
        public int AchievementID { get; set; }
        [ForeignKey("User")]
        public int? UserID { get; set; }
        public User? User { get; set; }
        public string? AchievementName { get; set;}
    }
}
