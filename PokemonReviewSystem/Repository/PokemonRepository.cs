using System;
using PokemonReviewSystem.Data;
using PokemonReviewSystem.Interface;
using PokemonReviewSystem.Models;

namespace PokemonReviewSystem.Repository
{
	public class PokemonRepository: IPokemonRepository
	{
        private readonly DataContext _context;

        public PokemonRepository(DataContext context)
		{
            this._context = context;
        }


        public ICollection<Pokemon> GetPokemons()
        {
            return _context.Pokemon.OrderBy(p => p.Id).ToList();
        }
	}
}

