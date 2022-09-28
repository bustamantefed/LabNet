
namespace Lab.Practica.Ef.UI
{
    partial class FrmAddShipperscs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddShipperscs));
            this.txtPhoneShipper = new System.Windows.Forms.TextBox();
            this.txtCompanyNameShippers = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddNewShippers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPhoneShipper
            // 
            this.txtPhoneShipper.Location = new System.Drawing.Point(121, 43);
            this.txtPhoneShipper.MaxLength = 24;
            this.txtPhoneShipper.Name = "txtPhoneShipper";
            this.txtPhoneShipper.Size = new System.Drawing.Size(317, 20);
            this.txtPhoneShipper.TabIndex = 3;
            this.txtPhoneShipper.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneShipper_KeyPress);
            // 
            // txtCompanyNameShippers
            // 
            this.txtCompanyNameShippers.Location = new System.Drawing.Point(121, 12);
            this.txtCompanyNameShippers.MaxLength = 40;
            this.txtCompanyNameShippers.Name = "txtCompanyNameShippers";
            this.txtCompanyNameShippers.Size = new System.Drawing.Size(317, 20);
            this.txtCompanyNameShippers.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Teléfono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nombre compañia";
            // 
            // btnAddNewShippers
            // 
            this.btnAddNewShippers.Location = new System.Drawing.Point(121, 69);
            this.btnAddNewShippers.Name = "btnAddNewShippers";
            this.btnAddNewShippers.Size = new System.Drawing.Size(147, 23);
            this.btnAddNewShippers.TabIndex = 4;
            this.btnAddNewShippers.Text = "Agregar";
            this.btnAddNewShippers.UseVisualStyleBackColor = true;
            this.btnAddNewShippers.Click += new System.EventHandler(this.btnAddNewShippers_Click);
            // 
            // FrmAddShipperscs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 106);
            this.Controls.Add(this.btnAddNewShippers);
            this.Controls.Add(this.txtPhoneShipper);
            this.Controls.Add(this.txtCompanyNameShippers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddShipperscs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar nuevo transportista";
            this.Load += new System.EventHandler(this.FrmAddShipperscs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddNewShippers;
        public System.Windows.Forms.TextBox txtPhoneShipper;
        public System.Windows.Forms.TextBox txtCompanyNameShippers;
    }
}