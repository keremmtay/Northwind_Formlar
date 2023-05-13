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
    public partial class FormEmployees : Form
    {
        public FormEmployees()
        {
            InitializeComponent();
        }

        EmployeesDal _employeesDal = new EmployeesDal();

        private void btnPersonelListele_Click(object sender, EventArgs e)
        {
            PersonelListele();
        }

        private void PersonelListele()
        {
            dataGridView1.DataSource = _employeesDal.PersonelListele();
        }

        private void btnPersonelKaydet_Click(object sender, EventArgs e)
        {
            if (tbxPersonelSoyismi.Text != string.Empty && tbxPersonelİsmi.Text != string.Empty && tbxPersonelUnvan.Text != string.Empty && tbxPersonelSehir.Text != string.Empty)
            {

                Employees employee = new Employees()
                {
                    LastName = tbxPersonelSoyismi.Text,
                    FirstName = tbxPersonelİsmi.Text,
                    Title = tbxPersonelUnvan.Text,
                    City = tbxPersonelSehir.Text

                };

                int sonuc = _employeesDal.PersonelEkle(employee);

                if (sonuc > 0)
                {
                    MessageBox.Show("Kayıt başarılı bir şekilde oluşturuldu.");
                }
                else
                {
                    MessageBox.Show("Kayıt işlemi başarısız oldu.");
                }



            }
            else
            {
                MessageBox.Show("Lütfen Soyisim, İsim, Ünvan ve Şehir alanlarını doldurun.");
            }

            PersonelListele();

            FormTemizle();
        }

        private void FormTemizle()
        {
            tbxPersonelId.Clear();
            tbxPersonelSoyismi.Clear();
            tbxPersonelİsmi.Clear();
            tbxPersonelUnvan.Clear();
            tbxPersonelSehir.Clear();
        }

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbxPersonelId.Text);

            _employeesDal.PersonelSil(id);

            PersonelListele();

            MessageBox.Show($"{id} id'li kayıt silindi.");

            FormTemizle();
        }

        private void btnFormuTemizle_Click(object sender, EventArgs e)
        {
            FormTemizle();
        }

        private void btnPersonelGuncelle_Click(object sender, EventArgs e)
        {
            if (tbxPersonelId.Text != string.Empty && tbxPersonelSoyismi.Text != string.Empty && tbxPersonelİsmi.Text != string.Empty && tbxPersonelUnvan.Text != string.Empty && tbxPersonelSehir.Text != string.Empty)
            {
                Employees employee = new Employees()
                {
                    EmployeeID = Convert.ToInt32(tbxPersonelId.Text),
                    LastName = tbxPersonelSoyismi.Text,
                    FirstName = tbxPersonelİsmi.Text,
                    Title = tbxPersonelUnvan.Text,
                    City = tbxPersonelSehir.Text

                };

                if (_employeesDal.PersonelGuncelle(employee) > 0)
                {
                    MessageBox.Show("Personel güncellendi...");

                }
                else
                {
                    MessageBox.Show("Personel güncellenemedi...");
                }

                PersonelListele();

                FormTemizle();

            }
            else
            {
                MessageBox.Show("Kayıt güncellenemedi.");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxPersonelId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbxPersonelSoyismi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbxPersonelİsmi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbxPersonelUnvan.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tbxPersonelSehir.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void FormEmployees_Load(object sender, EventArgs e)
        {
            PersonelListele();
        }
    }
}
