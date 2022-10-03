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
    public partial class FrmLiqn : Form
    {
        Lab.Practica.Ef.Logic.QuerysLogic Allquerys = new Lab.Practica.Ef.Logic.QuerysLogic();
        public FrmLiqn()
        {
            InitializeComponent();
        }
        private void FrmLiqn_Load(object sender, EventArgs e)
        {
            dgvQuerys.Refresh();
        }

        private void btn_Query1_Click(object sender, EventArgs e)
        {
            dgvQuerys.DataSource = Allquerys.QueryObjectCustomers();
        }

        private void btn_Query2_Click(object sender, EventArgs e)
        {
            dgvQuerys.DataSource = Allquerys.ProducsNullStock();
        }

        private void btn_Query3_Click(object sender, EventArgs e)
        {
            dgvQuerys.DataSource = Allquerys.ProducsWithStocktock();
        }

        private void btn_Query4_Click(object sender, EventArgs e)
        {
            dgvQuerys.DataSource = Allquerys.CustomersRegionWA();
        }

        private void btn_Query5_Click(object sender, EventArgs e)
        {
            dgvQuerys.DataSource = Allquerys.ProductID789();
        }

        private void btn_Query6_Click(object sender, EventArgs e)
        {   
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Nombre", typeof(string)));
            var ToUpperAndLower = Allquerys.NameCustomersUpperAndLower();
            foreach (var item in ToUpperAndLower)
            {
                dt.Rows.Add(item.CompanyName.ToUpper());
                dt.Rows.Add(item.CompanyName.ToLower());
            }
            dgvQuerys.DataSource = dt;
        }

        private void btn_Query7_Click(object sender, EventArgs e)
        {
           dgvQuerys.DataSource = Allquerys.JoinCustomersOrders();
        }

        private void btn_Query8_Click(object sender, EventArgs e)
        {
            dgvQuerys.DataSource = Allquerys.Top3WithRegion();
        }

        private void btn_Query9_Click(object sender, EventArgs e)
        {
            dgvQuerys.DataSource = Allquerys.ProductsOrderByName();
        }

        private void btn_Query10_Click(object sender, EventArgs e)
        {
            dgvQuerys.DataSource = Allquerys.OrderByPrice();
        }

        private void btn_Query11_Click(object sender, EventArgs e)
        {
            dgvQuerys.DataSource = Allquerys.CategoryAssociatedWithProduct();
        }

        private void btn_Query12_Click(object sender, EventArgs e)
        {
            //dgvQuerys.DataSource = Allquerys.FirstProduct();
        }

        private void btn_Query13_Click(object sender, EventArgs e)
        {
            dgvQuerys.DataSource = Allquerys.CategoryAssociatedWithProduct();
        }
    }
}
