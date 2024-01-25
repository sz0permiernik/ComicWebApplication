using ComicWebApplication.Models;

namespace ComicWebApplication.Interfaces
{
    public interface IWorldRepository
    {
        IEnumerable<World> GetAllWorlds();
        World GetWorldById(int worldId);
        bool Add(World world);
        bool Update(World world);
        bool Delete(World world);
        bool Save();
    }
}
