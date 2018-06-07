﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TrashCollector.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Display(Name = "First Name")]
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Display(Name ="Last Name")]
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        public Address Address { get; set; }
        [Display(Name = "Phone Number")]
        [Phone]
        [Required]
        public string PhoneNumber { get; set; }
        public Day Day { get; set; }
        [Required]
        public int DayId { get; set; }

    }
}