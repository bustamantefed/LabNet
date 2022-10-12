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
    public class ShipperController : ApiController
    {
        private ShipperService _shipperService;

        public ShipperService ShipperService
        {
            get
            {
                if (_shipperService == null)
                {
                    _shipperService = new ShipperService();
                }
                return _shipperService;
            }
        }

        // GET: api/Shipper
        public IHttpActionResult GetShipper()
        {
            List<Shippers> shp = ShipperService.GetShipper();
            try
            {
                List<Shippers> listshipper = shp.Select(s => new Shippers
                {
                    ShipperID = s.ShipperID,
                    CompanyName = s.CompanyName,
                    Phone = s.Phone
                }).ToList();

                return Ok(listshipper);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}