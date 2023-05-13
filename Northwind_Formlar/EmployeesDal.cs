using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind_Formlar
{
    internal class EmployeesDal
    {
        SqlConnection _baglanti = new SqlConnection("Server=ASUS;Database=Northwind;Integrated Security=true");

        public void BaglantiKontrol()
        {
            if (_baglanti.State == ConnectionState.Closed)
            {
                _baglanti.Open();
            }
        }

        public List<Employees> PersonelListele()
        {
            BaglantiKontrol();

            SqlCommand komut = new SqlCommand("Select EmployeeID, LastName, FirstName, Title, City from Employees", _baglanti);

            SqlDataReader reader = komut.ExecuteReader();

            List<Employees> PersonelListesi = new List<Employees>();

            while (reader.Read())
            {
                Employees employee = new Employees();

                employee.EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                employee.LastName = reader["LastName"].ToString();
                employee.FirstName = reader["FirstName"].ToString();
                employee.Title = reader["Title"].ToString();
                employee.City = reader["City"].ToString();

                PersonelListesi.Add(employee);

            }

            _baglanti.Close();

            return PersonelListesi;
        }

        public int PersonelEkle(Employees employee)
        {
            SqlCommand komut = new SqlCommand("Insert Into Employees (LastName, FirstName, Title, City) VALUES (@e1, @e2, @e3, @e4)", _baglanti);

            komut.Parameters.AddWithValue("@e1", employee.LastName);
            komut.Parameters.AddWithValue("@e2", employee.FirstName);
            komut.Parameters.AddWithValue("@e3", employee.Title);
            komut.Parameters.AddWithValue("@e4", employee.City);

            BaglantiKontrol();

            int sonuc = komut.ExecuteNonQuery();

            _baglanti.Close();

            return sonuc;
        }

        public void PersonelSil(int id)
        {
            BaglantiKontrol();

            SqlCommand komut = new SqlCommand("Delete from Employees where EmployeeID = @empID",_baglanti);

            komut.Parameters.AddWithValue("@empID", id);

            komut.ExecuteNonQuery();

            _baglanti.Close();

        }

        public int PersonelGuncelle(Employees employee)
        {
            BaglantiKontrol();

            SqlCommand komut = new SqlCommand("Update Employees set LastName = @e1, FirstName = @e2, Title = @e3, City = @e4 where EmployeeID = @e5", _baglanti);

            komut.Parameters.AddWithValue("@e1", employee.LastName);
            komut.Parameters.AddWithValue("@e2", employee.FirstName);
            komut.Parameters.AddWithValue("@e3", employee.Title);
            komut.Parameters.AddWithValue("@e4", employee.City);
            komut.Parameters.AddWithValue("@e5", employee.EmployeeID);

            int sonuc = komut.ExecuteNonQuery();

            _baglanti.Close();

            return sonuc;

        }
    }
}
