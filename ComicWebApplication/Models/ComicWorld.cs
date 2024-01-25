using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ComicWebApplication.Models
{
    public class ComicWorld
    {
        [Key]
        public int ComicWorldID { get; set; }
        [ForeignKey("Comic")]
        public int? ComicID { get; set; }
        public Comic? Comic { get; set; }
        [ForeignKey("World")]
        public int? WorldID { get; set; }
        public World? World { get; set; }
    }
}
