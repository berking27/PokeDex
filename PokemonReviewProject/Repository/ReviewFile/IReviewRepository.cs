using System;
using PokemonReviewProject.Models;

namespace PokemonReviewProject.Repository.ReviewFile
{
    public interface IReviewRepository
    {
        ICollection<Review> GetReviews();

        Review GetReview(int reviewId);

        ICollection<Review> GetReviewsOfAPokemon(int pokeId);

        bool ReviewExists(int reviewId);

        bool CreateReview(int reviewerId,int pokeId ,Review review);

        bool Save();
    }
}

