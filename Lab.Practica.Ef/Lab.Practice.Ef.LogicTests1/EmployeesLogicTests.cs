using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab.Practica.Ef.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Practica.Ef.Logic.Tests
{
    [TestClass()]
    public class EmployeesLogicTests
    {
        [TestMethod()]
        public void DeleteTest()
        {
            EmployeesLogic logicTest = new EmployeesLogic();
            int  number= 1;
            logicTest.Delete(number);


            Assert.Fail();
        }
    }
}