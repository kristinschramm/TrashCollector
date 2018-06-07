using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrashCollector.Models;


namespace TrashCollector.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<Day> Days { get; set; }
        public Customer Customer { get; set; }
        public IEnumerable<ZipCode> ZipCodes { get; set; }
    }
}