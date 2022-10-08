using Lab.Practica.Ef.Data;
using Lab.Practica.Ef.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Practica.Ef.Logic
{
    public class ShippersLogic : BaseLogic, IABM<Shippers>
    {
    
        public List<Shippers> GetAll()
        {
            try
            {
                return context.Shippers.ToList();
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        public void Add(Shippers AddNew)
        {
            try
            {
                context.Shippers.Add(AddNew);
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
                var shippersDeleted = context.Shippers.Find(id);
                context.Shippers.Remove(shippersDeleted);
                context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        
        }
        public void Update(Shippers updateT)
        {
            try
            {
                var modifyShipper = context.Shippers.Find(updateT.ShipperID);
                modifyShipper.CompanyName = updateT.CompanyName;
                modifyShipper.Phone = updateT.Phone;
                context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public List<Shippers> Filter(string a)
        {
            try
            {
                return context.Shippers.Where(x => x.CompanyName.Contains(a)).ToList();
            }
            catch (Exception)
            {

                throw;
            }
         
        }
    }
}
