using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace venncuisine.Data
{
    public class Cuisines
    {
        [Key]
        public int CuisineId { get; set; }
        public string CuisineName { get; set; }
        public string FormattedName { get; set; }
    }
}
