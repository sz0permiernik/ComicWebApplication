using ComicWebApplication.Models;
using System.ComponentModel.DataAnnotations;

namespace ComicWebApplication.CreateViewModels
{
    public class CreateMovieViewModel
    {
        public int MovieID { get; set; }
        [Required(ErrorMessage = "Tytuł filmu jest wymagany.")]
        public string Title { get; set; }
        public string? Director { get; set; }
        public string? Description { get; set; }
        public int? ReleaseYear { get; set; }
        [Required(ErrorMessage = "Okładka filmu jest wymagana.")]
        public IFormFile? ImageURL { get; set; }
        public ICollection<CharacterMovie>? CharacterMovies { get; set; }
        public ICollection<ComicMovie>? ComicMovies { get; set; }
        public ICollection<MovieWorld>? MovieWordls { get; set; }
    }
}
