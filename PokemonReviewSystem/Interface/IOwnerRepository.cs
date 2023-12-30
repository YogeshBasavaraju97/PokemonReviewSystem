using System;
using PokemonReviewSystem.Models;

namespace PokemonReviewSystem.Interface
{
	public interface IOwnerRepository
	{
		ICollection<Owner> GetOwners();

		Owner GetOwner(int ownerId);

		ICollection<Owner> GetOwnerOfAPokemon(int pokeId);

		ICollection<Pokemon> GetPokemonByOwnerId(int ownerId);

		bool OwnerExists(int ownerId);

        bool CreateOwner(Owner owner);
    }
}

