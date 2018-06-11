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
        [Display(Name = "First Name")]
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Display(Name = "Phone Number")]
        [Phone]
        [Required]
        public string PhoneNumber { get; set; }
        public Address Address { get; set; }
        [Required]
        [Display(Name = "Address")]
        public int AddressId { get; set; }

        public ZipCode ZipCode { get; set; }
        [Required]
        [Display(Name = "Zip Code")]
        public int ZipCodeId { get; set; }


        public Day Day { get; set; }
        [Required]
        [Display(Name = "Pickup Day")]
        public int DayId { get; set; }
        [Display(Name = "Account Balance")]
        public double? AccountBalance { get; set; }

    }
}