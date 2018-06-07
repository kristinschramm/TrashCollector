using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TrashCollector.Models
{
    public class ZipCode
    {
        public int ZipCodeId { get; set; }

        [Display(Name = "Zip Code")]
        [Range(11111,99999)]
        public int Code { get; set; }
    }
}