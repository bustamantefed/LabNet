using Lab.Practica.Ef.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Practica.Ef.Logic
{
    public class SuppliersLogic : BaseLogic, IABM<Suppliers>
    {
        public void Add(Suppliers AddNew)
        {
            context.Suppliers.Add(AddNew);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            var suppliersDeleted = context.Suppliers.Find(id);
            context.Suppliers.Remove(suppliersDeleted);
            context.SaveChanges();
        }
        public void Update(Suppliers updateT)
        {    
            var modifySuppliers = context.Suppliers.Find(updateT.SupplierID);
            modifySuppliers.CompanyName = updateT.CompanyName;
            modifySuppliers.ContactName = updateT.ContactName;
            modifySuppliers.ContactTitle = updateT.ContactTitle;
            modifySuppliers.Address = updateT.Address;
            modifySuppliers.City = updateT.City;
            modifySuppliers.Region = updateT.Region;
            modifySuppliers.PostalCode = updateT.PostalCode;
            modifySuppliers.Country = updateT.Country;
            modifySuppliers.Phone = updateT.Phone;
            modifySuppliers.Fax = updateT.Fax;
            modifySuppliers.HomePage = updateT.HomePage;
            context.SaveChanges();
        }
        public List<Suppliers> GetAll()
        {
            return context.Suppliers.ToList();
        }

        public Suppliers  GetById(int id)
        {
            return context.Suppliers.Find(id);
        }

        public List<Suppliers> Filter(string a)
        {
            return context.Suppliers.Where(x => x.CompanyName.Contains(a)).ToList();
        }
    }
}
