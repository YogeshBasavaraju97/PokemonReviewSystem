﻿using System;
using PokemonReviewSystem.Models;

namespace PokemonReviewSystem.Interface
{
	public interface ICategoryRepository
	{
	

		ICollection<Category> GetCategories();

		Category GetCategory(int id);

		ICollection<Pokemon> GetPokemonByCategory(int categoryId);

		bool CategoryExists(int id);
	}
}

