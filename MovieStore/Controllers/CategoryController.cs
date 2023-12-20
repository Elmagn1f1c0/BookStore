using Microsoft.AspNetCore.Mvc;
using MovieStore.Data;
using MovieStore.Models;

namespace MovieStore.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> category = _db.categories.ToList();
            return View(category);
        }
    }
}
