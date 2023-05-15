using System;
using Bogus;
using Microsoft.EntityFrameworkCore;
using Villa_API.Models;

namespace Villa_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            int id = 1;
            var villa = new Faker<Villa>().StrictMode(true)
                .RuleFor(x => x.Id, f => id++)
                .RuleFor(x => x.Name, f => f.Name.FindName())
                .RuleFor(x => x.Details, f => f.Lorem.Lines())
                .RuleFor(x => x.ImageURL, f => f.Image.PicsumUrl())
                .RuleFor(x => x.Occupancy, f => f.Random.Int(1, 10))
                .RuleFor(x => x.Rate, f => f.Random.Int(1, 5))
                .RuleFor(x => x.SqureFeet, f => f.Random.Int(500, 2500))
                .RuleFor(x => x.Amenity, f => f.Lorem.Sentence())
                .RuleFor(x => x.CreatedDate, f => f.Date.Recent())
                .RuleFor(x => x.UpdatedDate, f => f.Date.Past());


            var villas = villa.Generate(200);
            modelBuilder.Entity<Villa>().HasData(villas);
        }
    }
}

