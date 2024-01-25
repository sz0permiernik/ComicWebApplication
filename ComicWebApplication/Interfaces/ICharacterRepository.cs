using ComicWebApplication.Models;

namespace ComicWebApplication.Interfaces
{
    public interface ICharacterRepository
    {
        IEnumerable<Character> GetAllCharacters();
        Character GetCharacterById(int characterId);
        bool Add(Character character);
        bool Update(Character character);
        bool Delete(Character character);
        bool Save();
    }
}
