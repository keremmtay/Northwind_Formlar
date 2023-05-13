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
    public partial class FormCustomers : Form
    {
        public FormCustomers()
        {
            InitializeComponent();
        }

        CustomersDal _customerDal = new CustomersDal();

        private void btnMusteriListele_Click(object sender, EventArgs e)
        {
            MusteriListele();
        }

        private void MusteriListele()
        {
            dataGridView1.DataSource = _customerDal.MusteriListele();
        }

        private void FormTemizle()
        {
            tbxCompanyName.Clear();
            tbxContactName.Clear();
            tbxContactTitle.Clear();
            tbxMusteriID.Clear();
            tbxAddress.Clear();
            tbxCity.Clear();
            tbxPostalCode.Clear();
        }

        private void btnFormTemizle_Click(object sender, EventArgs e)
        {
            FormTemizle();
        }
    }
}
