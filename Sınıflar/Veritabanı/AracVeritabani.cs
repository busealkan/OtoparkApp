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
    class AracVeritabani : TemelVeritabani
    {
        public override void Ekle(object obj)
        {
            throw new NotImplementedException();
        }

        public override int EkleVeIdDon(object obj)
        {
            Arac arc = (Arac)obj;
            Baglan();
            komut = new SqlCommand("usp_AracGirisYap", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@Marka", arc.Marka);
            komut.Parameters.AddWithValue("@Model", arc.Model);
            komut.Parameters.AddWithValue("@Plaka", arc.Plaka);
            komut.Parameters.AddWithValue("@MusteriId", arc.MusteriId);
            komut.Parameters.AddWithValue("@AracGirisTarih", arc.AracGirisTarihi);
            komut.Parameters.AddWithValue("@Durumu", arc.Durumu);

            SqlParameter prm_Id = new SqlParameter("@Id", SqlDbType.Int);
            prm_Id.Direction = ParameterDirection.Output;
            komut.Parameters.Add(prm_Id);

            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
            return int.Parse(prm_Id.Value.ToString());
        }

        internal void cikisSaatGuncelle(Arac arc)
        {
            Baglan();
            komut = new SqlCommand("update tbl_Arac set AracCikisTarih=GETDATE() where Plaka='"+arc.Plaka+ "' and Durumu='A'", baglanti);
            komut.CommandType = CommandType.Text;

            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }

        internal int aracIdGetir(Arac arc)
        {
            Baglan();
            komut = new SqlCommand("select Id from tbl_Arac where Plaka='" + arc.Plaka + "' and Durumu='A'", baglanti);
            komut.CommandType = CommandType.Text;
            komut.ExecuteNonQuery();
            int aracId = int.Parse(komut.ExecuteScalar().ToString());
            baglanti.Close();
            baglanti.Dispose();
            return aracId;
        }

        public override void Guncelle(object obj)
        {

            Arac arc = (Arac)obj;
            Baglan();
            komut = new SqlCommand("usp_AracCikisYap", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@Plaka", arc.Plaka);

            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }

        internal int saatListele(Arac arc)
        {
            Baglan();
            
            string sorgu = "select DATEDIFF(HOUR, AracGirisTarih, AracCikisTarih) from tbl_Arac where Plaka='" + arc.Plaka+ "' and Durumu='A'";
            komut = new SqlCommand(sorgu, baglanti);
            komut.CommandType = CommandType.Text;
            komut.ExecuteNonQuery();
            int saat = int.Parse(komut.ExecuteScalar().ToString());
            if (saat > 23)
            {
                saat = saat - 24;
            }
            
            baglanti.Close();
            baglanti.Dispose();
            return saat;
        }

        internal int dakikaListele(Arac arc)
        {
            Baglan();

            string sorgu = "select DATEDIFF(MINUTE, AracGirisTarih, AracCikisTarih) from tbl_Arac where Plaka='" + arc.Plaka + "' and Durumu='A'";
            komut = new SqlCommand(sorgu, baglanti);
            komut.CommandType = CommandType.Text;
            komut.ExecuteNonQuery();
            int dakika = int.Parse(komut.ExecuteScalar().ToString());
            if (dakika > 60)
            {
                dakika = dakika - 60;
            }
            baglanti.Close();
            baglanti.Dispose();
            return dakika;
        }
        internal int gunListele(Arac arc)
        {
            Baglan();

            string sorgu = "select DATEDIFF(DAY, AracGirisTarih, AracCikisTarih) from tbl_Arac where Plaka='" + arc.Plaka + "' and Durumu='A'";
            komut = new SqlCommand(sorgu, baglanti);
            komut.CommandType = CommandType.Text;
            komut.ExecuteNonQuery();
            int gun = int.Parse(komut.ExecuteScalar().ToString());
            
            baglanti.Close();
            baglanti.Dispose();
            return gun;
        }

        public override DataTable Listele(object obj)
        {
            throw new NotImplementedException();
        }

        public override DataTable Listele()
        {
            throw new NotImplementedException();
        }

        public override void Sil(object obj)
        {
            throw new NotImplementedException();
        }
        internal bool aracVarMi(Arac arc)
        {

            Baglan();

            string sorgu = "select count(Plaka) from tbl_Arac where Plaka='" + arc.Plaka + "' and Durumu='A'";
            komut = new SqlCommand(sorgu, baglanti);
            komut.CommandType = CommandType.Text;
            komut.ExecuteNonQuery();
            int arac = int.Parse(komut.ExecuteScalar().ToString());
            if (arac == 0)
            {
                baglanti.Close();
                baglanti.Dispose();
                return false;
            }
            else
            {
                baglanti.Close();
                baglanti.Dispose();
                return true;
                
            }
            
        }
    }
}
