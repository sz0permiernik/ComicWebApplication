using ComicWebApplication.Models;

namespace ComicWebApplication.Interfaces
{
    public interface ICharacterReviewRepository
    {
        IEnumerable<CharacterReview> GetAllCharacterReviews();
        CharacterReview GetCharacterReviewById(int reviewId);
        bool Add(CharacterReview characterReview);
        bool Update(CharacterReview characterReview);
        bool Delete(CharacterReview characterReview);
        bool Save();
    }
}
