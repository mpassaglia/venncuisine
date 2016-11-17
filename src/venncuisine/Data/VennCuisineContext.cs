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
        public VennCuisineContext() : base()
        {

        }
        public DbSet<Cuisines> Cuisines { get; set; }
        public DbSet<Ingredients> Ingredients { get; set; }
        public DbSet<CuisineIngredients> CuisineIngredients { get; set; }
    }
}
