﻿using System;
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

       
    }
}

