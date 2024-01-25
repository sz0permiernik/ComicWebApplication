using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComicWebApplication.Models
{
    public class CharacterMovie
    {
        [Key]
        public int CharacterMovieID { get; set; }
        [ForeignKey("Character")]
        public int? CharacterID { get; set; }
        public Character? Character {  get; set; }
        [ForeignKey("Movie")]
        public int? MovieID { get; set; }
        public Movie? Movie { get; set; }
    }
}
