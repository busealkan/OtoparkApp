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
    class OtoparkKazancVeritabani : TemelVeritabani
    {
        public override void Ekle(object obj)
        {
            OtoparkKazanc otoPrkKznc = (OtoparkKazanc)obj;
            Baglan();
            string sorgu = "insert into tbl_OtoparkKazanc values('" + otoPrkKznc.AracId + "' ,'" + otoPrkKznc.Ucret + "',GETDATE(), '" + otoPrkKznc.Saat + "')";

            komut = new SqlCommand(sorgu, baglanti);
            komut.CommandType = CommandType.Text;
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
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
            throw new NotImplementedException();
        }

        public override void Sil(object obj)
        {
            throw new NotImplementedException();
        }

        internal int cikisYapanArac()
        {

            Baglan();

            string cikisTarihiBaslangic = DateTime.Now.Date.ToString("yyyy'-'MM'-'dd HH':'mm':'ss");
            string cikisTarihiBitis = DateTime.Now.Date.ToString("yyyy'-'MM'-'dd 23':'59':'00");

            string sorgu = "select Count(Id) from tbl_OtoparkKazanc where Tarih between '" + cikisTarihiBaslangic + "' and '" + cikisTarihiBitis + "'";
            komut = new SqlCommand(sorgu, baglanti);
            komut.CommandType = CommandType.Text;
            komut.ExecuteNonQuery();
            int cikis = int.Parse(komut.ExecuteScalar().ToString());
            
            baglanti.Close();
            baglanti.Dispose();
            return cikis;
        }
        internal string kasaToplamUcret()
        {
            
            Baglan();

            string cikisTarihiBaslangic = DateTime.Now.Date.ToString("yyyy'-'MM'-'dd HH':'mm':'ss");
            string cikisTarihiBitis = DateTime.Now.Date.ToString("yyyy'-'MM'-'dd 23':'59':'00");

            string sorgu = "select SUM(Ucret) from tbl_OtoparkKazanc where Tarih between '"+ cikisTarihiBaslangic+"' and '"+ cikisTarihiBitis+"'";
            komut = new SqlCommand(sorgu, baglanti);
            komut.CommandType = CommandType.Text;
            komut.ExecuteNonQuery();
            string kazanc = komut.ExecuteScalar().ToString();
            baglanti.Close();
            baglanti.Dispose();
            return kazanc;
        }
        internal int toplamParkSaati()
        {
            Baglan();
            string cikisTarihiBaslangic = DateTime.Now.Date.ToString("yyyy'-'MM'-'dd HH':'mm':'ss");
            string cikisTarihiBitis = DateTime.Now.Date.ToString("yyyy'-'MM'-'dd 23':'59':'00");
            string sorgu = "select SUM(Saat) from tbl_OtoparkKazanc where Tarih between '" + cikisTarihiBaslangic + "' and '" + cikisTarihiBitis + "'";
            komut = new SqlCommand(sorgu, baglanti);
            komut.CommandType = CommandType.Text;
            komut.ExecuteNonQuery();
            int saat = int.Parse(komut.ExecuteScalar().ToString());
            baglanti.Close();
            baglanti.Dispose();
            return saat;
        }
    }
}
