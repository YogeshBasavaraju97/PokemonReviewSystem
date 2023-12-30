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
            CreateMap<PokemonDto, Pokemon>();

            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();

            CreateMap<Country, CountryDto>();
            CreateMap<CountryDto, Country>();

            CreateMap<Owner, OwnerDto>();
            CreateMap<OwnerDto, Owner>();

            CreateMap<Review, ReviewDto>();

			CreateMap<Reviewer, ReviewerDto>();

			
         


        }
	}
}

