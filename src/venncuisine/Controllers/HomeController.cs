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
        private VennCuisineContext _db = new VennCuisineContext();
        public HomeController(VennCuisineContext context)
        {
            _db = context;
            Cuisines = new List<Data.Cuisines>();
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            Cuisines = _db.Cuisines.ToList();
            return View();
        }
        public List<Cuisines> Cuisines { get; set; }

    }
}
