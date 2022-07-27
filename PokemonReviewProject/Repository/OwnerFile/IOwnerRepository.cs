﻿using System;
using PokemonReviewProject.Models;

namespace PokemonReviewProject.Repository.OwnerFile
{
    public interface IOwnerRepository
    {
        ICollection<Owner> GetOwners();

        Owner GetOwner(int ownerId);

        ICollection<Owner> GetOwnerOfAPokemon(int pokeId);

        ICollection<Pokemon> GetPokemonByOwner(int ownerId);

        bool OwnerExists(int ownerId);

    }
}
