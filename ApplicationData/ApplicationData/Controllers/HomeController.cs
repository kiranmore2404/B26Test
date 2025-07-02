using System.Diagnostics;
using ApplicationData.Models;
using ApplicationData.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationData.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentRepo _studentRepo  =null;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _studentRepo = new StudentRepo();
        }
        public List<StudentModel> getAllStudent()
        {
            return _studentRepo.GetAllstudent();


        }
        public StudentModel getStudentById(int id)
        {
            return _studentRepo.GetstudentById(id);
        }


        public IActionResult Index()
        {
            //var student = new List<StudentModel>
            //{
            //    new StudentModel  {rollNo=1, name="kiran",Gender = "male",Standard = 12 },
            //    new StudentModel {rollNo=2, name="kishor" ,Gender = "male",Standard = 10 },
            //    new StudentModel  {rollNo=3, name="Shiv",Gender = "male",Standard = 12  }
            //    };
            //ViewData["students"] = student; 

            return View();
        }
        

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
