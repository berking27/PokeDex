using System;
using Microsoft.EntityFrameworkCore;
using PokemonReviewProject.Models;

namespace PokemonReviewProject.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Owner> Owners { get; set; }

        public DbSet<Pokemon> Pokemon { get; set; }

        public DbSet<PokemonOwner> PokemonOwners { get; set; }

        public DbSet<PokemonCategory> PokemonCategories { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<Reviewer> Reviewers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Pokemon Category Relationships stars
            modelBuilder.Entity<PokemonCategory>()
                    .HasKey(pc => new { pc.PokemonId, pc.CategoryId });
            modelBuilder.Entity<PokemonCategory>()
                    .HasOne(p => p.Pokemon)
                    .WithMany(pc => pc.PokemonCategories)
                    .HasForeignKey(p => p.PokemonId);
            modelBuilder.Entity<PokemonCategory>()
                    .HasOne(p => p.Category)
                    .WithMany(pc => pc.PokemonCategories)
                    .HasForeignKey(p => p.CategoryId);
            //Pokemon Category Relationships ends


            //Pokemon Owner Relationships stars
            modelBuilder.Entity<PokemonOwner>()
                    .HasKey(po => new { po.PokemonId, po.OwnerId });
            modelBuilder.Entity<PokemonOwner>()
                    .HasOne(p => p.Pokemon)
                    .WithMany(po => po.PokemonOwners)
                    .HasForeignKey(o => o.PokemonId);
            modelBuilder.Entity<PokemonOwner>()
                    .HasOne(p => p.Owner)
                    .WithMany(po => po.PokemonOwners)
                    .HasForeignKey(o => o.OwnerId);





        }

    }
}

