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
    public partial class FrmModifyShipper : Form
    {
        public FrmModifyShipper()
        {
            InitializeComponent();
        }

        private void btnModifyShippers_Click(object sender, EventArgs e)
        {
            Lab.Practica.Ef.Logic.ShippersLogic newShipper = new Lab.Practica.Ef.Logic.ShippersLogic();
            newShipper.Update(new Entities.Shippers
            {
                ShipperID = Convert.ToInt32(lblIdShipper.Text),
                CompanyName = txtCompanyNameShippers.Text,
                Phone = txtPhoneShipper.Text

            });
            MessageBox.Show("Transportista modificado correctamente.", "Modificado de transportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void FrmModifyShipper_Load(object sender, EventArgs e)
        {

        }
    }
}
