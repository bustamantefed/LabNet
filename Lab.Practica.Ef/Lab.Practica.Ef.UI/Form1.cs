using Lab.Practica.Ef.UI.ModifyEntities;
using System;
using System.Windows.Forms;

namespace Lab.Practica.Ef.UI
{
    public partial class Form1 : Form
    {
        string UserPressTxt = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtIdEmployeer.Text = "Ingrese ID a eliminar...";
            txtIdShippers.Text = "Ingrese ID a eliminar...";
            txtIdSuppliers.Text = "Ingrese ID a eliminar...";
        }

        #region Adds Employeers, Shippers, Suppliers.
        private void btnAddEmployees_Click(object sender, EventArgs e)
        {
            FrmAddEmployee frmEmployeed = new FrmAddEmployee();
            frmEmployeed.ShowDialog();
            Lab.Practica.Ef.Logic.EmployeesLogic AllEmployees = new Lab.Practica.Ef.Logic.EmployeesLogic();
            dgvListAll.DataSource = AllEmployees.GetAll();
        }

        private void btnAddShippers_Click(object sender, EventArgs e)
        {
            FrmAddShipperscs frmShippers = new FrmAddShipperscs();
            frmShippers.ShowDialog();
            Lab.Practica.Ef.Logic.ShippersLogic AllShippers = new Lab.Practica.Ef.Logic.ShippersLogic();
            dgvListAll.DataSource = AllShippers.GetAll();
        }

        private void btnAddSuppliers_Click(object sender, EventArgs e)
        {
            FrmAddSuppliers frmSuppliers = new FrmAddSuppliers();
            frmSuppliers.ShowDialog();
            Lab.Practica.Ef.Logic.SuppliersLogic AllSuppliers = new Lab.Practica.Ef.Logic.SuppliersLogic();
            dgvListAll.DataSource = AllSuppliers.GetAll();
        }
        #endregion

        #region Show alls employeers, shippers, suppliers.

        private void btnAllEmployees_Click(object sender, EventArgs e)
        {
            Lab.Practica.Ef.Logic.EmployeesLogic AllEmployees = new Lab.Practica.Ef.Logic.EmployeesLogic();
            dgvListAll.DataSource = AllEmployees.GetAll();
            btnModifyEmployee.Enabled = true;
            btnModifyShippers.Enabled = false;
            btnModifySuppliers.Enabled = false;
            btnDeleteShippers.Enabled = false;
            btnDeleteSuppliers.Enabled = false;
            btnDeleteEmployee.Enabled = true;
        }

        private void btnAllShippers_Click(object sender, EventArgs e)
        {
            Lab.Practica.Ef.Logic.ShippersLogic AllShippers = new Lab.Practica.Ef.Logic.ShippersLogic();
            dgvListAll.DataSource = AllShippers.GetAll();
            btnModifyShippers.Enabled = true;
            btnModifyEmployee.Enabled = false;
            btnModifySuppliers.Enabled = false;
            btnDeleteSuppliers.Enabled = false;
            btnDeleteEmployee.Enabled = false;
            btnDeleteShippers.Enabled = true;
        }

        private void btnAllSuppliers_Click(object sender, EventArgs e)
        {
            Lab.Practica.Ef.Logic.SuppliersLogic AllSuppliers = new Lab.Practica.Ef.Logic.SuppliersLogic();
            dgvListAll.DataSource = AllSuppliers.GetAll();
            btnModifySuppliers.Enabled = true;
            btnDeleteSuppliers.Enabled = true;
            btnModifyEmployee.Enabled = false;
            btnModifyShippers.Enabled = false;
            btnDeleteEmployee.Enabled = false;
            btnDeleteShippers.Enabled = false;
        }

        #endregion

        #region Modify employeers,Shippers, suppliers.


