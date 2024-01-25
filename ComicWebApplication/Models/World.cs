using System.ComponentModel.DataAnnotations;

namespace ComicWebApplication.Models
{
    public class World
    {
        [Key]
        public int WorldID { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? ImageURL { get; set; }
        public ICollection<CharacterWorld>? CharacterWorlds { get; set; }
        public ICollection<ComicWorld>? ComicWorlds { get; set; }
        public ICollection<MovieWorld>? MovieWorlds { get; set; }
    }
}
