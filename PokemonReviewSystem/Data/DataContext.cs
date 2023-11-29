using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using PokemonReviewSystem.Models;

namespace PokemonReviewSystem.Data
{
   
    public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DbContext> options):base(options)
		{
		}

        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Category> categories { get; set; }

		public DbSet<Country> Countries { get; set; }

		public DbSet<Owner> Owners { get; set; }

		public DbSet<Pokemon> Pokemon { get; set; }

		public DbSet<PokemonCategory> PokemonCatgories { get; set; }

		public DbSet<PokemonOwner> PokemonOwners { get; set; }

		public DbSet<Review> Reviews { get; set; }

		public DbSet<Reviewer> reviewers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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


            modelBuilder.Entity<PokemonOwner>()
                    .HasKey(po => new { po.PokemonId, po.OwnerId });
            modelBuilder.Entity<PokemonOwner>()
                    .HasOne(p => p.Pokemon)
                    .WithMany(pc => pc.PokemonOwners)
                    .HasForeignKey(p => p.PokemonId);
            modelBuilder.Entity<PokemonOwner>()
                    .HasOne(p => p.Owner)
                    .WithMany(pc => pc.PokemonOwners)
                    .HasForeignKey(c => c.OwnerId);
        }

		 
    }

    public class YourDbContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseSqlServer("Server=localhost,1433; Database=PokemonReview; User Id=sa; Password= Admin@1234; encrypt=true; Trusted_Connection=true;");

            return new DataContext(optionsBuilder.Options);
        }
    }
}

