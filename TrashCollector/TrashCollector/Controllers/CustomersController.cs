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
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult New()
        {
            var viewModel = new CustomerFormViewModel
            {
                Days = _context.Days.ToList(),
                ZipCodes = _context.ZipCodes.ToList()

            };

            return View("CustomerForm", viewModel);
        }
        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            var daysPickup = _context.Days.ToList();
            var viewModel = new CustomerFormViewModel
            {
                Customer = customer,
                Days = daysPickup,
                ZipCodes = _context.ZipCodes.ToList(),
                Addresses = _context.Addresses.ToList()
            };
            return View("CustomerForm", viewModel);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new CustomerFormViewModel
                {
                    Customer = customer,
                    ZipCodes = _context.ZipCodes.ToList(),
                    Days = _context.Days.ToList(),
                };
                return View("CustomerForm", viewModel);

            }
            if (customer.Id == 0)
                _context.Customers.Add(customer);
            else
            {
                var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);
                customerInDb.FirstName = customer.FirstName;
                customerInDb.LastName = customer.LastName;
                customerInDb.Address.AddressString = customer.Address.AddressString;
                customerInDb.DayId = customer.DayId;
                customerInDb.PhoneNumber = customer.PhoneNumber;

            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Customers"); //fix when create roles
        }

        public ViewResult Index()
        {
            var viewModel = new CustomerViewModel
            {
                Customers = _context.Customers.Include(c => c.Day).Include(c => c.Address).Include(c => c.ZipCode).ToList(),

            };


            return View(viewModel);
        }

        

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.Day).Include(c => c.Address).SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();
            return View(customer);
        }



    }
}