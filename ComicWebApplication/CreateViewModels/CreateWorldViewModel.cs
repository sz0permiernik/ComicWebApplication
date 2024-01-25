using ComicWebApplication.Models;
using System.ComponentModel.DataAnnotations;

namespace ComicWebApplication.CreateViewModels
{
    public class CreateWorldViewModel
    {
        public int WorldID { get; set; }
        [Required(ErrorMessage = "Nazwa świata jest wymagana.")]
        public string Name { get; set; }
        public string? Description { get; set; }
        [Required(ErrorMessage = "Zdjęcie świata jest wymagane.")]
        public IFormFile? ImageURL { get; set; }
        public ICollection<CharacterWorld>? CharacterWorlds { get; set; }
        public ICollection<ComicWorld>? ComicWorlds { get; set; }
        public ICollection<MovieWorld>? MovieWorlds { get; set; }
    }
}
