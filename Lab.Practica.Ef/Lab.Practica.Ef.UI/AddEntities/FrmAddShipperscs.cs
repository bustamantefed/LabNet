
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
    public partial class FrmAddShipperscs : Form
    {
        public FrmAddShipperscs()
        {
            InitializeComponent();
        }
        private void btnAddNewShippers_Click(object sender, EventArgs e)
        {
            try
            {
                Lab.Practica.Ef.Logic.ShippersLogic newShipper = new Lab.Practica.Ef.Logic.ShippersLogic();               
                newShipper.Add(new Entities.Shippers
                {
                    CompanyName = txtCompanyNameShippers.Text,
                    Phone = txtPhoneShipper.Text
                });
                MessageBox.Show("Transportista agregado correctamente.", "Agregado de transportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (PersonalizedException ex)
            {
                MessageBox.Show(ex.Message, "Error al ingresar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }
        private void txtPhoneShipper_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números se permite ingresar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void txtIDShipper_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números se permite ingresar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void FrmAddShipperscs_Load(object sender, EventArgs e)
        {

        }
    }
}
