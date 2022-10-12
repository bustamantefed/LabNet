using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.Practice.WebApi.Models
{
    public class EmployeeRequest
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tittle { get; set; }

    }
}