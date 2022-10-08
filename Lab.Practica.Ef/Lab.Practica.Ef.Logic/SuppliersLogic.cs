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
            try
            {
                context.Suppliers.Add(AddNew);
                context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
           
        }
        public void Delete(int id)
        {
            try
            {
                var suppliersDeleted = context.Suppliers.Find(id);
                context.Suppliers.Remove(suppliersDeleted);
                context.SaveChanges();
            }
            catch (Exception)
            {

                return;
            }
            
        }
        public void Update(Suppliers updateT)
        {
            try
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
            catch (Exception)
            {

                throw;
            }
            
        }
        public List<Suppliers> GetAll()
        {
            try
            {
                return context.Suppliers.ToList();
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        public Suppliers  GetById(int id)
        {
            try
            {
                return context.Suppliers.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public List<Suppliers> Filter(string a)
        {
            try
            {
                return context.Suppliers.Where(x => x.CompanyName.Contains(a)).ToList();
            }
            catch (Exception)
            {

                throw;
            }
           
        }
    }


}
