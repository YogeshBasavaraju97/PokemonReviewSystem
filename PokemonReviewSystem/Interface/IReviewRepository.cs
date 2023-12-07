using System;
using PokemonReviewSystem.Models;

namespace PokemonReviewSystem.Interface
{
	public interface IReviewRepository
	{
        ICollection<Review> GetReviews();
        Review GetReview(int reviewId);
        ICollection<Review> GetReviewsOfAPokemon(int pokeId);
        bool ReviewExists(int reviewId);
    }
}

