using System;
using AutoMapper;
using PokemonReviewSystem.Data;
using PokemonReviewSystem.Interface;
using PokemonReviewSystem.Models;

namespace PokemonReviewSystem.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public CategoryRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public bool CategoryExists(int id)
        {
            return _context.categories.Any(p => p.Id == id);
        }

        public ICollection<Category> GetCategories()
        {
            return _context.categories.ToList();
        }

        public Category GetCategory(int id)
        {
            return _context.categories.Where(p => p.Id == id).FirstOrDefault();
        }

        public ICollection<Pokemon> GetPokemonByCategory(int categoryId)
        {
            return _context.PokemonCatgories.Where(p => p.CategoryId == categoryId).Select(c => c.Pokemon).ToList();
        }
    }
}

