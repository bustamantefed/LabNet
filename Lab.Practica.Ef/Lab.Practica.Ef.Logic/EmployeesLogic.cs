using Lab.Practica.Ef.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using Lab.Practica.Ef.Data;

namespace Lab.Practica.Ef.Logic
{
    public class EmployeesLogic : BaseLogic, IABM<Employees>
    {


        public List<Employees> GetAll()
        {        
                return context.Employees.ToList();            
        }

        public void Add(Employees AddNew)
        {
            try
            {
                context.Employees.Add(AddNew);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        public void Update(Employees updateT)
        {
            var modifyEmployee = context.Employees.Find(updateT.EmployeeID);
            modifyEmployee.LastName = updateT.LastName;
            modifyEmployee.FirstName = updateT.FirstName;
            modifyEmployee.Title = updateT.Title;
            modifyEmployee.BirthDate = updateT.BirthDate;
            modifyEmployee.HireDate = updateT.HireDate;
            modifyEmployee.Address = updateT.Address;
            modifyEmployee.City = updateT.City;
            modifyEmployee.Region = updateT.Region;
            modifyEmployee.PostalCode = updateT.PostalCode;
            modifyEmployee.Country = updateT.Country;
            modifyEmployee.HomePhone = updateT.HomePhone;

            context.SaveChanges();
        }
        public void Delete(int id)
        {
                var employeesDeleted = context.Employees.Find(id);
                context.Employees.Remove(employeesDeleted);
                context.SaveChanges();
        }

        public List<Employees> Filter(string a )
        {
            return context.Employees.Where(x => x.FirstName.Contains(a)).ToList();
        }

        public void GetById(int id)
        {
            context.Employees.Find(id);
        }
    }
}

 
