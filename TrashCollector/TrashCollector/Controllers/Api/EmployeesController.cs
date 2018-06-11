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
    public class EmployeesController : ApiController

    {
        private ApplicationDbContext _context;

        public EmployeesController()
        {
            _context = new ApplicationDbContext();
        }

        // GET api/employees
        public IHttpActionResult GetEmployees()
        {
            var employeeDtos = _context.Employees                
                 .Include(c => c.ZipCode)
                 .ToList()
                 .Select(Mapper.Map<Employee, EmployeeDto>);

            return Ok(employeeDtos);
        }

        // GET api/employees/5
        public IHttpActionResult GetEmployee(int id)
        {
            var employee = _context.Employees.SingleOrDefault(c => c.Id == id);

            if (employee== null)
                return NotFound();

            return Ok(Mapper.Map<Employee, EmployeeDto>(employee));
        }
        

        // POST api/employees
        [Authorize(Roles ="admin")]
        [HttpPost] //use to specify post method without including post in the function name
        public IHttpActionResult CreateEmployee(EmployeeDto employeeDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var employee = Mapper.Map<EmployeeDto, Employee>(employeeDto);
            

            _context.Employees.Add(employee);

            _context.SaveChanges();
            

            employeeDto.Id = employee.Id;

            return Created(new Uri(Request.RequestUri + "/" + employee.Id), employeeDto);
        }

        //PUT /api/employees/1
        [HttpPut]
        public IHttpActionResult Updateemployee(int id, EmployeeDto employeeDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var employeeInDb = _context.Employees.SingleOrDefault(c => c.Id == id);

            if (employeeInDb == null)
                return NotFound();

            Mapper.Map(employeeDto, employeeInDb);

            _context.SaveChanges();

            return Ok();

        }

        //DELETE  /api/employees/1
        [HttpDelete]
        public IHttpActionResult DeleteEmployee(int id)
        {
            var employeeInDb = _context.Employees.SingleOrDefault(c => c.Id == id);

            if (employeeInDb == null)
                return NotFound();
            _context.Employees.Remove(employeeInDb);
            _context.SaveChanges();
            return Ok();
        }
    }
}
