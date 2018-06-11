using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using TrashCollector.Models;
using TrashCollector.ViewModels;


namespace TrashCollector.Controllers
{
        public class EmployeesController : Controller
        {
            private ApplicationDbContext _context;
            public EmployeesController()
            {
                _context = new ApplicationDbContext();
            }
            protected override void Dispose(bool disposing)
            {
                _context.Dispose();
            }
            public ActionResult EmployeeForm()
            {
                var zipCodes = _context.ZipCodes.ToList();
                var viewModel = new EmployeeFormViewModel
                {
                    ZipCodes = zipCodes
                };
                return View(viewModel);

            }
        public ActionResult Route(int id)
        {
            var employee = _context.Employees.SingleOrDefault(c => c.Id == id);
            var customers = _context.Customers.Include(c => c.Day).Include(c=>c.ZipCode).ToList();
            List<Customer> todaysCustomers = new List<Customer>();
            foreach (Customer c in customers)
            {
                if (c.ZipCodeId == employee.ZipCodeId && c.Day.Name == DateTime.Now.DayOfWeek.ToString())
                    todaysCustomers.Add(c);
            }

            
            


            return View("Route", todaysCustomers);
        }

        [HttpPost]
            public ActionResult Save(Employee employee)
            {
            if (!ModelState.IsValid)
            {
                var viewModel = new EmployeeFormViewModel
                {
                    Employee = employee,
                    ZipCodes = _context.ZipCodes.ToList(),
                };
                return View("EmployeeForm", viewModel);

            }
            if (employee.Id == 0)
                _context.Employees.Add(employee);
            else
            {
                var employeeInDb = _context.Employees.Single(e => e.Id == employee.Id);
                employeeInDb.FirstName = employee.FirstName;
                employeeInDb.LastName = employee.LastName;
                employeeInDb.ZipCodeId = employee.ZipCodeId;
            }

            return RedirectToAction("Index", "Employees"); //fix when create roles
            }
            public ViewResult Index()
            {
                var employees = _context.Employees.Include(c => c.ZipCode).ToList();
                return View(employees);
            }
            public ActionResult Details(int id)
            {
                var employee = _context.Employees.SingleOrDefault(c => c.Id == id);
                if (employee == null)
                    return HttpNotFound();
                return View(employee);
            }

            public ActionResult Edit(int id)
            {
                var employee = _context.Employees.SingleOrDefault(c => c.Id == id);
                if (employee == null)
                    return HttpNotFound();
                var viewModel = new EmployeeFormViewModel
                {
                    Employee = employee,
                    ZipCodes = _context.ZipCodes.ToList()
                };


                return View("EmployeeForm", viewModel);
            }

        }
    
}
