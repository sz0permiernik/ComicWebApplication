using System.ComponentModel.DataAnnotations;

namespace ComicWebApplication.Models
{
    public class Comic
    {
        [Key]
        public int ComicID { get; set; }
        public string Title { get; set; }
        public int? Number { get; set; }
        public string? Description { get; set; }
        public int? ReleaseYear { get; set; }
        public string? ImageURL { get; set; }
        public ICollection<CharacterComic>? CharacterComics { get; set; }
        public ICollection<ComicMovie>? ComicMovies { get; set; }
        public ICollection<ComicWorld>? ComicWorlds { get; set; }
        public ICollection<ComicReview> Reviews { get; set; }
    }
}
