using CrudService.Migrations;
using CrudService.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CrudService.Controllers
{
    public class CustomerController : Controller
    {
        private readonly CrudServiceContext _db;
        public CustomerController(CrudServiceContext db)
        {
            _db = db;

        }
        // Action method to display the list of customers
        public IActionResult Index()
        {
            List<Customer> objlist = _db.customers.ToList();
            return View(objlist);
          
           
        }
        public IActionResult create() {
            return View();

        }
        [HttpPost]
        public IActionResult create(Customer obj) {
           
            if (obj.name == obj.DisplayOrder.ToString()){
                ModelState.AddModelError("name", "the diplay order cannot match the name ");
            }
            if (ModelState.IsValid) {
                _db.customers.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(obj);
        }
        public IActionResult Edit(int ? id)
        {
            if (id == null || id==0) { 
                return NotFound();
            }
            Customer? customers = _db.customers.Find(id);
            if (customers == null) { 
                return NotFound();
            }
            return View(customers);

        }
        [HttpPost]
        public IActionResult Edit(Customer obj)
        {

               if (ModelState.IsValid)
            {
                _db.customers.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(obj);
        }


    }
}
