using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace venncuisine.Data
{
    [Table("NamedCuisineIngredients")]
    public class NamedCuisineIngredients
    {
        
        public int CuisineId { get; set; }
        public int IngredientId { get; set; }
        public string FormattedName { get; set; }
        public string IngredientName { get; set; }
    }
}
