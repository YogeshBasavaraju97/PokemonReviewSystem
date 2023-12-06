using System;
using AutoMapper;
using PokemonReviewSystem.Dto;
using PokemonReviewSystem.Models;

namespace PokemonReviewSystem.AutoMapper
{
	public class MappingProfiles : Profile
	{
		public MappingProfiles()
		{
			CreateMap<Pokemon, PokemonDto>();

			CreateMap<Category, CategoryDto>();

			CreateMap<Country, CountryDto>();


		}
	}
}

