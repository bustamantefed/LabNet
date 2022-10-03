
namespace Lab.Practica.Ef.UI
{
    partial class FrmLiqn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLiqn));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_Query10 = new System.Windows.Forms.Button();
            this.btn_Query11 = new System.Windows.Forms.Button();
            this.btn_Query12 = new System.Windows.Forms.Button();
            this.btn_Query13 = new System.Windows.Forms.Button();
            this.btn_Query9 = new System.Windows.Forms.Button();
            this.btn_Query8 = new System.Windows.Forms.Button();
            this.btn_Query7 = new System.Windows.Forms.Button();
            this.btn_Query6 = new System.Windows.Forms.Button();
            this.btn_Query5 = new System.Windows.Forms.Button();
            this.btn_Query4 = new System.Windows.Forms.Button();
            this.btn_Query3 = new System.Windows.Forms.Button();
            this.btn_Query2 = new System.Windows.Forms.Button();
            this.btn_Query1 = new System.Windows.Forms.Button();
            this.dgvQuerys = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuerys)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_Query10);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Query11);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Query12);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Query13);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Query9);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Query8);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Query7);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Query6);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Query5);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Query4);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Query3);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Query2);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Query1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvQuerys);
            this.splitContainer1.Size = new System.Drawing.Size(870, 431);
            this.splitContainer1.SplitterDistance = 190;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_Query10
            // 
            this.btn_Query10.Location = new System.Drawing.Point(556, 12);
            this.btn_Query10.Name = "btn_Query10";
            this.btn_Query10.Size = new System.Drawing.Size(197, 23);
            this.btn_Query10.TabIndex = 11;
            this.btn_Query10.Text = "10- Productos ordenados por stock";
            this.btn_Query10.UseVisualStyleBackColor = true;
            this.btn_Query10.Click += new System.EventHandler(this.btn_Query10_Click);
            // 
            // btn_Query11
            // 
            this.btn_Query11.Location = new System.Drawing.Point(556, 42);
            this.btn_Query11.Name = "btn_Query11";
            this.btn_Query11.Size = new System.Drawing.Size(197, 23);
            this.btn_Query11.TabIndex = 10;
            this.btn_Query11.Text = "11- Categorias asociadas a productos";
            this.btn_Query11.UseVisualStyleBackColor = true;
            this.btn_Query11.Click += new System.EventHandler(this.btn_Query11_Click);
            // 
            // btn_Query12
            // 
            this.btn_Query12.Location = new System.Drawing.Point(556, 71);
            this.btn_Query12.Name = "btn_Query12";
            this.btn_Query12.Size = new System.Drawing.Size(197, 23);
            this.btn_Query12.TabIndex = 2;
            this.btn_Query12.Text = "12- Primer elemento lista productos";
            this.btn_Query12.UseVisualStyleBackColor = true;
            this.btn_Query12.Click += new System.EventHandler(this.btn_Query12_Click);
            // 
            // btn_Query13
            // 
            this.btn_Query13.Location = new System.Drawing.Point(556, 100);
            this.btn_Query13.Name = "btn_Query13";
            this.btn_Query13.Size = new System.Drawing.Size(197, 23);
            this.btn_Query13.TabIndex = 9;
            this.btn_Query13.Text = "13- Customers con ordenes asociadas";
            this.btn_Query13.UseVisualStyleBackColor = true;
            this.btn_Query13.Click += new System.EventHandler(this.btn_Query13_Click);
            // 
            // btn_Query9
            // 
            this.btn_Query9.Location = new System.Drawing.Point(322, 100);
            this.btn_Query9.Name = "btn_Query9";
            this.btn_Query9.Size = new System.Drawing.Size(215, 23);
            this.btn_Query9.TabIndex = 8;
            this.btn_Query9.Text = "9- Lista productos ordernados por nombre";
            this.btn_Query9.UseVisualStyleBackColor = true;
            this.btn_Query9.Click += new System.EventHandler(this.btn_Query9_Click);
            // 
            // btn_Query8
            // 
            this.btn_Query8.Location = new System.Drawing.Point(322, 71);
            this.btn_Query8.Name = "btn_Query8";
            this.btn_Query8.Size = new System.Drawing.Size(215, 23);
            this.btn_Query8.TabIndex = 7;
            this.btn_Query8.Text = "8- Primeros 3 customers region WA";
            this.btn_Query8.UseVisualStyleBackColor = true;
            this.btn_Query8.Click += new System.EventHandler(this.btn_Query8_Click);
            // 
            // btn_Query7
            // 
            this.btn_Query7.Location = new System.Drawing.Point(322, 42);
            this.btn_Query7.Name = "btn_Query7";
            this.btn_Query7.Size = new System.Drawing.Size(215, 23);
            this.btn_Query7.TabIndex = 6;
            this.btn_Query7.Text = "7- Join customers y orders";
            this.btn_Query7.UseVisualStyleBackColor = true;
            this.btn_Query7.Click += new System.EventHandler(this.btn_Query7_Click);
            // 
            // btn_Query6
            // 
            this.btn_Query6.Location = new System.Drawing.Point(322, 12);
            this.btn_Query6.Name = "btn_Query6";
            this.btn_Query6.Size = new System.Drawing.Size(215, 23);
            this.btn_Query6.TabIndex = 5;
            this.btn_Query6.Text = "6- Nombres customers";
            this.btn_Query6.UseVisualStyleBackColor = true;
            this.btn_Query6.Click += new System.EventHandler(this.btn_Query6_Click);
            // 
            // btn_Query5
            // 
            this.btn_Query5.Location = new System.Drawing.Point(91, 129);
            this.btn_Query5.Name = "btn_Query5";
            this.btn_Query5.Size = new System.Drawing.Size(197, 23);
            this.btn_Query5.TabIndex = 4;
            this.btn_Query5.Text = "5- Lista producto igual a 789 o nulo";
            this.btn_Query5.UseVisualStyleBackColor = true;
            this.btn_Query5.Click += new System.EventHandler(this.btn_Query5_Click);
            // 
            // btn_Query4
            // 
            this.btn_Query4.Location = new System.Drawing.Point(91, 100);
            this.btn_Query4.Name = "btn_Query4";
            this.btn_Query4.Size = new System.Drawing.Size(197, 23);
            this.btn_Query4.TabIndex = 3;
            this.btn_Query4.Text = "4- Customers con region WA";
            this.btn_Query4.UseVisualStyleBackColor = true;
            this.btn_Query4.Click += new System.EventHandler(this.btn_Query4_Click);
            // 
            // btn_Query3
            // 
            this.btn_Query3.Location = new System.Drawing.Point(91, 71);
            this.btn_Query3.Name = "btn_Query3";
            this.btn_Query3.Size = new System.Drawing.Size(197, 23);
            this.btn_Query3.TabIndex = 2;
            this.btn_Query3.Text = "3- Productos con stock + 3 de unidad";
            this.btn_Query3.UseVisualStyleBackColor = true;
            this.btn_Query3.Click += new System.EventHandler(this.btn_Query3_Click);
            // 
            // btn_Query2
            // 
            this.btn_Query2.Location = new System.Drawing.Point(91, 42);
            this.btn_Query2.Name = "btn_Query2";
            this.btn_Query2.Size = new System.Drawing.Size(197, 23);
            this.btn_Query2.TabIndex = 1;
            this.btn_Query2.Text = "2- Productos sin stock";
            this.btn_Query2.UseVisualStyleBackColor = true;
            this.btn_Query2.Click += new System.EventHandler(this.btn_Query2_Click);
            // 
            // btn_Query1
            // 
            this.btn_Query1.Location = new System.Drawing.Point(91, 12);
            this.btn_Query1.Name = "btn_Query1";
            this.btn_Query1.Size = new System.Drawing.Size(197, 23);
            this.btn_Query1.TabIndex = 0;
            this.btn_Query1.Text = "1- Objeto customer";
            this.btn_Query1.UseVisualStyleBackColor = true;
            this.btn_Query1.Click += new System.EventHandler(this.btn_Query1_Click);
            // 
            // dgvQuerys
            // 
            this.dgvQuerys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuerys.Location = new System.Drawing.Point(0, 3);
            this.dgvQuerys.Name = "dgvQuerys";
            this.dgvQuerys.Size = new System.Drawing.Size(860, 222);
            this.dgvQuerys.TabIndex = 0;
            // 
            // FrmLiqn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 431);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLiqn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas LINQ - Bustamante Federico";
            this.Load += new System.EventHandler(this.FrmLiqn_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuerys)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_Query10;
        private System.Windows.Forms.Button btn_Query11;
        private System.Windows.Forms.Button btn_Query12;
        private System.Windows.Forms.Button btn_Query13;
        private System.Windows.Forms.Button btn_Query9;
        private System.Windows.Forms.Button btn_Query8;
        private System.Windows.Forms.Button btn_Query7;
        private System.Windows.Forms.Button btn_Query6;
        private System.Windows.Forms.Button btn_Query5;
        private System.Windows.Forms.Button btn_Query4;
        private System.Windows.Forms.Button btn_Query3;
        private System.Windows.Forms.Button btn_Query2;
        private System.Windows.Forms.Button btn_Query1;
        public System.Windows.Forms.DataGridView dgvQuerys;
    }
}