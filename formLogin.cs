using H5190059_BuseAlkan.Sınıflar.Varliklar;
using H5190059_BuseAlkan.Sınıflar.Veritabanı;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H5190059_BuseAlkan
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
            Load += FormLogin_Load;
            label_Message.Text = "";
            if (checkBox_BeniHatirla.Checked == true)
            {
                linkLabel_SifremiUnuttum.Visible = true;
            }
            else
            {
                linkLabel_SifremiUnuttum.Visible = false;
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.KAdi != string.Empty)
            {
                if (Properties.Settings.Default.BeniHatirla == true)
                {
                    txt_KAdiEamil.Text = Properties.Settings.Default.KAdi;
                    txt_Parola.Text = Properties.Settings.Default.Parola;
                    checkBox_BeniHatirla.Checked = true;
                }
            }
        }

        private void button_Giris_Click(object sender, EventArgs e)
        {
            /*
             * veritabanı bağlanacak
             * sorgu çekicek
             * Eğer kaydımız veritabanında varsa Anasayfa yönledirecek
             * Yoksada kullanıcı 
             */
            try
            {
                Calisan cls = new Calisan();
                cls.Email = txt_KAdiEamil.Text;
                cls.KAdi = txt_KAdiEamil.Text;
                cls.Parola = txt_Parola.Text;


                CalisanVeritabani clsVt = new CalisanVeritabani();

                DataTable tablo = new DataTable();
                tablo = clsVt.Listele(cls);

                if (tablo.Rows.Count > 0)
                {
                    if (cls.Parola == tablo.Rows[0]["SifremiUnuttum"].ToString())
                    {
                        formSifreGuncelle frmSifreGuncelle = new formSifreGuncelle(cls);
                        frmSifreGuncelle.ShowDialog();
                    }
                    else
                    {
                        Login.Adi = tablo.Rows[0]["Adi"].ToString();
                        Login.Email = tablo.Rows[0]["Email"].ToString();
                        Login.KAdi = tablo.Rows[0]["KAdi"].ToString();
                        Login.Id = int.Parse(tablo.Rows[0]["Id"].ToString());
                        Login.Soyadi = tablo.Rows[0]["Soyadi"].ToString();
                        Login.Parola = tablo.Rows[0]["Parola"].ToString();
                        Login.Telefon = tablo.Rows[0]["Telefon"].ToString();
                        Login.TCKN = tablo.Rows[0]["TCKN"].ToString();
                        Login.Adres = tablo.Rows[0]["Adres"].ToString();




                        // İşlem doğruysa tam bu satırda anasayfaya geçiyoruz !
                        if (checkBox_BeniHatirla.Checked == true)
                        {
                            Properties.Settings.Default.KAdi = txt_KAdiEamil.Text;
                            Properties.Settings.Default.Parola = txt_Parola.Text;
                            Properties.Settings.Default.BeniHatirla = true;
                            Properties.Settings.Default.Save();
                        }
                        else
                        {
                            Properties.Settings.Default.KAdi = string.Empty;
                            Properties.Settings.Default.Parola = string.Empty;
                            Properties.Settings.Default.BeniHatirla = false;
                            Properties.Settings.Default.Save();
                        }

                        formAnaSayfa frm = new formAnaSayfa();
                        frm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    label_Message.Text = "Kullanıcı bilgileri hatalı !";
                }

            }
            catch (Exception hata)
            {

                label_Message.Text = "Giriş hata : " + hata.Message.ToString();
            }


        }

        private void label_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_Cikis_MouseHover(object sender, EventArgs e)
        {
            label_Cikis.ForeColor = Color.Red;
        }

        private void label_Cikis_MouseLeave(object sender, EventArgs e)
        {
            label_Cikis.ForeColor = Color.White;
        }

        private void linkLabel_SifremiUnuttum_Click(object sender, EventArgs e)
        {
            Calisan cls = new Calisan();
            Random rnd = new Random();
            cls.Parola = rnd.Next(100000, 999999).ToString();
            cls.KAdi = txt_KAdiEamil.Text;
            cls.Email = txt_KAdiEamil.Text;
            CalisanVeritabani clsVt = new CalisanVeritabani();
            cls.Email = clsVt.SifremiUnuttum(cls);
            if (string.IsNullOrEmpty(cls.Email))
            {
                label_Message.Text = "Kullanıcı Adı yada Email sistemde tanımlı değil";
            }
            else
            {
                ArrayList epostaAdresleri = new ArrayList();
                epostaAdresleri.Add(cls.Email);
                string govde = "Şifreniz : " + cls.Parola;
                clsVt.MailGonder(epostaAdresleri, "Şifremi Unuttum", govde, "Car Park");
                label_Message.Text = "Şifreniz Mailinize gönderilmiştir";
            }


        }

        private void txt_KAdiEamil_TextChanged(object sender, EventArgs e)
        {
            CalisanVeritabani clsVt = new CalisanVeritabani();
            Calisan cls = new Calisan();
            cls.Email = txt_KAdiEamil.Text;
            cls.KAdi = txt_KAdiEamil.Text;
            if (clsVt.CalisanVarmi(cls))
            {
                linkLabel_SifremiUnuttum.Visible = true;
                label_Message.Text = "";
            }
            else
            {
                linkLabel_SifremiUnuttum.Visible = false;
                label_Message.Text = "Kullanıcı Adi veya Email Bulunamadı";
            }
        }

    }
}
