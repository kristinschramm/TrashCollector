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
            [HttpPost]
            public ActionResult Save(Employee employee)
            {
                if (employee.Id == 0)
                    return HttpNotFound();

            else
                {
                    var employeeInDb = _context.Employees.Single(c => c.Id == employee.Id);
                    //mapping

                }
                _context.SaveChanges();

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
