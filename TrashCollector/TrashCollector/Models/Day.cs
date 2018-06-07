using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TrashCollector.Models
{
    public class Day
    {
        public int DayId { get; set; }
        public string Name { get; set;  }
    }
}