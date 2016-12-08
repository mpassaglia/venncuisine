using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions;

namespace venncuisine.Data
{
    public class VennCuisineContext : DbContext
    {
        public VennCuisineContext(DbContextOptions<VennCuisineContext> options) 
            : base(options)
        {

        }
        public DbSet<Cuisines> Cuisines { get; set; }
        public DbSet<Ingredients> Ingredients { get; set; }
        public DbSet<CuisineIngredients> CuisineIngredients { get; set; }
        public DbSet<NamedCuisineIngredients> NamedCuisineIngredients { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<CuisineIngredients>().HasKey(a => new { a.CuisineId, a.IngredientId });
            builder.Entity<NamedCuisineIngredients>().HasKey(a => new { a.CuisineId, a.IngredientId });
        }
    }
}
