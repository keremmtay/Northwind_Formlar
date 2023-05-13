namespace Northwind_Formlar
{
    partial class MainPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnKategoriForm = new System.Windows.Forms.Button();
            this.btnEmployeeForm = new System.Windows.Forms.Button();
            this.btnCustomersForm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.btnCustomersForm);
            this.panel1.Controls.Add(this.btnEmployeeForm);
            this.panel1.Controls.Add(this.btnKategoriForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 582);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(239, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(838, 582);
            this.panel2.TabIndex = 1;
            // 
            // btnKategoriForm
            // 
            this.btnKategoriForm.Location = new System.Drawing.Point(34, 34);
            this.btnKategoriForm.Name = "btnKategoriForm";
            this.btnKategoriForm.Size = new System.Drawing.Size(164, 57);
            this.btnKategoriForm.TabIndex = 0;
            this.btnKategoriForm.Text = "Kategori Form";
            this.btnKategoriForm.UseVisualStyleBackColor = true;
            this.btnKategoriForm.Click += new System.EventHandler(this.btnKategoriForm_Click);
            // 
            // btnEmployeeForm
            // 
            this.btnEmployeeForm.Location = new System.Drawing.Point(34, 126);
            this.btnEmployeeForm.Name = "btnEmployeeForm";
            this.btnEmployeeForm.Size = new System.Drawing.Size(164, 57);
            this.btnEmployeeForm.TabIndex = 0;
            this.btnEmployeeForm.Text = "Employee Form";
            this.btnEmployeeForm.UseVisualStyleBackColor = true;
            this.btnEmployeeForm.Click += new System.EventHandler(this.btnEmployeeForm_Click);
            // 
            // btnCustomersForm
            // 
            this.btnCustomersForm.Location = new System.Drawing.Point(34, 224);
            this.btnCustomersForm.Name = "btnCustomersForm";
            this.btnCustomersForm.Size = new System.Drawing.Size(164, 57);
            this.btnCustomersForm.TabIndex = 0;
            this.btnCustomersForm.Text = "Customers Form";
            this.btnCustomersForm.UseVisualStyleBackColor = true;
            this.btnCustomersForm.Click += new System.EventHandler(this.btnCustomersForm_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 582);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCustomersForm;
        private System.Windows.Forms.Button btnEmployeeForm;
        private System.Windows.Forms.Button btnKategoriForm;
        private System.Windows.Forms.Panel panel2;
    }
}