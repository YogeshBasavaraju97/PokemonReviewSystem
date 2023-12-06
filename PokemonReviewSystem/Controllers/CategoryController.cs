using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PokemonReviewSystem.Dto;
using PokemonReviewSystem.Interface;
using PokemonReviewSystem.Models;
using PokemonReviewSystem.Repository;

namespace PokemonReviewSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController: Controller
	{
        private readonly ICategoryRepository _categoryRepositroy;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryRepository categoryRepository, IMapper mapper)
		{
            _categoryRepositroy = categoryRepository;
            _mapper = mapper;
        }


        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Category>))]

        public IActionResult GetPokemons()
        {
            var category = _mapper.Map<List<CategoryDto>>(_categoryRepositroy.GetCategories());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(category);
        }

        [HttpGet("{categoryId}")]
        [ProducesResponseType(200, Type = typeof(Category))]
        [ProducesResponseType(400)]
        public IActionResult GetPokemon(int categoryId)
        {
            if (!_categoryRepositroy.CategoryExists(categoryId))
            {
                return NotFound();
            }

            var category = _mapper.Map<CategoryDto>(_categoryRepositroy.GetCategory(categoryId));

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(category);
        }

        [HttpGet("pokemon/{categoryId}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Category>))]
        [ProducesResponseType(400)]
        public IActionResult GetPokemonByCategory(int categoryId)
        {
            var pokemons = _mapper.Map<List<Pokemon>>(_categoryRepositroy.GetPokemonByCategory(categoryId));

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok(pokemons);
        }

    }
}

