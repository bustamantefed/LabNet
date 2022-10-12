using Lab.Practica.Ef.Entities;
using Lab.Practice.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Lab.Practice.WebApi.Controllers
{
    public class SupplierController : ApiController
    {
        // GET: Supplier
        private SupplierService _supplierservice;

        public SupplierService EmployeeService
        {
            get
            {
                if (_supplierservice == null)
                {
                    _supplierservice = new SupplierService();
                }
                return _supplierservice;
            }
        }

        // GET: api/Supplier
        public IHttpActionResult GetSupplier()
        {
            List<Suppliers> supp = EmployeeService.GetSupplier();
            try
            {
                List<Suppliers> listsuppliers = supp.Select(s => new Suppliers
                {
                   SupplierID = s.SupplierID ,
                   CompanyName = s.CompanyName,
                   ContactName = s.ContactName,
                   ContactTitle = s.ContactTitle,
                   Address = s.Address,
                   City = s.City,
                   Region = s.Region,
                   PostalCode = s.PostalCode,
                   Country = s.Country,
                   Phone = s.Phone,
                }).ToList();

                return Ok(listsuppliers);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex);
            }
        }

    }
}