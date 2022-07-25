using System;
namespace PokemonReviewProject.Models
{
    public class Country
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Owner> Owners { get; set; } // One to Many Relationship


    }
}

