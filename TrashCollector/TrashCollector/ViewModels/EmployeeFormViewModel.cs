using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrashCollector.Models;

namespace TrashCollector.ViewModels
{
    public class EmployeeFormViewModel
    {
        public Employee Employee { get; set; }

        public IEnumerable<ZipCode> ZipCodes { get; set; }
    }
}