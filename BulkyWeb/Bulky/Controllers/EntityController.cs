
using Bulky.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bulky.Controllers
{
    public class EntityController : Controller
    {
        private readonly ApplicationDbContext _db;
        public EntityController(ApplicationDbContext db)
        {
            _db = db;
            
        }
        public IActionResult Index()
        {
           
            
            return View();
        }
    }
}
