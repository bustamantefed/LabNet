
namespace Lab.Practica.Ef.UI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnAllSuppliers = new System.Windows.Forms.Button();
            this.btnAllShippers = new System.Windows.Forms.Button();
            this.btnAllEmployees = new System.Windows.Forms.Button();
            this.txtIdSuppliers = new System.Windows.Forms.TextBox();
            this.txtIdShippers = new System.Windows.Forms.TextBox();
            this.txtIdEmployeer = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnDeleteSuppliers = new System.Windows.Forms.Button();
            this.btnModifySuppliers = new System.Windows.Forms.Button();
            this.btnAddSuppliers = new System.Windows.Forms.Button();
            this.btnDeleteShippers = new System.Windows.Forms.Button();
            this.btnModifyShippers = new System.Windows.Forms.Button();
            this.btnAddShippers = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnModifyEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployees = new System.Windows.Forms.Button();
            this.txtSuppliers = new System.Windows.Forms.TextBox();
            this.txtShippers = new System.Windows.Forms.TextBox();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.lblSuppliers = new System.Windows.Forms.Label();
            this.lblShippers = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.dgvListAll = new System.Windows.Forms.DataGridView();
            this.btnExitForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListAll)).BeginInit();
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
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.splitContainer1.Panel1.Controls.Add(this.btnAllSuppliers);
            this.splitContainer1.Panel1.Controls.Add(this.btnAllShippers);
            this.splitContainer1.Panel1.Controls.Add(this.btnAllEmployees);
            this.splitContainer1.Panel1.Controls.Add(this.txtIdSuppliers);
            this.splitContainer1.Panel1.Controls.Add(this.txtIdShippers);
            this.splitContainer1.Panel1.Controls.Add(this.txtIdEmployeer);
            this.splitContainer1.Panel1.Controls.Add(this.textBox4);
            this.splitContainer1.Panel1.Controls.Add(this.btnDeleteSuppliers);
            this.splitContainer1.Panel1.Controls.Add(this.btnModifySuppliers);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddSuppliers);
            this.splitContainer1.Panel1.Controls.Add(this.btnDeleteShippers);
            this.splitContainer1.Panel1.Controls.Add(this.btnModifyShippers);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddShippers);
            this.splitContainer1.Panel1.Controls.Add(this.btnDeleteEmployee);
            this.splitContainer1.Panel1.Controls.Add(this.btnModifyEmployee);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddEmployees);
            this.splitContainer1.Panel1.Controls.Add(this.txtSuppliers);
            this.splitContainer1.Panel1.Controls.Add(this.txtShippers);
            this.splitContainer1.Panel1.Controls.Add(this.txtEmployee);
            this.splitContainer1.Panel1.Controls.Add(this.lblSuppliers);
            this.splitContainer1.Panel1.Controls.Add(this.lblShippers);
            this.splitContainer1.Panel1.Controls.Add(this.lblEmployee);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvListAll);
            this.splitContainer1.Panel2.Controls.Add(this.btnExitForm);
            this.splitContainer1.Size = new System.Drawing.Size(1027, 434);
            this.splitContainer1.SplitterDistance = 162;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnAllSuppliers
            // 
            this.btnAllSuppliers.FlatAppearance.BorderSize = 0;
            this.btnAllSuppliers.Location = new System.Drawing.Point(639, 130);
            this.btnAllSuppliers.Name = "btnAllSuppliers";
            this.btnAllSuppliers.Size = new System.Drawing.Size(162, 23);
            this.btnAllSuppliers.TabIndex = 173;
            this.btnAllSuppliers.Text = "Mostrar todos los proveedores";
            this.btnAllSuppliers.UseVisualStyleBackColor = true;
            this.btnAllSuppliers.Click += new System.EventHandler(this.btnAllSuppliers_Click);
            // 
            // btnAllShippers
            // 
            this.btnAllShippers.FlatAppearance.BorderSize = 0;
            this.btnAllShippers.Location = new System.Drawing.Point(471, 130);
            this.btnAllShippers.Name = "btnAllShippers";
            this.btnAllShippers.Size = new System.Drawing.Size(162, 23);
            this.btnAllShippers.TabIndex = 172;
            this.btnAllShippers.Text = "Mostrar todos los transportistas";
            this.btnAllShippers.UseVisualStyleBackColor = true;
            this.btnAllShippers.Click += new System.EventHandler(this.btnAllShippers_Click);
            // 
            // btnAllEmployees
            // 
            this.btnAllEmployees.FlatAppearance.BorderSize = 0;
            this.btnAllEmployees.Location = new System.Drawing.Point(303, 130);
            this.btnAllEmployees.Name = "btnAllEmployees";
            this.btnAllEmployees.Size = new System.Drawing.Size(162, 23);
            this.btnAllEmployees.TabIndex = 171;
            this.btnAllEmployees.Text = "Mostrar todos los empleados";
            this.btnAllEmployees.UseVisualStyleBackColor = true;
            this.btnAllEmployees.Click += new System.EventHandler(this.btnAllEmployees_Click);
            // 
            // txtIdSuppliers
            // 
            this.txtIdSuppliers.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIdSuppliers.Location = new System.Drawing.Point(723, 86);
            this.txtIdSuppliers.Name = "txtIdSuppliers";
            this.txtIdSuppliers.Size = new System.Drawing.Size(131, 20);
            this.txtIdSuppliers.TabIndex = 170;
            this.txtIdSuppliers.Text = "Ingrese ID...";
            this.txtIdSuppliers.Enter += new System.EventHandler(this.txtIdSuppliers_Enter);
            this.txtIdSuppliers.Leave += new System.EventHandler(this.txtIdSuppliers_Leave);
            // 
            // txtIdShippers
            // 
            this.txtIdShippers.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIdShippers.Location = new System.Drawing.Point(723, 57);
            this.txtIdShippers.Name = "txtIdShippers";
            this.txtIdShippers.Size = new System.Drawing.Size(131, 20);
            this.txtIdShippers.TabIndex = 169;
            this.txtIdShippers.Text = "Ingrese ID...";
            this.txtIdShippers.Enter += new System.EventHandler(this.txtIdShippers_Enter);
            this.txtIdShippers.Leave += new System.EventHandler(this.txtIdShippers_Leave);
            // 
            // txtIdEmployeer
            // 
            this.txtIdEmployeer.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIdEmployeer.Location = new System.Drawing.Point(723, 24);
            this.txtIdEmployeer.Name = "txtIdEmployeer";
            this.txtIdEmployeer.Size = new System.Drawing.Size(131, 20);
            this.txtIdEmployeer.TabIndex = 168;
            this.txtIdEmployeer.Text = "Ingrese ID...";
            this.txtIdEmployeer.Enter += new System.EventHandler(this.txtIdEmployeer_Enter);
            this.txtIdEmployeer.Leave += new System.EventHandler(this.txtIdEmployeer_Leave);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox4.Font = new System.Drawing.Font("Cooper Black", 11.25F);
            this.textBox4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox4.Location = new System.Drawing.Point(0, 0);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(1027, 18);
            this.textBox4.TabIndex = 167;
            this.textBox4.Text = " Ejercicio Clase 6 - Entity Framework. LAB - .Net";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDeleteSuppliers
            // 
            this.btnDeleteSuppliers.Enabled = false;
            this.btnDeleteSuppliers.FlatAppearance.BorderSize = 0;
            this.btnDeleteSuppliers.Location = new System.Drawing.Point(860, 84);
            this.btnDeleteSuppliers.Name = "btnDeleteSuppliers";
            this.btnDeleteSuppliers.Size = new System.Drawing.Size(151, 23);
            this.btnDeleteSuppliers.TabIndex = 14;
            this.btnDeleteSuppliers.Text = "Eliminar proveedor por ID";
            this.btnDeleteSuppliers.UseVisualStyleBackColor = true;
            this.btnDeleteSuppliers.Click += new System.EventHandler(this.btnDeleteSuppliers_Click);
            // 
            // btnModifySuppliers
            // 
            this.btnModifySuppliers.Enabled = false;
            this.btnModifySuppliers.FlatAppearance.BorderSize = 0;
            this.btnModifySuppliers.Location = new System.Drawing.Point(577, 84);
            this.btnModifySuppliers.Name = "btnModifySuppliers";
            this.btnModifySuppliers.Size = new System.Drawing.Size(140, 23);
            this.btnModifySuppliers.TabIndex = 13;
            this.btnModifySuppliers.Text = "Modificar proveedor";
            this.btnModifySuppliers.UseVisualStyleBackColor = true;
            this.btnModifySuppliers.Click += new System.EventHandler(this.btnModifySuppliers_Click);
            // 
            // btnAddSuppliers
            // 
            this.btnAddSuppliers.FlatAppearance.BorderSize = 0;
            this.btnAddSuppliers.Location = new System.Drawing.Point(366, 84);
            this.btnAddSuppliers.Name = "btnAddSuppliers";
            this.btnAddSuppliers.Size = new System.Drawing.Size(205, 23);
            this.btnAddSuppliers.TabIndex = 15;
            this.btnAddSuppliers.Text = "Presione aqui para agregar proveedor";
            this.btnAddSuppliers.UseVisualStyleBackColor = true;
            this.btnAddSuppliers.Click += new System.EventHandler(this.btnAddSuppliers_Click);
            // 
            // btnDeleteShippers
            // 
            this.btnDeleteShippers.Enabled = false;
            this.btnDeleteShippers.FlatAppearance.BorderSize = 0;
            this.btnDeleteShippers.Location = new System.Drawing.Point(860, 55);
            this.btnDeleteShippers.Name = "btnDeleteShippers";
            this.btnDeleteShippers.Size = new System.Drawing.Size(151, 23);
            this.btnDeleteShippers.TabIndex = 9;
            this.btnDeleteShippers.Text = "Eliminar transportista por ID";
            this.btnDeleteShippers.UseVisualStyleBackColor = true;
            this.btnDeleteShippers.Click += new System.EventHandler(this.btnDeleteShippers_Click);
            // 
            // btnModifyShippers
            // 
            this.btnModifyShippers.Enabled = false;
            this.btnModifyShippers.FlatAppearance.BorderSize = 0;
            this.btnModifyShippers.Location = new System.Drawing.Point(577, 54);
            this.btnModifyShippers.Name = "btnModifyShippers";
            this.btnModifyShippers.Size = new System.Drawing.Size(140, 23);
            this.btnModifyShippers.TabIndex = 8;
            this.btnModifyShippers.Text = "Modificar transportista";
            this.btnModifyShippers.UseVisualStyleBackColor = true;
            this.btnModifyShippers.Click += new System.EventHandler(this.btnModifyShippers_Click);
            // 
            // btnAddShippers
            // 
            this.btnAddShippers.FlatAppearance.BorderSize = 0;
            this.btnAddShippers.Location = new System.Drawing.Point(366, 54);
            this.btnAddShippers.Name = "btnAddShippers";
            this.btnAddShippers.Size = new System.Drawing.Size(205, 23);
            this.btnAddShippers.TabIndex = 10;
            this.btnAddShippers.Text = "Presione aqui para agregar transportista";
            this.btnAddShippers.UseVisualStyleBackColor = true;
            this.btnAddShippers.Click += new System.EventHandler(this.btnAddShippers_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Enabled = false;
            this.btnDeleteEmployee.FlatAppearance.BorderSize = 0;
            this.btnDeleteEmployee.Location = new System.Drawing.Point(860, 22);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(151, 23);
            this.btnDeleteEmployee.TabIndex = 4;
            this.btnDeleteEmployee.Text = "Eliminar empleado por ID";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnModifyEmployee
            // 
            this.btnModifyEmployee.Enabled = false;
            this.btnModifyEmployee.FlatAppearance.BorderSize = 0;
            this.btnModifyEmployee.Location = new System.Drawing.Point(577, 22);
            this.btnModifyEmployee.Name = "btnModifyEmployee";
            this.btnModifyEmployee.Size = new System.Drawing.Size(140, 23);
            this.btnModifyEmployee.TabIndex = 3;
            this.btnModifyEmployee.Text = "Modificar empleado";
            this.btnModifyEmployee.UseVisualStyleBackColor = true;
            this.btnModifyEmployee.Click += new System.EventHandler(this.btnModifyEmployee_Click);
            // 
            // btnAddEmployees
            // 
            this.btnAddEmployees.FlatAppearance.BorderSize = 0;
            this.btnAddEmployees.Location = new System.Drawing.Point(366, 22);
            this.btnAddEmployees.Name = "btnAddEmployees";
            this.btnAddEmployees.Size = new System.Drawing.Size(205, 23);
            this.btnAddEmployees.TabIndex = 5;
            this.btnAddEmployees.Text = "Presione aqui para agregar empleado";
            this.btnAddEmployees.UseVisualStyleBackColor = true;
            this.btnAddEmployees.Click += new System.EventHandler(this.btnAddEmployees_Click);
            // 
            // txtSuppliers
            // 
            this.txtSuppliers.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSuppliers.Location = new System.Drawing.Point(178, 86);
            this.txtSuppliers.Name = "txtSuppliers";
            this.txtSuppliers.Size = new System.Drawing.Size(182, 20);
            this.txtSuppliers.TabIndex = 11;
            this.txtSuppliers.TextChanged += new System.EventHandler(this.txtSuppliers_TextChanged);
            // 
            // txtShippers
            // 
            this.txtShippers.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtShippers.Location = new System.Drawing.Point(178, 56);
            this.txtShippers.Name = "txtShippers";
            this.txtShippers.Size = new System.Drawing.Size(182, 20);
            this.txtShippers.TabIndex = 6;
            this.txtShippers.TextChanged += new System.EventHandler(this.txtShippers_TextChanged);
            // 
            // txtEmployee
            // 
            this.txtEmployee.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtEmployee.Location = new System.Drawing.Point(178, 24);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(182, 20);
            this.txtEmployee.TabIndex = 1;
            this.txtEmployee.TextChanged += new System.EventHandler(this.txtEmployee_TextChanged);
            // 
            // lblSuppliers
            // 
            this.lblSuppliers.AutoSize = true;
            this.lblSuppliers.Location = new System.Drawing.Point(14, 89);
            this.lblSuppliers.Name = "lblSuppliers";
            this.lblSuppliers.Size = new System.Drawing.Size(147, 13);
            this.lblSuppliers.TabIndex = 153;
            this.lblSuppliers.Text = "Buscar proveedor por nombre";
            // 
            // lblShippers
            // 
            this.lblShippers.AutoSize = true;
            this.lblShippers.Location = new System.Drawing.Point(16, 59);
            this.lblShippers.Name = "lblShippers";
            this.lblShippers.Size = new System.Drawing.Size(156, 13);
            this.lblShippers.TabIndex = 151;
            this.lblShippers.Text = "Buscar transportista por nombre";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(16, 27);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(145, 13);
            this.lblEmployee.TabIndex = 149;
            this.lblEmployee.Text = "Buscar empleado por nombre";
            // 
            // dgvListAll
            // 
            this.dgvListAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListAll.Location = new System.Drawing.Point(0, 0);
            this.dgvListAll.MultiSelect = false;
            this.dgvListAll.Name = "dgvListAll";
            this.dgvListAll.ReadOnly = true;
            this.dgvListAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListAll.Size = new System.Drawing.Size(1027, 245);
            this.dgvListAll.TabIndex = 149;
            // 
            // btnExitForm
            // 
            this.btnExitForm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExitForm.FlatAppearance.BorderSize = 0;
            this.btnExitForm.Location = new System.Drawing.Point(0, 245);
            this.btnExitForm.Name = "btnExitForm";
            this.btnExitForm.Size = new System.Drawing.Size(1027, 23);
            this.btnExitForm.TabIndex = 148;
            this.btnExitForm.Text = "Salir";
            this.btnExitForm.UseVisualStyleBackColor = true;
            this.btnExitForm.Click += new System.EventHandler(this.btnExitForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 434);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Bustamante Federico - Lab .Net - Entity Framkework.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListAll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnDeleteSuppliers;
        private System.Windows.Forms.Button btnModifySuppliers;
        private System.Windows.Forms.Button btnAddSuppliers;
        private System.Windows.Forms.Button btnDeleteShippers;
        private System.Windows.Forms.Button btnModifyShippers;
        private System.Windows.Forms.Button btnAddShippers;
        private System.Windows.Forms.Button btnModifyEmployee;
        private System.Windows.Forms.Button btnAddEmployees;
        private System.Windows.Forms.TextBox txtSuppliers;
        private System.Windows.Forms.TextBox txtShippers;
        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.Label lblSuppliers;
        private System.Windows.Forms.Label lblShippers;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.DataGridView dgvListAll;
        private System.Windows.Forms.Button btnExitForm;
        private System.Windows.Forms.TextBox txtIdSuppliers;
        private System.Windows.Forms.TextBox txtIdShippers;
        private System.Windows.Forms.TextBox txtIdEmployeer;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnAllSuppliers;
        private System.Windows.Forms.Button btnAllShippers;
        private System.Windows.Forms.Button btnAllEmployees;
    }
}
