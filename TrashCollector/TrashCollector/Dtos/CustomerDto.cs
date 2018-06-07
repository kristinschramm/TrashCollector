using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrashCollector.Models;
using System.ComponentModel.DataAnnotations;

namespace TrashCollector.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        [Required]
        [StringLength (50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        public Address Address { get; set; }
        [Phone]
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public int DayId { get; set; }
    }
}