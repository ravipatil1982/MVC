using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTraining.Models
{
    public class BasicViewModel
    {
        public List<Certificate> Certificates { get; set; }
        public Employee employee { get; set; }
        public HttpPostedFileBase Photo { get; set; }

    }

    public class Certificate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
    }
}