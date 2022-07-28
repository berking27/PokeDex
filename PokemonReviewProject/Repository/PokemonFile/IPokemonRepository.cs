using System;
using PokemonReviewProject.Models;

namespace PokemonReviewProject.Repository.PokemonFile
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();

        Pokemon GetPokemon(int id);

        Pokemon GetPokemon(string name);

        decimal GetPokemonRating(int pokeId);

        bool PokemonExist(int pokeId);

        //Depends on the relations and join tables.
        //We can say put paramaters according to One/Many relations
        //Here Owner/Category is in many Relation. You can memorize by this way.
        bool CreatePokemon(int ownerId , int categoryId , Pokemon pokemon);

        bool UpdatePokemon(int ownerId, int categoryId , Pokemon pokemon);

        bool DeletePokemon(Pokemon pokemon);

        bool Save();

       
    }
}

