using System;
namespace PokemonReviewSystem.Models
{
	public class Category
	{
		public int  Id { get; set; }

		public string Name { get; set; }

		public ICollection<PokemonCatgory> PokemonCatgories { get; set; }
	}
}

