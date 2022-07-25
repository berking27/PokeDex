using System;
namespace PokemonReviewProject.Models
{
    public class Review
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

        public int Rating { get; set; }

        public Pokemon Pokemon { get; set; } // One to Many One side

        public Reviewer Reviewer { get; set; } // one to Many One side
        
    }
}

