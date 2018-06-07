using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TrashCollector.Models
{
    public class Address
    {
        public int Id { get; set; }
        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }
        [Display(Name = "Unit/Apt Number")]
        public string SubAddress { get; set; }
        public string City { get; set; }
        [MinLength(5), MaxLength(5) ]
        public string ZipCode { get; set; }

        public State State { get; set; }
        [Display(Name = "State")]
        public int StateId { get; set; }
       
        
    }
}