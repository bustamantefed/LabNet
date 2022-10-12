using Lab.Practica.Ef.Entities;
using Lab.Practica.Ef.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Practice.Service
{
    public class SupplierService
    {
        SuppliersLogic sl = new SuppliersLogic();

        public List<Suppliers> GetSupplier()
        {
            return sl.GetAll();
        }
    }
}
