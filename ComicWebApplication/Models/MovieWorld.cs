using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ComicWebApplication.Models
{
    public class MovieWorld
    {
        [Key]
        public int MovieWorldID { get; set; }
        [ForeignKey("Movie")]
        public int? MovieID { get; set; }
        public Movie? Movie { get; set; }
        [ForeignKey("World")]
        public int? WorldID { get; set; }
        public World? World { get; set; }
    }
}
