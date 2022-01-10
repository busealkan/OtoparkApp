using H5190059_BuseAlkan.Sınıflar.Varliklar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H5190059_BuseAlkan.Sınıflar.Veritabanı
{
    class MusteriVeritabani : TemelVeritabani
    {
        public override void Ekle(object obj)
        {
            throw new NotImplementedException();
        }

        public override int EkleVeIdDon(object obj)
        {
            Musteri mstr = (Musteri)obj;
            Baglan();
            komut = new SqlCommand("usp_MusteriEkle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@TCKN", mstr.TCKN);
            komut.Parameters.AddWithValue("@Adi", mstr.Adi);
            komut.Parameters.AddWithValue("@Soyadi", mstr.Soyadi);
            komut.Parameters.AddWithValue("@Telefon", mstr.Telefon);
            komut.Parameters.AddWithValue("@Email", mstr.Email);
            komut.Parameters.AddWithValue("@Adres", mstr.Adres);

            SqlParameter prm_Id = new SqlParameter("@Id", SqlDbType.Int);
            prm_Id.Direction = ParameterDirection.Output;
            komut.Parameters.Add(prm_Id);

            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
            return int.Parse(prm_Id.Value.ToString()); 
        }

        public override void Guncelle(object obj)
        {
            Musteri mstr = (Musteri)obj;
            Baglan();
            string sorgu = "update tbl_Musteri " +
                            " set Adi=@Adi,Soyadi =@Soyadi,Email=@Email,TCKN=@TCKN,Adres=@Adres,Telefon=@Telefon " +
                            " where Id = " + mstr.Id;
            komut = new SqlCommand(sorgu, baglanti);
            komut.CommandType = CommandType.Text;

            komut.Parameters.AddWithValue("@TCKN", mstr.TCKN);
            komut.Parameters.AddWithValue("@Adi", mstr.Adi);
            komut.Parameters.AddWithValue("@Soyadi", mstr.Soyadi);
            komut.Parameters.AddWithValue("@Telefon", mstr.Telefon);
            komut.Parameters.AddWithValue("@Email", mstr.Email);
            komut.Parameters.AddWithValue("@Adres", mstr.Adres);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }


        public override DataTable Listele(object obj)
        {
            Musteri mstr = (Musteri)obj;
            Baglan();
            string sorgu = "select * from tbl_Musteri ";
            if (!string.IsNullOrEmpty(mstr.Adi))
            {
                sorgu = sorgu + " where Adi like '%" + mstr.Adi + "%'";
            }
            else if (!string.IsNullOrEmpty(mstr.Soyadi))
            {
                sorgu = sorgu + " where Soyadi like '%" + mstr.Soyadi + "%'";
            }
            else if (!string.IsNullOrEmpty(mstr.TCKN))
            {
                sorgu = sorgu + " where TCKN like '%" + mstr.TCKN + "%'";
            }
            else if (!string.IsNullOrEmpty(mstr.Email))
            {
                sorgu = sorgu + " where Email like '%" + mstr.Email + "%'";
            }
            else
            {
                throw new Exception("Listede olmayan değerde arama yapıkmatadır.");
            }

            komut = new SqlCommand(sorgu, baglanti);
            komut.CommandType = CommandType.Text;
            komut.ExecuteNonQuery();
            tablo = new DataTable();
            adaptor = new SqlDataAdapter(komut);
            adaptor.Fill(tablo);
            baglanti.Close();
            baglanti.Dispose();
            return tablo;
        }

        public override DataTable Listele()
        {
            Baglan();
            komut = new SqlCommand("select * from tbl_Musteri ", baglanti);
            komut.CommandType = CommandType.Text;
            komut.ExecuteNonQuery();
            tablo = new DataTable();
            adaptor = new SqlDataAdapter(komut);
            adaptor.Fill(tablo);
            baglanti.Close();
            baglanti.Dispose();
            return tablo;
        }

        public override void Sil(object obj)
        {
            Musteri mstr = (Musteri)obj;
            Baglan();
            komut = new SqlCommand("delete tbl_Musteri Where Id = " + mstr.Id, baglanti);
            komut.CommandType = CommandType.Text;
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }
    }
}
