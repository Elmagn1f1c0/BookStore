using Microsoft.AspNetCore.Mvc;

namespace MovieStore.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
