using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace TrashCollector.Models
{
    public class State
    {
        public int Id { get; set; }

        [Display(Name ="State")]
        public string StateName { get; set; }

        [Display (Name ="Postal Code")]
        [MinLength(2), MaxLength(2)]
        public string PostalCode { get; set; }


    }
}