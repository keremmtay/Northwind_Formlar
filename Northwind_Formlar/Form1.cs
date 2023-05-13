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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CategoryDal _categoryDal = new CategoryDal();

        private void btnKategoriListele_Click(object sender, EventArgs e)
        {
            KategoriListele();
        }

        private void KategoriListele()
        {
            dataGridView1.DataSource = _categoryDal.KategoriListele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbxKategoriAdi.Text != null && tbxKategoriAciklama.Text != null && tbxKategoriAdi.Text != "" && tbxKategoriAciklama.Text != string.Empty)

                // string.Empty ve "" yazmak aynı şey. Boş bırakılması durumunda kullanılır.
            {
                Category kategori = new Category()
                {
                    CategoryName = tbxKategoriAdi.Text,
                    Description = tbxKategoriAciklama.Text

                };

                // Veritabanına kaydetmesi için ilgili metoda kategori nesnesini göndermeliyiz.
                //CategoryDal categoryDal = new CategoryDal(); yazmak yerine bu satırı en tepeye ekleyebiliriz.

                int sonuc = _categoryDal.KategoriEkle(kategori);

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
                MessageBox.Show("Lütfen Kategori Adı ve Açıklama alanlarını doldurun.");
            }

            KategoriListele();

            FormTemizle();
        }

        private void btnKategoriSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbxKategoriID.Text);

            _categoryDal.KategoriSil(id);

            KategoriListele();

            MessageBox.Show($"{id} id'li kayıt silindi.");

            FormTemizle();
        }

        private void FormTemizle()
        {
            tbxKategoriID.Clear();
            tbxKategoriAdi.Clear();
            tbxKategoriAciklama.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KategoriListele();
        }

        private void btnFormuTemizle_Click(object sender, EventArgs e)
        {
            FormTemizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxKategoriID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbxKategoriAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbxKategoriAciklama.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnKategoriGuncelle_Click(object sender, EventArgs e)
        {
            if (tbxKategoriID.Text != string.Empty && tbxKategoriAdi.Text != string.Empty && tbxKategoriAciklama.Text != string.Empty)
            {
                Category kategori = new Category()
                {
                    CategoryID = Convert.ToInt32(tbxKategoriID.Text),
                    CategoryName = tbxKategoriAdi.Text,
                    Description = tbxKategoriAciklama.Text,
                };

                if (_categoryDal.KategoriGuncelle(kategori) > 0)
                {
                    MessageBox.Show("Kategori güncellendi...");

                }
                else
                {
                    MessageBox.Show("Kategori güncellenemedi...");
                }

                KategoriListele();

                FormTemizle();
            }
            else
            {
                MessageBox.Show("Kayıt güncellenemedi.");
            }

        }
    }
}
