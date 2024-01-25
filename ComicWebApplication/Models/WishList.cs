using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ComicWebApplication.Models
{
    public class WishList
    {
        [Key]
        public int ReviewID { get; set; }
        [ForeignKey("User")]
        public int? UserID { get; set; }
        public User? User { get; set; }
        //[ForeignKey("WishlistType")]
        //public int WishlistTypeID { get; set; }
        //public WishListType WishListType { get; set; }
    }
}
