using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab.Practica.Ef.UI.ModifyEntities
{
    public partial class ModifyEmployee : Form
    {
        public ModifyEmployee()
        {
            InitializeComponent();
        }
        private void btnModifyNewEmployeed_Click(object sender, EventArgs e)
        {
      
            Lab.Practica.Ef.Logic.EmployeesLogic ModEmployeer = new Lab.Practica.Ef.Logic.EmployeesLogic();      
            ModEmployeer.Update(new Entities.Employees
            {  
                EmployeeID = Convert.ToInt32(lblIdEmployee.Text),
                LastName = txtLastNameEmp.Text,
                FirstName = txtFirstNameEmp.Text,
                Title = txtTittleEmp.Text,
                BirthDate = dtpBirthdayEmp.Value,
                HireDate = dtpHireDateEmp.Value,
                Address = txtAdressEmp.Text,
                Country = txtCountryEmp.Text,
                City = txtCityEmp.Text,
                Region = txtRegionEmp.Text,
                PostalCode = txtCodePostalEmp.Text,
                HomePhone = txtPhoneEmp.Text
            });
            MessageBox.Show("Empleado modificado correctamente.", "Modificado de empleados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void ModifyEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
