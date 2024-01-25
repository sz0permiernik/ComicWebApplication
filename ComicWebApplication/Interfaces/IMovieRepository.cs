using ComicWebApplication.Models;

namespace ComicWebApplication.Interfaces
{
    public interface IMovieRepository
    {
        IEnumerable<Movie> GetAllMovies();
        Movie GetMovieById(int movieId);
        bool Add(Movie movie);
        bool Update(Movie movie);
        bool Delete(Movie movie);
        bool Save();
    }
}
