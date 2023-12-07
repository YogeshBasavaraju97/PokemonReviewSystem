using System;
namespace PokemonReviewSystem.Dto
{
	public class ReviewerDto
	{
        public int ReviewerId { get; set; }

        public string? FirstName { get; set; }

        public int Rating { get; set; }

        public string? LastName { get; set; }
    }
}

