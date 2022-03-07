using Microsoft.AspNetCore.Mvc;
using Restaurant_DotnetCoreMvc.Models;

namespace Restaurant_DotnetCoreMvc.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository pierepository;
        private readonly ICategoryRepository categoryrepository;

        public IActionResult Index()
        {
            return View("List", pierepository.AllPies);
        }

        public PieController(IPieRepository pierepository, ICategoryRepository categoryrepository)
        {
            this.pierepository = pierepository;
            this.categoryrepository = categoryrepository;
        }

        public ViewResult List() {
            ViewBag.Category = "New Category";
            return View(pierepository.AllPies);
        }

        [HttpPost]
        public IActionResult Create(Pie p) {

            pierepository.CreatePie(p);
            return RedirectToAction("Index");
        }
        public IActionResult Create()
        {
            return View("Create");
        }


        public IActionResult Details(int Id) { 
        
            var pie= pierepository.GetPieById(Id);
            if (pie == null)
                return NotFound();

            return View(pie);
        }

    }
}
