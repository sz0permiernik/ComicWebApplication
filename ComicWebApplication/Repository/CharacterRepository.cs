using ComicWebApplication.Data;
using ComicWebApplication.Interfaces;
using ComicWebApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace ComicWebApplication.Repository
{
    public class CharacterRepository : ICharacterRepository
    {
        private readonly ApplicationDbContext _context;
        public CharacterRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Character character)
        {
            _context.Add(character);
            return Save();
        }

        public bool Delete(Character character)
        {
            _context.Remove(character);
            return Save();
        }
        public IEnumerable<Character> GetAllCharacters()
        {
            return _context.Characters.ToList();
        }

        public Character GetCharacterById(int characterId)
        {
            return _context.Characters.FirstOrDefault(c => c.CharacterID == characterId);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Character character)
        {
            _context.Update(character);
            return Save();
        }
    }
}
