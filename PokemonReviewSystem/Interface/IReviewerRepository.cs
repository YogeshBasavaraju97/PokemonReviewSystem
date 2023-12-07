using System;
using PokemonReviewSystem.Models;

namespace PokemonReviewSystem.Interface
{
	public interface IReviewerRepository
	{
        ICollection<Reviewer> GetReviewers();
        Reviewer GetReviewer(int reviewerId);
        ICollection<Review> GetReviewsByReviewer(int reviewerId);
        bool ReviewerExists(int reviewerId);

    }
}

