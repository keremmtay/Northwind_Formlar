using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind_Formlar
{
    internal class CustomersDal
    {
        SqlConnection _baglanti = new SqlConnection("Server=ASUS;Database=Northwind;Integrated Security=true");

        public void BaglantiKontrol()
        {
            if (_baglanti.State == ConnectionState.Closed)
            {
                _baglanti.Open();
            }
        }

        public List<Customers> MusteriListele()
        {
            BaglantiKontrol();

            SqlCommand komut = new SqlCommand("Select CustomerID, CompanyName, ContactName, ContactTitle, Address, City, PostalCode from Customers",_baglanti);

            SqlDataReader reader = komut.ExecuteReader();

            List<Customers> MusteriListesi = new List<Customers>();

            while (reader.Read())
            {
                Customers Musteri = new Customers();

                Musteri.CustomerID = reader["CustomerID"].ToString();
                Musteri.CompanyName = reader["CompanyName"].ToString();
                Musteri.ContactName = reader["ContactName"].ToString();
                Musteri.ContactTitle = reader["ContactTitle"].ToString();
                Musteri.Address = reader["Address"].ToString();
                Musteri.City = reader["City"].ToString();
                Musteri.PostalCode = reader["PostalCode"].ToString();

                MusteriListesi.Add(Musteri);
            }

            _baglanti.Close();

            return MusteriListesi;

        }

        public int MusteriEkle(Customers customer)
        {
            SqlCommand komut = new SqlCommand("Insert Into Customers (CompanyName, ContactName, ContactTitle, Address, City, PostalCode) VALUES (@c1, @c2, @c3, @c4, @c5, @c6)", _baglanti);

            komut.Parameters.AddWithValue("@c1",customer.CompanyName);
            komut.Parameters.AddWithValue("@c2",customer.ContactName);
            komut.Parameters.AddWithValue("@c3",customer.ContactTitle);
            komut.Parameters.AddWithValue("@c4",customer.Address);
            komut.Parameters.AddWithValue("@c5",customer.City);
            komut.Parameters.AddWithValue("@c6",customer.PostalCode);

            BaglantiKontrol();

            int sonuc = komut.ExecuteNonQuery();

            _baglanti.Close();

            return sonuc;

        }

        public void MusteriSil (int id)
        {
            BaglantiKontrol();

            SqlCommand komut = new SqlCommand("Delete from Customers where CustomerID = @cusID",_baglanti);

            komut.Parameters.AddWithValue("@cusID", id);

            komut.ExecuteNonQuery();

            _baglanti.Close();

        }

        public int MusteriGuncelle(Customers customer)
        {
            BaglantiKontrol();

            SqlCommand komut = new SqlCommand("Update Customers set CompanyName = @c1, ContactName = @c2, ContactTitle = @c3, Address = @c4, City = @c5, PostalCode = @c6 where CustomerID = @c7",_baglanti);

            komut.Parameters.AddWithValue("@c1",customer.CompanyName);
            komut.Parameters.AddWithValue("@c2",customer.ContactName);
            komut.Parameters.AddWithValue("@c3",customer.ContactTitle);
            komut.Parameters.AddWithValue("@c4",customer.Address);
            komut.Parameters.AddWithValue("@c5",customer.City);
            komut.Parameters.AddWithValue("@c6",customer.PostalCode);
            komut.Parameters.AddWithValue("@c7",customer.CustomerID);

            int sonuc = komut.ExecuteNonQuery();

            _baglanti.Close();

            return sonuc;

        }
    }
}
