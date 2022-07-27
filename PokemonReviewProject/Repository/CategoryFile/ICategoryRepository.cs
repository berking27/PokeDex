using System;
using PokemonReviewProject.Models;

namespace PokemonReviewProject.Repository.CategoryFile
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetCategories();

        Category GetCategory(int id);

        ICollection<Pokemon> GetPokemonByCategory(int categoryId);

        bool CategoryExist(int id);

    }
}

