using Microsoft.AspNetCore.Mvc;

namespace _01_CRUDOperations.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
