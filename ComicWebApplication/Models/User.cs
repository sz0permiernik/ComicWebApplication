using System.ComponentModel.DataAnnotations;

namespace ComicWebApplication.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        //public ICollection<Achievement> Achievements { get; set; }
        //public ICollection<CharacterReview> CharacterReviews { get; set; }
        //public ICollection<ComicReview> ComicReviews { get; set; }
        //public ICollection<MovieReview> MovieReviews { get; set; }
        //public ICollection<WishList> WishLists { get; set; }
    }
}
