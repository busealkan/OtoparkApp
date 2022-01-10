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
    class AlanlarVeritabani : TemelVeritabani
    {
        public override void Ekle(object obj)
        {
            throw new NotImplementedException();
        }

        public override int EkleVeIdDon(object obj)
        {
            throw new NotImplementedException();
        }

        public override void Guncelle(object obj)
        {
            throw new NotImplementedException();
        }

        public override DataTable Listele(object obj)
        {
            throw new NotImplementedException();
        }

        public override DataTable Listele()
        {
            Baglan();
            komut = new SqlCommand("select Adi from tbl_Alanlar where Durumu='B'", baglanti);
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
            throw new NotImplementedException();
        }
        
        internal int toplamKapasite()
        {
            Baglan();
            string sorgu = "select count(*) from tbl_Alanlar";
            komut = new SqlCommand(sorgu, baglanti);
            komut.CommandType = CommandType.Text;
            komut.ExecuteNonQuery();
            int kapasite = int.Parse(komut.ExecuteScalar().ToString());
            baglanti.Close();
            baglanti.Dispose();
            return kapasite;
        }
        internal int toplamBosYer()
        {
            Baglan();
            string sorgu = "select count(*) from tbl_Alanlar where Durumu = 'B'";
            komut = new SqlCommand(sorgu, baglanti);
            komut.CommandType = CommandType.Text;
            komut.ExecuteNonQuery();
            int bosYer = int.Parse(komut.ExecuteScalar().ToString());
            baglanti.Close();
            baglanti.Dispose();
            return bosYer;
        }

        internal int toplamArac()
        {
            Baglan();
            string sorgu = "select count(*) from tbl_Arac where Durumu = 'A'";
            komut = new SqlCommand(sorgu, baglanti);
            komut.CommandType = CommandType.Text;
            komut.ExecuteNonQuery();
            int toplamArac = int.Parse(komut.ExecuteScalar().ToString());
            baglanti.Close();
            baglanti.Dispose();
            return toplamArac;
        }
    }
}
