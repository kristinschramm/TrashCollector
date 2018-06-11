using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace TrashCollector.Models
{
    public class Address
    {
        public int AddressId { get; set; }

        [Display(Name = "Address")]
        public string AddressString { get; set; }

    }
}