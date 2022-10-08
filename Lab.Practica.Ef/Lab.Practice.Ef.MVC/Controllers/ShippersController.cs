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
    public class ShippersController : Controller
    {
        ShippersLogic shipperslog = new ShippersLogic();
        // GET: Shippers
        public ActionResult Index()
        {
            var shipperslog = new ShippersLogic();
            List<Lab.Practica.Ef.Entities.Shippers> shipper = shipperslog.GetAll();

            List<ShippersView> ShipperView = shipper.Select(s => new ShippersView
            {
                Id = s.ShipperID, 
                CompanyName = s.CompanyName,
                Phone = s.Phone

            }).ToList();
            return View(ShipperView);
        }

        public ActionResult InsertShippers()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InsertShippers(ShippersView shipView)
        {

            try
            {
                Shippers shippereEntity = new Shippers
                {
                    ShipperID = shipView.Id,
                    CompanyName = shipView.CompanyName,
                    Phone = shipView.Phone

                };
                if (shippereEntity.CompanyName != null)
                {
                    shipperslog.Add(shippereEntity);
                }
                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error", ex.Message);
            }
        }

        public ActionResult Edit(Shippers ship)
        {
            try
            {
                shipperslog.Update(ship);

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
                    shipperslog.Delete(id);

                    return RedirectToAction("Index");
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