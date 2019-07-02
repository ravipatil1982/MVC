using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace MVCTraining.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public HttpPostedFileBase Photo { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; }
    }
}