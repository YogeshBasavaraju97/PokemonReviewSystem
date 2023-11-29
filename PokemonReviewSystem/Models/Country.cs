using System;
namespace PokemonReviewSystem.Models
{
	public class Country
	{
		public int MyProperty { get; set; }

		public string Name { get; set; }

		public ICollection<Owner> Owners {get; set;}
	}
}

	