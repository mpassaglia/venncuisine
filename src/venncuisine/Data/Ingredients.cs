using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace venncuisine.Data
{
    public class Ingredients
    {
        [Key]
        public int IngredientId { get; set; }
        public string IngredientName { get; set; }
    }
}
