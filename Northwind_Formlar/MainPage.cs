using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind_Formlar
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnKategoriForm_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();

            form.MdiParent = this;

            FormGetir(form);
        }

        private void FormGetir(Form form)
        {
            panel2.Controls.Clear();

            panel2.Controls.Add(form);

            form.FormBorderStyle = FormBorderStyle.None;

            form.Show();

        }

        private void btnEmployeeForm_Click(object sender, EventArgs e)
        {
            FormEmployees form = new FormEmployees();

            form.MdiParent = this;

            FormGetir(form);
        }

        private void btnCustomersForm_Click(object sender, EventArgs e)
        {
            FormCustomers form = new FormCustomers();

            form.MdiParent= this;

            FormGetir(form);
        }
    }
}
