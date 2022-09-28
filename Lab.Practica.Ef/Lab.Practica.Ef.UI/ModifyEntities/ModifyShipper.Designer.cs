
namespace Lab.Practica.Ef.UI.ModifyEntities
{
    partial class FrmModifyShipper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModifyShipper));
            this.btnModifyShippers = new System.Windows.Forms.Button();
            this.txtPhoneShipper = new System.Windows.Forms.TextBox();
            this.txtCompanyNameShippers = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIdShipper = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnModifyShippers
            // 
            this.btnModifyShippers.Location = new System.Drawing.Point(122, 90);
            this.btnModifyShippers.Name = "btnModifyShippers";
            this.btnModifyShippers.Size = new System.Drawing.Size(147, 23);
            this.btnModifyShippers.TabIndex = 4;
            this.btnModifyShippers.Text = "Modificar";
            this.btnModifyShippers.UseVisualStyleBackColor = true;
            this.btnModifyShippers.Click += new System.EventHandler(this.btnModifyShippers_Click);
            // 
            // txtPhoneShipper
            // 
            this.txtPhoneShipper.Location = new System.Drawing.Point(122, 64);
            this.txtPhoneShipper.MaxLength = 15;
            this.txtPhoneShipper.Name = "txtPhoneShipper";
            this.txtPhoneShipper.Size = new System.Drawing.Size(317, 20);
            this.txtPhoneShipper.TabIndex = 3;
            // 
            // txtCompanyNameShippers
            // 
            this.txtCompanyNameShippers.Location = new System.Drawing.Point(122, 33);
            this.txtCompanyNameShippers.MaxLength = 15;
            this.txtCompanyNameShippers.Name = "txtCompanyNameShippers";
            this.txtCompanyNameShippers.Size = new System.Drawing.Size(317, 20);
            this.txtCompanyNameShippers.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Teléfono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nombre compañia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "ID";
            // 
            // lblIdShipper
            // 
            this.lblIdShipper.AutoSize = true;
            this.lblIdShipper.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdShipper.Location = new System.Drawing.Point(119, 9);
            this.lblIdShipper.Name = "lblIdShipper";
            this.lblIdShipper.Size = new System.Drawing.Size(17, 13);
            this.lblIdShipper.TabIndex = 1;
            this.lblIdShipper.Text = "id";
            // 
            // FrmModifyShipper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 123);
            this.Controls.Add(this.lblIdShipper);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModifyShippers);
            this.Controls.Add(this.txtPhoneShipper);
            this.Controls.Add(this.txtCompanyNameShippers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmModifyShipper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar transportista";
            this.Load += new System.EventHandler(this.FrmModifyShipper_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModifyShippers;
        public System.Windows.Forms.TextBox txtPhoneShipper;
        public System.Windows.Forms.TextBox txtCompanyNameShippers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblIdShipper;
    }
}