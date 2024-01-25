using ComicWebApplication.Data;
using ComicWebApplication.Interfaces;
using ComicWebApplication.Models;

namespace ComicWebApplication.Repository
{
    public class CharacterReviewRepository : ICharacterReviewRepository
    {
        private readonly ApplicationDbContext _context;
        public CharacterReviewRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(CharacterReview characterReview)
        {
            _context.Add(characterReview);
            return Save();
        }

        public bool Delete(CharacterReview characterReview)
        {
            _context.Remove(characterReview);
            return Save();
        }
        public IEnumerable<CharacterReview> GetAllCharacterReviews()
        {
            return _context.CharacterReviews.ToList();
        }

        public CharacterReview GetCharacterReviewById(int reviewId)
        {
            return _context.CharacterReviews.FirstOrDefault(c => c.ReviewID == reviewId);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(CharacterReview characterReview)
        {
            _context.Update(characterReview);
            return Save();
        }
    }
}
