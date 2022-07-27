using System;
using AutoMapper;
using PokemonReviewProject.DTOs;
using PokemonReviewProject.Models;

namespace PokemonReviewProject.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Pokemon, PokemonDto>(); //Pokemon OK
            CreateMap<PokemonDto, Pokemon>();
            CreateMap<Category, CategoryDto>(); //Category OK
            CreateMap<CategoryDto, Category>();
            CreateMap<Country, CountryDto>(); //Country OK
            CreateMap<CountryDto, Country>();
            CreateMap<Owner,OwnerDto>();  //Owner OK
            CreateMap<OwnerDto, Owner>();
            CreateMap<Review, ReviewDto>(); // Review OK
            CreateMap<ReviewDto, Review>();
            CreateMap<ReviewerDto, Reviewer>();
            CreateMap<Reviewer, ReviewerDto>();//Reviewer OK

        }
    }
}

