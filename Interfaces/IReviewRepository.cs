using PokemonReview.Models;

namespace PokemonReview.Interfaces
{
    public interface IReviewRepository
    {
        ICollection<Review> GetReviews();
        Review GetReview(int reviewId);
        ICollection<Review> GetReviewsOfAPokemon(int pokemonId);
        bool ReviewExists(int reviewId);
        bool CreateReview(Review review);
        bool UpdateReview(Review review);
        bool DeleteReviews(ICollection<Review> reviews);
        bool DeleteReview(Review review);
        bool Save();
    }
}