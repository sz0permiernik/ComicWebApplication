using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ComicWebApplication.Models
{
    public class ComicMovie
    {
        [Key]
        public int ComicMovieID { get; set; }
        [ForeignKey("Comic")]
        public int? ComicID { get; set; }
        public Comic? Comic { get; set; }
        [ForeignKey("Movie")]
        public int? MovieID { get; set; }
        public Movie? Movie { get; set; }
    }
}