        private void btnModifyEmployee_Click(object sender, EventArgs e)
        {
            string cityNull = "Campo vacio.";
            string regionNull = "Campo vacio.";
            if (dgvListAll.SelectedRows.Count > 0)
            {
                ModifyEmployee frmEditEmployee = new ModifyEmployee();
                frmEditEmployee.lblIdEmployee.Text = dgvListAll.CurrentRow.Cells[0].Value.ToString();
                frmEditEmployee.txtLastNameEmp.Text = dgvListAll.CurrentRow.Cells[1].Value.ToString();
                frmEditEmployee.txtFirstNameEmp.Text = dgvListAll.CurrentRow.Cells[2].Value.ToString();
                frmEditEmployee.txtTittleEmp.Text = dgvListAll.CurrentRow.Cells[3].Value.ToString();
                frmEditEmployee.dtpBirthdayEmp.Text = dgvListAll.CurrentRow.Cells[5].Value.ToString();
                frmEditEmployee.dtpHireDateEmp.Text = dgvListAll.CurrentRow.Cells[6].Value.ToString();
                frmEditEmployee.txtAdressEmp.Text = dgvListAll.CurrentRow.Cells[7].Value.ToString();

                if (dgvListAll.CurrentRow.Cells[8].Value == null)
                {
                    frmEditEmployee.txtCityEmp.Text = cityNull;
                }
                else
                {
                    frmEditEmployee.txtCityEmp.Text = dgvListAll.CurrentRow.Cells[8].Value.ToString();
                }

                if (dgvListAll.CurrentRow.Cells[9].Value == null)
                {
                    frmEditEmployee.txtRegionEmp.Text = regionNull;
                }
                else
                {
                    frmEditEmployee.txtRegionEmp.Text = dgvListAll.CurrentRow.Cells[9].Value.ToString();
                }


                frmEditEmployee.txtCodePostalEmp.Text = dgvListAll.CurrentRow.Cells[10].Value.ToString();

                frmEditEmployee.txtCountryEmp.Text = dgvListAll.CurrentRow.Cells[11].Value.ToString();

                frmEditEmployee.txtPhoneEmp.Text = dgvListAll.CurrentRow.Cells[12].Value.ToString();
                frmEditEmployee.ShowDialog();
                Lab.Practica.Ef.Logic.EmployeesLogic AllEmployees = new Lab.Practica.Ef.Logic.EmployeesLogic();
                dgvListAll.DataSource = AllEmployees.GetAll();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila para modificar un empleado.");
            }
        }

        private void btnModifyShippers_Click(object sender, EventArgs e)
        {
            if (dgvListAll.SelectedRows.Count > 0)
            {
                FrmModifyShipper frmEditShippers = new FrmModifyShipper();
                frmEditShippers.lblIdShipper.Text = dgvListAll.CurrentRow.Cells[0].Value.ToString();
                frmEditShippers.txtCompanyNameShippers.Text = dgvListAll.CurrentRow.Cells[1].Value.ToString();
                frmEditShippers.txtPhoneShipper.Text = dgvListAll.CurrentRow.Cells[2].Value.ToString();
                frmEditShippers.ShowDialog();
                Lab.Practica.Ef.Logic.ShippersLogic AllShippers = new Lab.Practica.Ef.Logic.ShippersLogic();
                dgvListAll.DataSource = AllShippers.GetAll();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila para modificar un transportista.");
            }
        }

