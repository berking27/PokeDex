using System;
using PokemonReviewProject.Models;

namespace PokemonReviewProject.Repository.CountryFile
{
    public interface ICountryRepository
    {
       

        ICollection<Country> GetCountries();
        Country GetCountry(int id);
        Country GetCountryByOwner(int ownerId);
        ICollection<Owner> GetOwnersFromACountry(int countryId);
        bool CountryExists(int id);
    }
}

