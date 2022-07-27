using System;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PokemonReviewProject.Data;
using PokemonReviewProject.Models;

namespace PokemonReviewProject.Repository.ReviewerFile
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
            return _context.Reviewers.Where(r => r.Id == reviewerId).Include(e => e.Reviews).FirstOrDefault();
        }

        public ICollection<Review> GetReviewsByReviewer(int reviewerId)
        {
            return _context.Reviews.Where(r => r.Reviewer.Id == reviewerId).ToList();
        }

        public ICollection<Reviewer> GetReviwers()
        {
            return _context.Reviewers.ToList();
        } 

        public bool ReviewerExists(int reviwerId)
        {
            return _context.Reviewers.Any(r => r.Id == reviwerId);
        }
    }
}

