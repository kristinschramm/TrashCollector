using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrashCollector.Models;
using System.ComponentModel.DataAnnotations;

namespace TrashCollector.Dtos
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        public ZipCode ZipCode { get; set; }
        [Required]
        [Range(11111, 99999)]
        public int ZipCodeId { get; set; }
        [Phone]
        [Required]
        public string PhoneNumber { get; set; }
    }
}