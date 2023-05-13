using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind_Formlar
{
    public class CategoryDal
    {
        // Dal : Data Access Layer , Veri Erişim Katmanı

        SqlConnection _baglanti = new SqlConnection("Server=ASUS;Database=Northwind;Integrated Security=true");

        public void BaglantiKontrol()
        {
            if (_baglanti.State == ConnectionState.Closed)
            {
                _baglanti.Open();
            }
        }
        
        public List<Category> KategoriListele()
        {
            BaglantiKontrol();

            SqlCommand komut = new SqlCommand("Select * from Categories", _baglanti);

            SqlDataReader reader = komut.ExecuteReader();

            List<Category> kategoriListesi = new List<Category>();

            while (reader.Read())
            {
                Category category = new Category();

                category.CategoryID = Convert.ToInt32(reader["CategoryID"]);

                category.CategoryName = reader["CategoryName"].ToString();

                category.Description = reader["Description"].ToString();

                kategoriListesi.Add(category);
            }

            _baglanti.Close();

            return kategoriListesi;
        }

        public int KategoriEkle(Category category)
        {
            SqlCommand komut = new SqlCommand("Insert Into Categories (CategoryName, Description) VALUES (@p1, @p2)", _baglanti);

            komut.Parameters.AddWithValue("@p1", category.CategoryName);
            komut.Parameters.AddWithValue("@p2", category.Description);

            BaglantiKontrol();

            int sonuc = komut.ExecuteNonQuery();

            _baglanti.Close();

            return sonuc;
        }

        public void KategoriSil(int id)
        {
            BaglantiKontrol();

            SqlCommand komut = new SqlCommand("Delete from Categories where CategoryID = @catID", _baglanti);

            komut.Parameters.AddWithValue("@catID", id);

            komut.ExecuteNonQuery();

            _baglanti.Close();

        }

        public int KategoriGuncelle(Category category)
        {
            BaglantiKontrol();

            SqlCommand komut = new SqlCommand("Update Categories set CategoryName = @p1, Description = @p2 where CategoryID = @p3", _baglanti);

            komut.Parameters.AddWithValue("@p1", category.CategoryName);
            komut.Parameters.AddWithValue("@p2", category.Description);
            komut.Parameters.AddWithValue("@p3", category.CategoryID);

            int sonuc = komut.ExecuteNonQuery();

            _baglanti.Close();

            return sonuc;
        }

    }
}
