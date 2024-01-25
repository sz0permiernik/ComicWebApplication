using System.ComponentModel.DataAnnotations;

namespace ComicWebApplication.Models
{
    public class Movie
    {
        [Key]
        public int MovieID { get; set; }
        public string Title { get; set; }
        public string? Director { get; set; }
        public string? Description { get; set; }
        public int? ReleaseYear { get; set; }
        public string? ImageURL { get; set; }
        public ICollection<CharacterMovie>? CharacterMovies { get; set; }
        public ICollection<ComicMovie>? ComicMovies { get; set; }
        public ICollection<MovieWorld>? MovieWordls { get; set; }
        public ICollection<MovieReview> Reviews { get; set; }
    }
}
