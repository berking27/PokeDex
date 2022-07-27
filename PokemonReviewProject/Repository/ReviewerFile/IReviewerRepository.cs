using System;
using PokemonReviewProject.Models;
namespace PokemonReviewProject.Repository.ReviewerFile

{
    public interface IReviewerRepository
    {
        ICollection<Reviewer> GetReviwers();

        Reviewer GetReviewer(int reviewerId);

        ICollection<Review> GetReviewsByReviewer(int reviewerId);

        bool ReviewerExists(int reviwerId);
    }
}

