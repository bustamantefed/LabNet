using Lab.Practica.Ef.Entities;
using Lab.Practica.Ef.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Practice.Service
{
    public class ShipperService
    {
        ShippersLogic sl = new ShippersLogic();

        public List<Shippers> GetShipper()
        {
            return sl.GetAll();
        }


    }
}
