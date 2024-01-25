using ComicWebApplication.Models;
using System.ComponentModel.DataAnnotations;

namespace ComicWebApplication.EditViewModels
{
    public class EditMovieViewModel
    {
        public int MovieID { get; set; }
        public string Title { get; set; }
        public string? Director { get; set; }
        public string? Description { get; set; }
        public int? ReleaseYear { get; set; }
        [Required(ErrorMessage = "Zdjęcie okładki jest wymagane.")]
        public IFormFile? ImageURL { get; set; }
        public string? URL { get; set; }
        public ICollection<CharacterMovie>? CharacterMovies { get; set; }
        public ICollection<ComicMovie>? ComicMovies { get; set; }
        public ICollection<MovieWorld>? MovieWordls { get; set; }
    }
}
