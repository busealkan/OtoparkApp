using H5190059_BuseAlkan.Sınıflar.Varliklar;
using H5190059_BuseAlkan.Sınıflar.Veritabanı;
using System;
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
    public partial class formSifreGuncelle : Form
    {
        public formSifreGuncelle()
        {
            InitializeComponent();
        }
        public formSifreGuncelle(Object obj)
        {
            Calisan cls = (Calisan)obj;
            InitializeComponent();
            textBox_KAdiEmail.Text = cls.Email;
        }

        private void button_Cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_SifreGuncelle_Click(object sender, EventArgs e)
        {
            if (textBox_Sifre.Text != textBox_SifreTekrarı.Text)
            {
                label_Message.Text = "Şifre ve Tekrarı eşleşmemektedir.";
            }
            else
            {
                Calisan cls = new Calisan();
                CalisanVeritabani clsVt = new CalisanVeritabani();
                cls.KAdi = textBox_KAdiEmail.Text;
                cls.Email = textBox_KAdiEmail.Text;
                cls.Parola = textBox_SifreTekrarı.Text;
                try
                {
                    clsVt.Guncelle(cls);
                    label_Message.Text = "Şifre Günceleme başarılı ";
                }
                catch (Exception hata)
                {

                    label_Message.Text = "Hata : " + hata.Message;
                }

            }
        }

        private void formSifreGuncelle_Load(object sender, EventArgs e)
        {
            label_Message.Text = "";
        }
    }
}
