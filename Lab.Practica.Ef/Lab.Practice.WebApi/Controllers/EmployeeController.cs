using Lab.Practica.Ef.Entities;
using Lab.Practica.Ef.Logic;
using Lab.Practice.Service;
using Lab.Practice.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

using System.Web.Http;

namespace Lab.Practice.WebApi.Controllers
{
    public class EmployeeController : ApiController
    {
       
        private EmployeeService _employeservice;

        public EmployeeService EmployeeService
        {
            get
            {
                if (_employeservice == null)
                {
                    _employeservice = new EmployeeService();
                }
                return _employeservice;
            }
        }

        // GET: api/Employee
        public IHttpActionResult GetEmployee()
        {
            List<Employees> emp = EmployeeService.GetEmployee();
            try
            {
                List<Employees> listEmployee = emp.Select(e => new Employees
                {
                    EmployeeID = e.EmployeeID,
                    LastName = e.LastName,
                    FirstName = e.FirstName,
                    Title = e.Title,
                    TitleOfCourtesy = e.TitleOfCourtesy,
                    BirthDate = e.BirthDate,
                    HireDate = e.HireDate, 
                    Address = e.Address,
                    City = e.City,
                    Region = e.Region,
                    PostalCode = e.PostalCode,
                    Country = e.Country,
                    HomePhone = e.HomePhone
                }).ToList();

                return Ok(listEmployee);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest,ex);
            }
        }

        //POST: api/Employee
        [HttpPost]
        public IHttpActionResult AddEmployee([FromBody] EmployeeRequest e)
        {
            try
                {
                Employees addemp = new Employees
                {
                    LastName = e.LastName,
                    FirstName = e.FirstName,
                    Title = e.Tittle
                };
                this.EmployeeService.Addemployee(addemp);
                return Content(HttpStatusCode.Created, addemp); 

            }
            catch (Exception ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.Message);
            }
        }



        //DELETE: api/Employee/{34}
        [HttpDelete]
        public IHttpActionResult Delete(int e)
        {

               this.EmployeeService.DeleteEmployee(e);               
                return Ok();
        }
        // EmployeesLogic El = new EmployeesLogic();
        //                this.El.Delete(e);



        //PUT: api/Employee{id}
        [HttpPut]
        public IHttpActionResult Edit ([FromBody] EmployeeRequest e)
        {

            Employees emp = new Employees();                     
            EmployeeService.GetById(e.id);
            Employees listEmployee = new Employees
            {
                EmployeeID = e.id,
                LastName = e.LastName,
                FirstName = e.FirstName,
                Title = e.Tittle
            };
            return Ok(listEmployee);
        }
    }
}