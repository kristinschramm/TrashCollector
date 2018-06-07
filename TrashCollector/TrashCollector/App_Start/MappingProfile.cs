using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using TrashCollector.Dtos;
using TrashCollector.Models;

namespace TrashCollector.App_Start
{
    public class MappingProfile : Profile


    {
        public MappingProfile()//use to edit and store customer on the client without compromising data before sending to server. Safer and faster so the client isn't going back and forth from the server
        {
            CreateMap<Customer, CustomerDto>();
            //CreateMap<Employee, EmployeeDto>();
            CreateMap<CustomerDto, Customer>().ForMember(c => c.Id, opt => opt.Ignore());
            //   CreateMap<EmployeeDto, Employee>().ForMember(c => c.ID, opt => opt.Ignore());
            //
        }
    }
}