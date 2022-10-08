using Lab.Practica.Ef.Logic;
using Lab.Practica.Ef.Entities;
using Lab.Practice.Ef.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.Practice.Ef.MVC.Controllers
{
    public class EmployeesController : Controller
    {
        EmployeesLogic employeelog = new EmployeesLogic();
        // GET: Employees
        public ActionResult Index()
        {

            List<Lab.Practica.Ef.Entities.Employees> employee = employeelog.GetAll();

            List<EmployeesView> employeeView = employee.Select(e => new EmployeesView
            {
                Id = e.EmployeeID,
                LastName = e.LastName,
                FirstName = e.FirstName,
                Tittle = e.Title ,
                BirthDate = Convert.ToString( e.BirthDate),
                HireDate = Convert.ToString( e.HireDate),
                Country = e.Country,
                Address = e.Address,
                City = e.City,
                Region = e.Region,
                PostalCode = e.PostalCode,
                Phone = e.HomePhone,

            }).ToList();
            return View(employeeView);
        }
  
        
        [HttpPost]
        public ActionResult Edit(Employees employeesid)
        {
            try
            {
                employeelog.Update(employeesid);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error", ex.Message);
            }


        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            try
            {
                if (id > 9 || id != 0)
                {
                    employeelog.Delete(id);

                    return RedirectToAction("Index");
                }

                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error", ex.Message);
            }


        }

        public ActionResult InsertEmployee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InsertEmployee(EmployeesView empView)
        {

            try
            {

                    Employees employeeEntity = new Employees
                    {
                        LastName = empView.LastName,
                        FirstName = empView.FirstName,
                        Title = empView.Tittle,
                        BirthDate = Convert.ToDateTime(empView.BirthDate),
                        HireDate = Convert.ToDateTime(empView.HireDate),
                        Address = empView.Address,
                        Country = empView.Country,
                        City = empView.City,
                        Region = empView.Region,
                        PostalCode = empView.PostalCode,
                        HomePhone = empView.Phone
                    };
                    if (employeeEntity.LastName != null && employeeEntity.FirstName != null)
                    {
                        employeelog.Add(employeeEntity);
                    }
                    return RedirectToAction("Index");

            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error", ex.Message);
            }
        }




    }
}