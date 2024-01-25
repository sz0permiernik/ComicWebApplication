using ComicWebApplication.Models;
using System.ComponentModel.DataAnnotations;

namespace ComicWebApplication.CreateViewModels
{
    public class CreateComicViewModel
    {
        public int ComicID { get; set; }
        [Required(ErrorMessage = "Tytuł komiksu jest wymagany.")]
        public string Title { get; set; }
        public int? Number { get; set; }
        public string? Description { get; set; }
        public int? ReleaseYear { get; set; }
        [Required(ErrorMessage = "Okładka komiksu jest wymagane.")]
        public IFormFile? ImageURL { get; set; }
        public ICollection<CharacterComic>? CharacterComics { get; set; }
        public ICollection<ComicMovie>? ComicMovies { get; set; }
        public ICollection<ComicWorld>? ComicWorlds { get; set; }
    }
}
