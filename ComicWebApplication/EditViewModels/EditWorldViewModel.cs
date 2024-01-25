using ComicWebApplication.Models;
using System.ComponentModel.DataAnnotations;

namespace ComicWebApplication.EditViewModels
{
    public class EditWorldViewModel
    {
        public int WorldID { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        [Required(ErrorMessage = "Zdjęcie świata jest wymagane.")]
        public IFormFile? ImageURL { get; set; }
        public string? URL { get; set; }
        public ICollection<CharacterWorld>? CharacterWorlds { get; set; }
        public ICollection<ComicWorld>? ComicWorlds { get; set; }
        public ICollection<MovieWorld>? MovieWorlds { get; set; }
    }
}
