using System.ComponentModel.DataAnnotations;

namespace ComicWebApplication.Models
{
    public class Character
    {
        [Key]
        public int CharacterID { get; set; }
        public string Name { get; set; }
        public string? Superpower { get; set; }
        public string? Description { get; set; }
        public string? ImageURL { get; set; }
        public ICollection<CharacterComic>? CharacterComics { get; set; }
        public ICollection<CharacterMovie>? CharacterMovies { get; set; }
        public ICollection<CharacterWorld>? CharacterWorlds { get; set; }
    }
}
