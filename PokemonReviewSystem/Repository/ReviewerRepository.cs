using System;
using AutoMapper;
using PokemonReviewSystem.Data;
using PokemonReviewSystem.Interface;
using PokemonReviewSystem.Models;

namespace PokemonReviewSystem.Repository
{
	public class ReviewerRepository : IReviewerRepository
	{
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public ReviewerRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Reviewer GetReviewer(int reviewerId)
        {
            return _context.Reviewers.Where(r => r.ReviewerId == reviewerId).FirstOrDefault();
        }

        public ICollection<Reviewer> GetReviewers()
        {
            return _context.Reviewers.ToList();
        }

        public ICollection<Review> GetReviewsByReviewer(int reviewerId)
        {
            return _context.Reviews.Where(r => r.Reviewer.ReviewerId == reviewerId).ToList();
        }

        public bool ReviewerExists(int reviewerId)
        {
            return _context.Reviewers.Any(r => r.ReviewerId == reviewerId);
        }

    }
}

