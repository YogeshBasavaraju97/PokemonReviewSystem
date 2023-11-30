using System;
using PokemonReviewSystem.Models;

namespace PokemonReviewSystem.Interface
{
	public interface IPokemonRepository
	{
		ICollection<Pokemon> GetPokemons();
	}
}

