using System;
namespace PokemonReviewSystem.Models
{
	public class Reviewer
	{
		public int ReviewerId { get; set; }

		public string FirstName { get; set; }

        public int Rating { get; set; }

        public string LastName { get; set; }

		public ICollection<Review> Reviews { get; set; }
	}
}

