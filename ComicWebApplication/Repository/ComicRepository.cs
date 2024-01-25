using ComicWebApplication.Data;
using ComicWebApplication.Interfaces;
using ComicWebApplication.Models;

namespace ComicWebApplication.Repository
{
    public class ComicRepository : IComicRepository
    {
        private readonly ApplicationDbContext _context;
        public ComicRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Comic comic)
        {
            _context.Add(comic);
            return Save();
        }

        public bool Delete(Comic comic)
        {
            _context.Remove(comic);
            return Save();
        }

        public IEnumerable<Comic> GetAllComics()
        {
            return _context.Comics.ToList();
        }
        public Comic GetComicById(int comicId)
        {
            return _context.Comics.Find(comicId);
        }
        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Comic comic)
        {
            _context.Update(comic);
            return Save();
        }
    }
}
