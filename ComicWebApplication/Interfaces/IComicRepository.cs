using ComicWebApplication.Models;

namespace ComicWebApplication.Interfaces
{
    public interface IComicRepository
    {
        IEnumerable<Comic> GetAllComics();
        Comic GetComicById(int comicId);
        bool Add(Comic comic);
        bool Update(Comic comic);
        bool Delete(Comic comic);
        bool Save();
    }
}
