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
    public partial class ModifySuppliers : Form
    {
        public ModifySuppliers()
        {
            InitializeComponent();
        }
        private void btnModifySuppliers_Click(object sender, EventArgs e)
        {
            try
            {
                Lab.Practica.Ef.Logic.SuppliersLogic ModSupplier = new Lab.Practica.Ef.Logic.SuppliersLogic();
                ModSupplier.Update(new Entities.Suppliers
                {
                    SupplierID = Convert.ToInt32(lblIdSuppliers.Text),
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
                MessageBox.Show("Proveedores modificado correctamente.", "Modificado de Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
              
            }       
        }
    }
}
