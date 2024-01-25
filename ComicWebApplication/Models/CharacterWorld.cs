using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ComicWebApplication.Models
{
    public class CharacterWorld
    {
        [Key]
        public int CharacterWorldID { get; set; }
        [ForeignKey("Character")]
        public int? CharacterID { get; set; }
        public Character? Character { get; set; }
        [ForeignKey("World")]
        public int? WorldID { get; set; }
        public World? World { get; set; }
    }
}
