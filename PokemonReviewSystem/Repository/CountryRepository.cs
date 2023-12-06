using System;
using PokemonReviewSystem.Data;
using PokemonReviewSystem.Interface;
using PokemonReviewSystem.Models;

namespace PokemonReviewSystem.Repository
{
	public class CountryRepository : ICountryRepository
	{
        private readonly DataContext _context;

        public CountryRepository(DataContext context)
		{
            _context = context;
        }

        public bool CountryExists(int countryId)
        {
            return _context.Countries.Any(c => c.Id == countryId);
        }

        public ICollection<Country> GetCountries()
        {
            return _context.Countries.ToList();
        }

        public Country GetCountry(int Id)
        {
            return _context.Countries.Where(c => c.Id == Id).FirstOrDefault();
        }
        
        public Country GetCountryByOwner(int owner)
        {
            return _context.Owners.Where(o => o.Id == owner).Select(c => c.Country).FirstOrDefault();
        }

        public ICollection<Owner> GetOwnersFromCountry(int countryId)
        {
            return _context.Owners.Where(c => c.Country.Id == countryId).ToList();

        }
    }
}

