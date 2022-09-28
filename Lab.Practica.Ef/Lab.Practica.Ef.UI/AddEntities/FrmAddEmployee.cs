using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab.Practica.Ef.UI;

namespace Lab.Practica.Ef.UI
{
    public partial class FrmAddEmployee : Form
    {
        public FrmAddEmployee()
        {
            InitializeComponent();
        }
        private void FrmAddEmployee_Load(object sender, EventArgs e)
        {

        }
        private void btnAddNewEmployeed_Click(object sender, EventArgs e)
        {
            Lab.Practica.Ef.Logic.EmployeesLogic newEmployeer = new Lab.Practica.Ef.Logic.EmployeesLogic();
            newEmployeer.Add(new Entities.Employees
            {
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
            }) ;
            MessageBox.Show("Empleado agregado correctamente.", "Agregado de empleados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();            
        }

        private void txtPhoneEmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números se permite ingresar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCodePostalEmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números se permite ingresar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
