using ComicWebApplication.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ComicWebApplication.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Achievement> Achievements { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Comic> Comics { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<CharacterReview> CharacterReviews { get; set; }
        public DbSet<ComicReview> ComicReviews { get; set; }
        public DbSet<MovieReview> MovieReviews { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<World> Worlds { get; set; }
        public DbSet<CharacterComic> CharacterComics { get; set; }
        public DbSet<CharacterMovie> CharacterMovies { get; set; }
        public DbSet<CharacterWorld> CharacterWorlds { get; set; }
        public DbSet<ComicMovie> ComicMovies { get; set; }
        public DbSet<ComicWorld> ComicWorlds { get; set; }
        public DbSet<MovieWorld> MovieWorlds { get; set; }
        //public DbSet<WishList> WishLists { get; set; }
        //public DbSet<WishListType> WishListsType { get; set; }
    }
}