        private void btnModifySuppliers_Click(object sender, EventArgs e)
        {
            if (dgvListAll.SelectedRows.Count > 0)
            {
                string RegionNull = "Campo vacio.";
                string FaxNull = "Campo vacio.";
                string HomePageNull = "Campo vacio.";

                ModifySuppliers frmModifySuppliers = new ModifySuppliers();
                frmModifySuppliers.lblIdSuppliers.Text = dgvListAll.CurrentRow.Cells[0].Value.ToString();
                frmModifySuppliers.txtCompanyNameSupp.Text = dgvListAll.CurrentRow.Cells[1].Value.ToString();
                frmModifySuppliers.txtContactNameSupp.Text = dgvListAll.CurrentRow.Cells[2].Value.ToString();
                frmModifySuppliers.txtContactTitleSupp.Text = dgvListAll.CurrentRow.Cells[3].Value.ToString();
                frmModifySuppliers.txtAdressSupp.Text = dgvListAll.CurrentRow.Cells[4].Value.ToString();
                frmModifySuppliers.txtCitySupp.Text = dgvListAll.CurrentRow.Cells[5].Value.ToString();
                if (dgvListAll.CurrentRow.Cells[6].Value == null)
                {
                    frmModifySuppliers.txtRegionSupp.Text = RegionNull;
                }
                else
                {
                    frmModifySuppliers.txtRegionSupp.Text = dgvListAll.CurrentRow.Cells[6].Value.ToString();
                }
                frmModifySuppliers.txtPostalCodeSupp.Text = dgvListAll.CurrentRow.Cells[7].Value.ToString();
                frmModifySuppliers.txtCountrySupp.Text = dgvListAll.CurrentRow.Cells[8].Value.ToString();
                frmModifySuppliers.txtPhoneSupp.Text = dgvListAll.CurrentRow.Cells[9].Value.ToString();
                if (dgvListAll.CurrentRow.Cells[10].Value == null)
                {

                    frmModifySuppliers.txtFaxSupp.Text = FaxNull;
                }
                else
                {
                    frmModifySuppliers.txtFaxSupp.Text = dgvListAll.CurrentRow.Cells[10].Value.ToString();
                }
                if (dgvListAll.CurrentRow.Cells[11].Value == null)
                {
                    frmModifySuppliers.txtHomePageSupp.Text = HomePageNull;
                }
                else
                {
                    frmModifySuppliers.txtHomePageSupp.Text = dgvListAll.CurrentRow.Cells[11].Value.ToString();
                }

                frmModifySuppliers.ShowDialog();
                Lab.Practica.Ef.Logic.SuppliersLogic AllSuppliers = new Lab.Practica.Ef.Logic.SuppliersLogic();
                dgvListAll.DataSource = AllSuppliers.GetAll();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila para modificar un transportista.");
            }
        }

        #endregion

