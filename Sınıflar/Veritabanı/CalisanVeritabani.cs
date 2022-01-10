using H5190059_BuseAlkan.Sınıflar.Varliklar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace H5190059_BuseAlkan.Sınıflar.Veritabanı
{
    class CalisanVeritabani : TemelVeritabani
    {
        public override void Ekle(object obj)
        {
            throw new NotImplementedException();
        }

        public override int EkleVeIdDon(object obj)
        {
            Calisan clsn = (Calisan)obj;
            Baglan();
            komut = new SqlCommand("usp_CalisanEkle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@Adi", clsn.Adi);
            komut.Parameters.AddWithValue("@Soyadi", clsn.Soyadi);
            komut.Parameters.AddWithValue("@Durumu", clsn.Durumu);
            komut.Parameters.AddWithValue("@BaslamaTarihi", clsn.BaslamaTarihi);
            komut.Parameters.AddWithValue("@GuncellemeTarihi", clsn.GuncellemeTarihi);
            komut.Parameters.AddWithValue("@Email", clsn.Email);
            komut.Parameters.AddWithValue("@KAdi", clsn.KAdi);
            komut.Parameters.AddWithValue("@Parola", clsn.Parola);
            komut.Parameters.AddWithValue("@Telefon", clsn.Telefon);
            komut.Parameters.AddWithValue("@Adres", clsn.Adres);
            komut.Parameters.AddWithValue("@TCKN", clsn.TCKN);
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
            Calisan cls = (Calisan)obj;
            Baglan();
            string sorgu = "update tbl_Calisan set Parola='" + cls.Parola + "' , IsSifreOlustur = 0 " +
                " where ( Email = '" + cls.Email + "' or KAdi = '" + cls.KAdi + "' ) ";
            komut = new SqlCommand(sorgu, baglanti);
            komut.CommandType = CommandType.Text;
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }

        public override DataTable Listele(object obj)
        {
            Calisan cls = (Calisan)obj;
            Baglan();
            string sorgu = "select * from View_Calisan where ( Email = '" + cls.Email + "' or KAdi = '" + cls.KAdi + "' ) " +
                            " and ( Parola = '" + cls.Parola + "' or ( SifremiUnuttum = '" + cls.Parola + "' and IsSifreOlustur = 1 ) ) and Durumu ='A'";
            komut = new SqlCommand(sorgu, baglanti);
            komut.CommandType = CommandType.Text;
            komut.ExecuteNonQuery();
            adaptor = new SqlDataAdapter(komut);
            tablo = new DataTable();
            adaptor.Fill(tablo);
            baglanti.Close();
            baglanti.Dispose();
            return tablo;
        }

        internal DataTable CalisanAra(object obj)
        {

            Calisan cls = (Calisan)obj;
            Baglan();

            if (!string.IsNullOrEmpty(cls.Adi) || !string.IsNullOrEmpty(cls.Soyadi) || !string.IsNullOrEmpty(cls.TCKN) || !string.IsNullOrEmpty(cls.Email))
            {
                string sorgu = "select Id,Adi,Soyadi,KAdi,Parola,Email,Telefon,TCKN,Adres,BaslamaTarihi,GuncellemeTarihi,Yetki,Durumu from tbl_Calisan ";
                if (!string.IsNullOrEmpty(cls.Adi))
                {
                    sorgu = sorgu + " where Adi like '%" + cls.Adi + "%'";
                }
                else if (!string.IsNullOrEmpty(cls.Soyadi))
                {
                    sorgu = sorgu + " where Soyadi like '%" + cls.Soyadi + "%'";
                }
                else if (!string.IsNullOrEmpty(cls.TCKN))
                {
                    sorgu = sorgu + " where TCKN like '%" + cls.TCKN + "%'";
                }
                else if (!string.IsNullOrEmpty(cls.Email))
                {
                    sorgu = sorgu + " where Email like '%" + cls.Email + "%'";
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

            }

            return tablo;
        }

        public override DataTable Listele()
        {
            Baglan();
            komut = new SqlCommand("select Id,Adi,Soyadi,Email,Telefon,TCKN,KAdi,Parola,BaslamaTarihi,GuncellemeTarihi,Durumu,Yetki,Adres from tbl_Calisan ", baglanti);
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
            Calisan cls = (Calisan)obj;
            Baglan();
            komut = new SqlCommand("delete tbl_Calisan Where Id = " + cls.Id, baglanti);
            komut.CommandType = CommandType.Text;
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }

        internal void CalisanKendiGuncelle(int calisanId, string adi, string soyadi, string email, string parola, string kadi, string tckn, string telefon, string adres)
        {
            Baglan();
            string sorgu = "update tbl_Calisan set Adi='" + adi + "', Soyadi='" + soyadi + "' ,Parola='" + parola + "' ,Email='" + email + "' ,KAdi='" + kadi + "', TCKN='" + tckn + "', Telefon='" + telefon + "', adres='" + adres + "',GuncellemeTarihi=GETDATE() where Id = '" + calisanId + "'";
            komut = new SqlCommand(sorgu, baglanti);
            komut.CommandType = CommandType.Text;
            komut.ExecuteNonQuery();
            adaptor = new SqlDataAdapter(komut);
            tablo = new DataTable();
            adaptor.Fill(tablo);
            baglanti.Close();
            baglanti.Dispose();

        }

        internal bool CalisanVarmi(Calisan cls)
        {
            bool varmi = false;
            Baglan();
            komut = new SqlCommand("select count(*) from tbl_Calisan where Email = @Email OR KAdi = @KAdi ", baglanti);
            komut.CommandType = CommandType.Text;
            komut.Parameters.AddWithValue("@Email", cls.Email);
            komut.Parameters.AddWithValue("@KAdi", cls.KAdi);
            int adet = int.Parse(komut.ExecuteScalar().ToString());
            baglanti.Close();
            baglanti.Dispose();

            if (adet > 0)
            {
                varmi = true;
            }

            return varmi;
        }

        internal string SifremiUnuttum(Calisan cls)
        {
            Baglan();
            komut = new SqlCommand("usp_SifremiUnuttum", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@Parola", cls.Parola);
            komut.Parameters.AddWithValue("@Email", cls.Email);
            komut.Parameters.AddWithValue("@KAdi", cls.KAdi);

            SqlParameter prm_Email = new SqlParameter("@VarEmail", SqlDbType.NVarChar, 200);
            prm_Email.Direction = ParameterDirection.Output;
            komut.Parameters.Add(prm_Email);

            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
            return prm_Email.Value.ToString();

        }

        internal void CalisanYetkiliGuncelle(Object obj)
        {

            Calisan clsn = (Calisan)obj;
            Baglan();
            string baslamaTarihi = clsn.BaslamaTarihi.ToString("yyyy-MM-dd HH:mm:ss");
            string guncellemeTarihi = clsn.GuncellemeTarihi.ToString("yyyy-MM-dd HH:mm:ss");

            string sorgu = "update tbl_Calisan " +
                            " set Adi=@Adi,Soyadi=@Soyadi,KAdi=@KAdi,Parola=@Parola,Email=@Email,Telefon=@Telefon,TCKN=@TCKN,Adres=@Adres,BaslamaTarihi=@BaslamaTarihi,GuncellemeTarihi=@GuncellemeTarihi,Yetki=@Yetki,Durumu=@Durumu" +
                            " where Id = " + clsn.Id;
            komut = new SqlCommand(sorgu, baglanti);
            komut.CommandType = CommandType.Text;
            komut.Parameters.AddWithValue("@Id", clsn.Id);
            komut.Parameters.AddWithValue("@Adi", clsn.Adi);
            komut.Parameters.AddWithValue("@Soyadi", clsn.Soyadi);
            komut.Parameters.AddWithValue("@Durumu", clsn.Durumu);
            komut.Parameters.AddWithValue("@BaslamaTarihi", baslamaTarihi);
            komut.Parameters.AddWithValue("@GuncellemeTarihi", guncellemeTarihi);
            komut.Parameters.AddWithValue("@Email", clsn.Email);
            komut.Parameters.AddWithValue("@KAdi", clsn.KAdi);
            komut.Parameters.AddWithValue("@Parola", clsn.Parola);
            komut.Parameters.AddWithValue("@Telefon", clsn.Telefon);
            komut.Parameters.AddWithValue("@Adres", clsn.Adres);
            komut.Parameters.AddWithValue("@TCKN", clsn.TCKN);


            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }
    }
}

