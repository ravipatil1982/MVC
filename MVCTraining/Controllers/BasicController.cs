using MVCTraining.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTraining.Controllers
{
    public class BasicController : Controller
    {
        public Employee EmployeeModel;
        public BasicViewModel basicViewModel;

        public BasicController()
        {
            basicViewModel = new BasicViewModel();
        }

        // GET: Basic
        public ActionResult Index()
        {
            basicViewModel.Certificates = GetAllCertificates();
            basicViewModel.employee = new Employee();
            ViewBag.SuccessMessage = string.Empty;
            return View(basicViewModel);
        }

        private List<Certificate> GetAllCertificates()
        {
            return new List<Certificate>() {
                new Certificate { Id=1, Name="MCSD", Subject="Asp.Net MVC"  },
                new Certificate { Id=2, Name="MCTS", Subject="SharePoint 2010"  },
                new Certificate { Id=3, Name="Blcokchain", Subject="Corda"  }
            };
            throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult CreateEmployee(Employee model)
        {
            var Photo = model.Photo;
            ViewBag.SuccessMessage = "Empployee created successfully!";
            return View("Index");
        }
    }
}