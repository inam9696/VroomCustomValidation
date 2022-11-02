using Microsoft.AspNetCore.Mvc;
using Vroom.AppDbContext;
using Vroom.Models;

namespace Vroom.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly VroomDbContext db;

        public EmployeeController(VroomDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
           IEnumerable<Employee> employees = db.Employees.ToList();
            return View(employees);

        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(EmployeeVM employee)
        {
            if (ModelState.IsValid)
            {
                // var creat = db.Employees.Where(x => x.Id == employee.Id).FirstOrDefault();
                Employee s = new Employee
                {
                    FirstName = employee.FirstName,
                    LastName = employee.LastName,
                    Phone = employee.Phone,
                    DOB = employee.DOB
                };

                db.Employees.Add(s);
                db.SaveChanges();
            return RedirectToAction("Index");
            }
            //return RedirectToAction("Index");
            return View("Create");
        }
    }
}
