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
            return context.Shippers.ToList();
        }
        public void Add(Shippers AddNew)
        {
            context.Shippers.Add(AddNew);
            context.SaveChanges();
        }
        public void Delete(int id)
        {

            var shippersDeleted = context.Shippers.Find(id);
            context.Shippers.Remove(shippersDeleted);
            context.SaveChanges();
        }
        public void Update(Shippers updateT)
        {
            var modifyShipper = context.Shippers.Find(updateT.ShipperID);
            modifyShipper.CompanyName = updateT.CompanyName;
            modifyShipper.Phone = updateT.Phone;
            context.SaveChanges();
        }

        public List<Shippers> Filter(string a)
        {
            return context.Shippers.Where(x => x.CompanyName.Contains(a)).ToList();
        }
    }
}
