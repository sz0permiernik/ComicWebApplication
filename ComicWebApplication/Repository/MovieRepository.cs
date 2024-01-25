using ComicWebApplication.Data;
using ComicWebApplication.Interfaces;
using ComicWebApplication.Models;

namespace ComicWebApplication.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private readonly ApplicationDbContext _context;
        public MovieRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Movie movie)
        {
            _context.Add(movie);
            return Save();
        }

        public bool Delete(Movie movie)
        {
            _context.Remove(movie);
            return Save();
        }
        public IEnumerable<Movie> GetAllMovies()
        {
            return _context.Movies.ToList();
        }

        public Movie GetMovieById(int movieId)
        {
            return _context.Movies.Find(movieId);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Movie movie)
        {
            _context.Update(movie);
            return Save();
        }
    }
}
