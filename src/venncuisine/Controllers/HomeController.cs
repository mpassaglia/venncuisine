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
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public string GetCuisineIngredients()
        {
            return JsonConvert.SerializeObject(_db.NamedCuisineIngredients.ToList());
        }
        [HttpGet]
        public string GetCuisines()
        {
            return JsonConvert.SerializeObject(_db.Cuisines.ToList());
        }

    }
}
