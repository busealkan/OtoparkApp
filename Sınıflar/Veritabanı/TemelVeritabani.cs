using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace H5190059_BuseAlkan.Sınıflar.Veritabanı
{
    abstract class TemelVeritabani
    {
        string yol = @"Data Source=BUSE\SQLEXPRESS;Initial Catalog=H5190059_BuseAlkanOtopark;Integrated Security=SSPI";
        public SqlDataAdapter adaptor;
        public SqlDataReader okuyucu;
        public DataTable tablo;
        public SqlCommand komut;
        public SqlConnection baglanti;
        public TemelVeritabani()
        {
            yol = @"Data Source=BUSE\SQLEXPRESS;Initial Catalog=H5190059_BuseAlkanOtopark;Integrated Security=SSPI";
        }

        public void Baglan()
        {
            // Veritabanı bağlanacak
            baglanti = new SqlConnection(yol);
            if (baglanti.State== ConnectionState.Closed)
            {
                baglanti.Open();
            }

        }
        // ArrayList -> Boyutsuz Diziler !
        public void MailGonder(ArrayList epostaAdresleri, string konu, string govdesi, string displayName)
        {
            MailMessage mail = new MailMessage();
            string email = ConfigurationManager.AppSettings["Email"].ToString();
            string parola = ConfigurationManager.AppSettings["Parola"].ToString();
            foreach (var epostalar in epostaAdresleri)
            {
                mail.To.Add(epostalar.ToString());
            }
            mail.Subject = konu;
            mail.Body = govdesi;
            mail.From = new MailAddress(email, displayName);
            mail.IsBodyHtml = true;
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.gmail.com";
            sc.EnableSsl = true;

            sc.Credentials = new NetworkCredential(email, parola);
            sc.EnableSsl = true;
            try
            {
                sc.Send(mail);
            }
            catch (Exception hata)
            {

                throw hata;
            }



        }
        abstract public void Ekle(object obj);
        abstract public int  EkleVeIdDon(object obj);
        abstract public void Sil(object obj);
        abstract public void Guncelle(object obj);

        abstract public DataTable Listele(object obj);

        abstract public DataTable Listele();

    }
}