        #region Delete employeers,shippers,suppliers

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtIdEmployeer.Text) <= 9)
                {
                    throw new PersonalizedException("Este registro de empleado no se puede eliminar por que esta relacionado con ordenes pendientes..");
                }
                Lab.Practica.Ef.Logic.EmployeesLogic AllEmployees = new Lab.Practica.Ef.Logic.EmployeesLogic();
                AllEmployees.Delete(int.Parse(txtIdEmployeer.Text));
                MessageBox.Show("Seguro desea eliminar al empleado?", "Eliminar empleado", MessageBoxButtons.OKCancel);
                dgvListAll.DataSource = AllEmployees.GetAll();
            }
            catch (PersonalizedException ex)
            {
                MessageBox.Show(ex.Message, "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteShippers_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtIdShippers.Text) <= 3)
                {
                    throw new PersonalizedException("Este registro de transportista no se puede eliminar por que esta relacionado con ordenes pendientes..");
                }
                Lab.Practica.Ef.Logic.ShippersLogic DeletedShippers = new Lab.Practica.Ef.Logic.ShippersLogic();
                DeletedShippers.Delete(Convert.ToInt32(txtIdShippers.Text));
                MessageBox.Show("Seguro desea eliminar al transportista?", "Eliminar transportista", MessageBoxButtons.OKCancel);
                dgvListAll.DataSource = DeletedShippers.GetAll();
            }
            catch (PersonalizedException ex)
            {
                MessageBox.Show(ex.Message, "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteSuppliers_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtIdSuppliers.Text) <= 29)
                {
                    throw new PersonalizedException("Este registro de proveedor no se puede eliminar por que esta relacionado con productos pendientes de entrega..");
                }
                Lab.Practica.Ef.Logic.SuppliersLogic DeletedSuppliers = new Lab.Practica.Ef.Logic.SuppliersLogic();
                DeletedSuppliers.Delete(int.Parse(txtIdSuppliers.Text));
                MessageBox.Show("Seguro desea eliminar al proveedor?", "Eliminar proveedor", MessageBoxButtons.OKCancel);
                dgvListAll.DataSource = DeletedSuppliers.GetAll();
            }
            catch (PersonalizedException ex)
            {
                MessageBox.Show(ex.Message, "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Forms events

        private void txtIdShippers_Enter(object sender, EventArgs e)
        {
            txtIdShippers.Text = "";
        }
        private void txtIdShippers_Leave(object sender, EventArgs e)
        {
            UserPressTxt = txtIdShippers.Text;

            if (UserPressTxt.Equals("Ingrese ID a eliminar..."))
            {
                txtIdShippers.Text = "Ingrese ID a eliminar...";

            }
            else
            {
                if (UserPressTxt.Equals(""))
                {
                    txtIdShippers.Text = "Ingrese ID a eliminar...";
                }
                else
                {
                    txtIdShippers.Text = UserPressTxt;
                }
            }
        }
        private void txtIdSuppliers_Leave(object sender, EventArgs e)
        {
            UserPressTxt = txtIdSuppliers.Text;

            if (UserPressTxt.Equals("Ingrese ID a eliminar..."))
            {
                txtIdSuppliers.Text = "Ingrese ID a eliminar...";

            }
            else
            {
                if (UserPressTxt.Equals(""))
                {
                    txtIdSuppliers.Text = "Ingrese ID a eliminar...";
                }
                else
                {
                    txtIdSuppliers.Text = UserPressTxt;
                }
            }
        }
        private void txtIdSuppliers_Enter(object sender, EventArgs e)
        {
            txtIdSuppliers.Text = "";
        }
        private void txtIdEmployeer_Leave(object sender, EventArgs e)
        {
            UserPressTxt = txtIdEmployeer.Text;

            if (UserPressTxt.Equals("Ingrese ID a eliminar..."))
            {
                txtIdEmployeer.Text = "Ingrese ID a eliminar...";

            }
            else
            {
                if (UserPressTxt.Equals(""))
                {
                    txtIdEmployeer.Text = "Ingrese ID a eliminar...";
                }
                else
                {
                    txtIdEmployeer.Text = UserPressTxt;
                }
            }
        }
        private void txtIdEmployeer_Enter(object sender, EventArgs e)
        {
            txtIdEmployeer.Text = "";
        }

        #endregion

        #region FilterforNames
        private void txtEmployee_TextChanged(object sender, EventArgs e)
        {
            Lab.Practica.Ef.Logic.EmployeesLogic FilterEmployees = new Lab.Practica.Ef.Logic.EmployeesLogic();
            dgvListAll.DataSource = FilterEmployees.Filter(txtEmployee.Text);
            btnDeleteEmployee.Enabled = true;
            btnDeleteShippers.Enabled = false;
            btnDeleteSuppliers.Enabled = false;
            btnModifyEmployee.Enabled = true;
            btnModifyShippers.Enabled = false;
            btnModifySuppliers.Enabled = false;
        }

        private void txtShippers_TextChanged(object sender, EventArgs e)
        {
            Lab.Practica.Ef.Logic.ShippersLogic FilterShippers = new Lab.Practica.Ef.Logic.ShippersLogic();
            dgvListAll.DataSource = FilterShippers.Filter(txtShippers.Text);
            btnDeleteShippers.Enabled = true;
            btnDeleteEmployee.Enabled = false;
            btnDeleteSuppliers.Enabled = false;
            btnModifyEmployee.Enabled = false;
            btnModifyShippers.Enabled = true;
            btnModifySuppliers.Enabled = false;
        }

        private void txtSuppliers_TextChanged(object sender, EventArgs e)
        {
            Lab.Practica.Ef.Logic.SuppliersLogic FilterSuppliers  = new Lab.Practica.Ef.Logic.SuppliersLogic();
            dgvListAll.DataSource = FilterSuppliers.Filter(txtSuppliers.Text);
            btnDeleteEmployee.Enabled = false;
            btnDeleteShippers.Enabled = false;
            btnDeleteSuppliers.Enabled = true;
            btnModifyEmployee.Enabled = false;
            btnModifyShippers.Enabled = false;
            btnModifySuppliers.Enabled = true;
        }
        #endregion
        private void btnExitForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}

