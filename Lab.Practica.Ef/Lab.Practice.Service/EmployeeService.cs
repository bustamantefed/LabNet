using Lab.Practica.Ef.Entities;
using Lab.Practica.Ef.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Practice.Service
{
    public class EmployeeService
    {
        EmployeesLogic el = new EmployeesLogic();

        public List<Employees> GetEmployee()
        {
            return el.GetAll();
        }

        public void   Addemployee(Employees e)
        {
            el.Add(e);
        }

        public void DeleteEmployee(int e)
        {
            el.Delete(e);
        }

        public void EditEmployee(Employees  e)
        {
           el.Update(e);
        }

        public void GetById(int id)
        {
            el.GetById(id);
        }

    } 
}
