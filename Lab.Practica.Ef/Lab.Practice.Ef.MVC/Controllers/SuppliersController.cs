using Lab.Practica.Ef.Entities;
using Lab.Practica.Ef.Logic;
using Lab.Practice.Ef.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.Practice.Ef.MVC.Controllers
{

    //public int SupplierID { get; set; }
    //public string CompanyName { get; set; }
    //public string ContactName { get; set; }
    //public string ContactTitle { get; set; }
    //public string Address { get; set; }
    //public string City { get; set; }
    //public string Region { get; set; }
    //public string PostalCode { get; set; }
    //public string Country { get; set; }
    //public string Phone { get; set; }
    public class SuppliersController : Controller
    {
        SuppliersLogic supplierslog = new SuppliersLogic();
        // GET: Suppliers
        public ActionResult Index()
        {
 
            List<Lab.Practica.Ef.Entities.Suppliers> Supplier = supplierslog.GetAll();

            List<SuppliersView> SupplierView = Supplier.Select(s => new SuppliersView
            {
              SupplierID = s.SupplierID,
              CompanyName = s.CompanyName,
              ContactTitle = s.ContactTitle,
              ContactName = s.ContactName,
              Address = s.Address,
              City = s.City,
              PostalCode = s.PostalCode,
              Country = s.Country,
              Phone= s.Phone
            }).ToList();
            return View(SupplierView);
        }

        public ActionResult Edit(Suppliers supId)
        {
            try
            {
                supplierslog.Update(supId);

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
                    supplierslog.Delete(id);

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
        public ActionResult InsertEmployee(SuppliersView sView)
        {

            try
            {      
                 Suppliers supEntity = new Suppliers
                {
                  CompanyName = sView.CompanyName,
                  ContactName = sView.ContactName,
                  ContactTitle = sView.ContactTitle,
                  Address = sView.Address,
                  City = sView.City,
                  PostalCode = sView.PostalCode,
                  Country = sView.Country,
                  Phone = sView.Phone
                };
                if (supEntity.CompanyName != null )
                {
                    supplierslog.Add(supEntity);
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