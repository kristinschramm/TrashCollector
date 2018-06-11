
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TrashCollector.Models;
using TrashCollector.Dtos;
using AutoMapper;


namespace TrashCollector.Controllers.Api
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        
        // GET api/customers
        public IHttpActionResult GetCustomers()
        {
            var customerDtos = _context.Customers                
                 .Include(c => c.Address)
                 .Include(c => c.ZipCode)
                 .Include(c => c.Day)
                 .ToList()
                 .Select(Mapper.Map<Customer, CustomerDto>);

            return Ok(customerDtos);
        }
        public IHttpActionResult Route(int id)
        {
            var employeeDto = _context.Employees.SingleOrDefault(c => c.Id == id);
            var customersDto = _context.Customers
                .Include(c => c.Day)
                .Include(c => c.Address)
                .Include(c => c.ZipCode == employeeDto.ZipCode)
                .ToList()
                .Select(Mapper.Map<Customer, CustomerDto>);



            return Ok(customersDto);
        }

        // GET api/customers/5
        public IHttpActionResult GetCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return NotFound();

            return Ok(Mapper.Map<Customer, CustomerDto>(customer));
        }

        // POST api/customers
        [HttpPost] //use to specify post method without including post in the function name
        public IHttpActionResult CreateCustomer(CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var customer = Mapper.Map<CustomerDto, Customer>(customerDto);

            _context.Customers.Add(customer);

            _context.SaveChanges();

            customerDto.Id = customer.Id;

            return Created(new Uri(Request.RequestUri + "/" + customer.Id), customerDto);
        }

        //PUT /api/customers/1
        [HttpPut]
        public IHttpActionResult UpdateCustomer(int id, CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null)
                return NotFound();

            Mapper.Map(customerDto, customerInDb);

            _context.SaveChanges();

            return Ok();

        }

        //DELETE  /api/customers/1
        [HttpDelete]
        public IHttpActionResult DeleteCustomer(int id)
        {
            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null)
                return NotFound();
            _context.Customers.Remove(customerInDb);
            _context.SaveChanges();
            return Ok();
        }
    }
}