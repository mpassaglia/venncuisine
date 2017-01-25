using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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
            NamedCuisineIngredients = _db.NamedCuisineIngredients.ToList();
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            //CuisineIngredients = _db.CuisineIngredients.ToList();
            //NamedCuisineIngredients = 
            return View();
        }
        //public List<CuisineIngredients> CuisineIngredients { get; set; }
        public List<NamedCuisineIngredients> NamedCuisineIngredients { get; set; }

        [HttpGet]
        public string GetCuisineIngredients()
        {
            return JsonConvert.SerializeObject(NamedCuisineIngredients.ToList());
        }

    }
}
