namespace Northwind_Formlar
{
    partial class FormEmployees
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
            this.btnPersonelListele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPersonelKaydet = new System.Windows.Forms.Button();
            this.btnPersonelSil = new System.Windows.Forms.Button();
            this.btnPersonelGuncelle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxPersonelSehir = new System.Windows.Forms.TextBox();
            this.tbxPersonelUnvan = new System.Windows.Forms.TextBox();
            this.tbxPersonelİsmi = new System.Windows.Forms.TextBox();
            this.tbxPersonelSoyismi = new System.Windows.Forms.TextBox();
            this.tbxPersonelId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFormuTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPersonelListele
            // 
            this.btnPersonelListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelListele.Location = new System.Drawing.Point(12, 515);
            this.btnPersonelListele.Name = "btnPersonelListele";
            this.btnPersonelListele.Size = new System.Drawing.Size(232, 78);
            this.btnPersonelListele.TabIndex = 0;
            this.btnPersonelListele.Text = "Personel Listele";
            this.btnPersonelListele.UseVisualStyleBackColor = true;
            this.btnPersonelListele.Click += new System.EventHandler(this.btnPersonelListele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(737, 456);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnPersonelKaydet
            // 
            this.btnPersonelKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelKaydet.Location = new System.Drawing.Point(250, 515);
            this.btnPersonelKaydet.Name = "btnPersonelKaydet";
            this.btnPersonelKaydet.Size = new System.Drawing.Size(185, 78);
            this.btnPersonelKaydet.TabIndex = 2;
            this.btnPersonelKaydet.Text = "Kaydet";
            this.btnPersonelKaydet.UseVisualStyleBackColor = true;
            this.btnPersonelKaydet.Click += new System.EventHandler(this.btnPersonelKaydet_Click);
            // 
            // btnPersonelSil
            // 
            this.btnPersonelSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelSil.Location = new System.Drawing.Point(441, 515);
            this.btnPersonelSil.Name = "btnPersonelSil";
            this.btnPersonelSil.Size = new System.Drawing.Size(185, 78);
            this.btnPersonelSil.TabIndex = 3;
            this.btnPersonelSil.Text = "Sil";
            this.btnPersonelSil.UseVisualStyleBackColor = true;
            this.btnPersonelSil.Click += new System.EventHandler(this.btnPersonelSil_Click);
            // 
            // btnPersonelGuncelle
            // 
            this.btnPersonelGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelGuncelle.Location = new System.Drawing.Point(632, 515);
            this.btnPersonelGuncelle.Name = "btnPersonelGuncelle";
            this.btnPersonelGuncelle.Size = new System.Drawing.Size(185, 78);
            this.btnPersonelGuncelle.TabIndex = 4;
            this.btnPersonelGuncelle.Text = "Güncelle";
            this.btnPersonelGuncelle.UseVisualStyleBackColor = true;
            this.btnPersonelGuncelle.Click += new System.EventHandler(this.btnPersonelGuncelle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.tbxPersonelSehir);
            this.groupBox1.Controls.Add(this.tbxPersonelUnvan);
            this.groupBox1.Controls.Add(this.tbxPersonelİsmi);
            this.groupBox1.Controls.Add(this.tbxPersonelSoyismi);
            this.groupBox1.Controls.Add(this.tbxPersonelId);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(832, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 237);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Bilgileri";
            // 
            // tbxPersonelSehir
            // 
            this.tbxPersonelSehir.Location = new System.Drawing.Point(190, 174);
            this.tbxPersonelSehir.Name = "tbxPersonelSehir";
            this.tbxPersonelSehir.Size = new System.Drawing.Size(147, 27);
            this.tbxPersonelSehir.TabIndex = 1;
            // 
            // tbxPersonelUnvan
            // 
            this.tbxPersonelUnvan.Location = new System.Drawing.Point(190, 138);
            this.tbxPersonelUnvan.Name = "tbxPersonelUnvan";
            this.tbxPersonelUnvan.Size = new System.Drawing.Size(147, 27);
            this.tbxPersonelUnvan.TabIndex = 1;
            // 
            // tbxPersonelİsmi
            // 
            this.tbxPersonelİsmi.Location = new System.Drawing.Point(190, 105);
            this.tbxPersonelİsmi.Name = "tbxPersonelİsmi";
            this.tbxPersonelİsmi.Size = new System.Drawing.Size(147, 27);
            this.tbxPersonelİsmi.TabIndex = 1;
            // 
            // tbxPersonelSoyismi
            // 
            this.tbxPersonelSoyismi.Location = new System.Drawing.Point(190, 70);
            this.tbxPersonelSoyismi.Name = "tbxPersonelSoyismi";
            this.tbxPersonelSoyismi.Size = new System.Drawing.Size(147, 27);
            this.tbxPersonelSoyismi.TabIndex = 1;
            // 
            // tbxPersonelId
            // 
            this.tbxPersonelId.Location = new System.Drawing.Point(190, 36);
            this.tbxPersonelId.Name = "tbxPersonelId";
            this.tbxPersonelId.ReadOnly = true;
            this.tbxPersonelId.Size = new System.Drawing.Size(75, 27);
            this.tbxPersonelId.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(36, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Şehir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(36, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Personel Ünvanı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(36, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Personel İsmi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(36, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Personel Soyismi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(36, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel ID";
            // 
            // btnFormuTemizle
            // 
            this.btnFormuTemizle.BackColor = System.Drawing.SystemColors.Control;
            this.btnFormuTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFormuTemizle.Location = new System.Drawing.Point(922, 272);
            this.btnFormuTemizle.Name = "btnFormuTemizle";
            this.btnFormuTemizle.Size = new System.Drawing.Size(213, 48);
            this.btnFormuTemizle.TabIndex = 6;
            this.btnFormuTemizle.Text = "Formu Temizle";
            this.btnFormuTemizle.UseVisualStyleBackColor = false;
            this.btnFormuTemizle.Click += new System.EventHandler(this.btnFormuTemizle_Click);
            // 
            // FormEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1234, 631);
            this.Controls.Add(this.btnFormuTemizle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPersonelGuncelle);
            this.Controls.Add(this.btnPersonelSil);
            this.Controls.Add(this.btnPersonelKaydet);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPersonelListele);
            this.Name = "FormEmployees";
            this.Text = "FormEmployees";
            this.Load += new System.EventHandler(this.FormEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPersonelListele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPersonelKaydet;
        private System.Windows.Forms.Button btnPersonelSil;
        private System.Windows.Forms.Button btnPersonelGuncelle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxPersonelSehir;
        private System.Windows.Forms.TextBox tbxPersonelUnvan;
        private System.Windows.Forms.TextBox tbxPersonelİsmi;
        private System.Windows.Forms.TextBox tbxPersonelSoyismi;
        private System.Windows.Forms.TextBox tbxPersonelId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFormuTemizle;
    }
}