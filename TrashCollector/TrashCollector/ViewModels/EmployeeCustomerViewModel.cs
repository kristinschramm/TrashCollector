﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrashCollector.Models;


namespace TrashCollector.ViewModels
{
    public class EmployeeCustomerViewModel 
    {
        public IEnumerable<Customer> Customers { get; set; }

       
    }
}