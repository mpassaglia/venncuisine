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

        [HttpPost]
        public IActionResult FindUnion([FromBody] Union obj)
        {
            var namedCI = _db.NamedCuisineIngredients.ToList();

            var firstList = namedCI.Where(x => x.CuisineId == obj.first);
            var secondList = namedCI.Where(x => x.CuisineId == obj.second);

            var union = firstList.Join(secondList, c1 => c1.IngredientId, c2 => c2.IngredientId, (c1, c2) => c1).ToList();

            return Json(new { union = union, left = firstList.Except(union).ToList(), right = secondList.Except(union).ToList() });
        }

    }
}
