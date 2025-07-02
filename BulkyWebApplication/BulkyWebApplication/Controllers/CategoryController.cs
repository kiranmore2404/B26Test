using BulkyWebApplication.Data;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWebApplication.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDb _db;
        public CategoryController ( ApplicationDb db)
            {
                _db = db;
            }
       
        public IActionResult Index()
        {
            var objList = _db.categories.ToList();
            return View(objList);
        }
    }
}
