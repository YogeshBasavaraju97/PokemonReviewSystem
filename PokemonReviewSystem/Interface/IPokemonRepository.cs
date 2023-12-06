using System;
using PokemonReviewSystem.Models;

namespace PokemonReviewSystem.Interface
{
	public interface IPokemonRepository
	{
		ICollection<Pokemon> GetPokemons();

		Pokemon GetPokemon(int id);

		Pokemon GetPokemon(string name);

		decimal GetPokemonReating(int pokeId);

		bool pokemonExists(int pokeId);


	}
}

