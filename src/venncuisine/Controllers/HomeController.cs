using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using venncuisine.Data;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace venncuisine.Controllers
{
    public class HomeController : Controller
    {
        private VennCuisineContext _db;
        public HomeController(VennCuisineContext context)
        {
            _db = context;
            //CuisineIngredients = new List<CuisineIngredients>();
            NamedCuisineIngredients = new List<NamedCuisineIngredients>();
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            //CuisineIngredients = _db.CuisineIngredients.ToList();
            NamedCuisineIngredients = _db.NamedCuisineIngredients.ToList();
            return View();
        }
        //public List<CuisineIngredients> CuisineIngredients { get; set; }
        public List<NamedCuisineIngredients> NamedCuisineIngredients { get; set; }

    }
}
