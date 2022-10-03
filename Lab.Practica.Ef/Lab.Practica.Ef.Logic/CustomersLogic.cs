using Lab.Practica.Ef.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Practica.Ef.Logic
{
    public class CustomersLogic : BaseLogic, IABM<Customers>
    {
        public void Add(Customers AddNew)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customers> Filter(string a)
        {
            throw new NotImplementedException();
        }

        public List<Customers> GetAll()
        {
            return context.Customers.ToList();
        }

        public void Update(Customers updateT)
        {
            throw new NotImplementedException();
        }
    }
}
