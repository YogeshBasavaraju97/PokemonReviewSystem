using System;
using PokemonReviewSystem.Models;

namespace PokemonReviewSystem.Interface
{
	public interface ICountryRepository
	{
        bool CountryExists(int countryId);

        ICollection<Country> GetCountries();

        Country GetCountry(int Id);

        Country GetCountryByOwner(int owner);

        ICollection<Owner> GetOwnersFromCountry(int countryId);
    }

	

}

