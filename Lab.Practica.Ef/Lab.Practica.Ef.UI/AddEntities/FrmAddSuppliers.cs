using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab.Practica.Ef.UI
{
    public partial class FrmAddSuppliers : Form
    {
        public FrmAddSuppliers()
        {
            InitializeComponent();
        }
        private void FrmAddSuppliers_Load(object sender, EventArgs e)
        {

        }

        private void btnAddSuppliers_Click(object sender, EventArgs e)
        {
            Lab.Practica.Ef.Logic.SuppliersLogic newSupplier = new Lab.Practica.Ef.Logic.SuppliersLogic();
            newSupplier.Add(new Entities.Suppliers
            {
                CompanyName = txtCompanyNameSupp.Text,
                ContactName = txtContactNameSupp.Text,
                ContactTitle = txtContactTitleSupp.Text,
                Address = txtAdressSupp.Text,
                City = txtCitySupp.Text,
                Region = txtRegionSupp.Text,
                PostalCode = txtPostalCodeSupp.Text,
                Country = txtCountrySupp.Text,
                Phone = txtPhoneSupp.Text,
                Fax = txtFaxSupp.Text,
                HomePage = txtHomePageSupp.Text
            });
            MessageBox.Show("Proveedores agregado correctamente.", "Agregado de Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void txtPhoneSupp_KeyPress(object sender, KeyPressEventArgs e)
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
