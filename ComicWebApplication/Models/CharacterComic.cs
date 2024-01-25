using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComicWebApplication.Models
{
    public class CharacterComic
    {
        [Key]
        public int CharacterComicID { get; set; }
        [ForeignKey("Character")]
        public int? CharacterID { get; set; }
        public Character? Character { get; set; }
        [ForeignKey("Comic")]
        public int? ComicID { get; set; }
        public Comic? Comic { get; set; }

    }
}
