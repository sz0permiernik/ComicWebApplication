using ComicWebApplication.Models;
using System.ComponentModel.DataAnnotations;

namespace ComicWebApplication.CreateViewModels
{
    public class CreateCharacterViewModel
    {
        public int CharacterID { get; set; }
        [Required(ErrorMessage = "Nazwa postaci jest wymagana.")]
        public string Name { get; set; }
        public string? Superpower { get; set; }
        public string? Description { get; set; }
        [Required(ErrorMessage = "Zdjęcie postaci jest wymagane.")]
        public IFormFile? ImageURL { get; set; }
        public ICollection<CharacterComic>? CharacterComics { get; set; }
        public ICollection<CharacterMovie>? CharacterMovies { get; set; }
        public ICollection<CharacterWorld>? CharacterWorlds { get; set; }
        public ICollection<CharacterReview>? Reviews { get; set; }
    }
}
