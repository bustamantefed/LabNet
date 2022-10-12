using Lab.Practica.Ef.Entities;
using Lab.Practice.WApi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Lab.Practice.WApi.Controllers
{
    public class WebApiController : ApiController
    {
        private LabPracticeWApiContext db = new LabPracticeWApiContext();
  

        // GET: Employees
        private ActionResult View(List<Employees> employees)
        {
            return View(db.Employees.ToList());
        }
    }
}