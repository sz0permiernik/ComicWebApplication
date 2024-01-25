using ComicWebApplication.Data;
using ComicWebApplication.Interfaces;
using ComicWebApplication.Models;

namespace ComicWebApplication.Repository
{
    public class WorldRepository : IWorldRepository
    {
        private readonly ApplicationDbContext _context;
        public WorldRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(World world)
        {
            _context.Add(world);
            return Save();
        }

        public bool Delete(World world)
        {
            _context.Remove(world);
            return Save();
        }

        public IEnumerable<World> GetAllWorlds()
        {
            return _context.Worlds.ToList();
        }

        public World GetWorldById(int worldId)
        {
            return _context.Worlds.Find(worldId);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(World world)
        {
            _context.Update(world);
            return Save();
        }
    }
}
