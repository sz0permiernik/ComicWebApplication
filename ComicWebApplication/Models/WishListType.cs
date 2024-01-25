using System.ComponentModel.DataAnnotations;

namespace ComicWebApplication.Models
{
    public class WishListType
    {
        [Key]
        public int WishlistTypeID { get; set; }
        public string? TypeName { get; set; }
        //public ICollection<WishList> WishLists { get; set; }
    }
}
