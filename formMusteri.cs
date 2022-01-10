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
    public partial class formMusteri : Form
    {
        public formMusteri()
        {
            InitializeComponent();
            Load += formMusteri_Load;
            dataGridView_Musteriler.DefaultCellStyle.ForeColor = System.Drawing.Color.MidnightBlue;
        }

        private void formMusteri_Load(object sender, EventArgs e)
        {
            Temizle();
            MusteriListele();
        }
        private void button_Ekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_Adi.Text == "" || textBox_Soyadi.Text == "" || textBox_Telefon.Text == "" || textBox_Email.Text == "" || textBox_TCKN.Text == "" || richTextBox_Adres.Text == "")
                {

                    label_Message.Text = "Zorunlu Alanları Doldurunuz!";

                }
                else if (!(textBox_TCKN.TextLength == 11))
                {

                    label_Message.Text = "TCKN Alanına 11 Karakter Giriniz!";

                }
                else
                {
                    Musteri mstr = new Musteri();
                    mstr.Adi = textBox_Adi.Text;
                    mstr.Soyadi = textBox_Soyadi.Text;
                    mstr.Telefon = textBox_Telefon.Text;
                    mstr.TCKN = textBox_TCKN.Text;
                    mstr.Adres = richTextBox_Adres.Text;
                    mstr.Email = textBox_Email.Text;

                    MusteriVeritabani mstrVt = new MusteriVeritabani();
                    textBox_Id.Text = mstrVt.EkleVeIdDon(mstr).ToString();
                    label_Message.Text = "Müşteri Ekleme Başarılı. Id : " + textBox_Id.Text;
                    MusteriListele();
                }
                
            }
            catch (Exception hata)
            {

                label_Message.Text = "Hata : " + hata.Message.ToString();
            }

        }

        public void MusteriListele()
        {
            MusteriVeritabani mstrVt = new MusteriVeritabani();
            dataGridView_Musteriler.DataSource = mstrVt.Listele();
        }

        private void button_Guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                Musteri mstr = new Musteri();
                mstr.Adi = textBox_Adi.Text;
                mstr.Soyadi = textBox_Soyadi.Text;
                mstr.Telefon = textBox_Telefon.Text;
                mstr.TCKN = textBox_TCKN.Text;
                mstr.Adres = richTextBox_Adres.Text;
                mstr.Email = textBox_Email.Text;
                mstr.Id = int.Parse(textBox_Id.Text);

                MusteriVeritabani mstrVt = new MusteriVeritabani();
                mstrVt.Guncelle(mstr);
                label_Message.Text = "Müşteri güncelleme Başarılı.";
                MusteriListele();
            }
            catch (Exception hata)
            {

                label_Message.Text = "Hata(Günceleme) : " + hata.Message.ToString();
            }
        }

        private void button_Temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            textBox_Adi.Text = "";
            textBox_Email.Text = "";
            textBox_Id.Text = "";
            textBox_Soyadi.Text = "";
            textBox_TCKN.Text = "";
            comboBox_AramaKriteri.Text = "Arama Kriteri Seçiniz";
            textBox_Telefon.Text = "";
            richTextBox_Adres.Text = "";
            textBox_SecileneGoreAra.Text = "";
            button_Guncelle.Enabled = false;
            button_Sil.Enabled = false;
            label_Message.Text = "";
        }
        private void button_Sil_Click(object sender, EventArgs e)
        {
            try
            {
                Musteri mstr = new Musteri();
                mstr.Id = int.Parse(textBox_Id.Text);
                MusteriVeritabani mstrVt = new MusteriVeritabani();
                mstrVt.Sil(mstr);
                MusteriListele();
                label_Message.Text = "Id: " + mstr.Id + " Silme Başarılı";
            }
            catch (Exception hata)
            {

                label_Message.Text = "Silerken Hata Oluştu : " + hata.Message;
            }
        }



        private void textBox_Id_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Id.Text != "0" && !string.IsNullOrEmpty(textBox_Id.Text))
            {
                button_Guncelle.Enabled = true;
                button_Sil.Enabled = true;
            }
            else
            {
                button_Guncelle.Enabled = false;
                button_Sil.Enabled = false;
            }
        }

        private void textBox_SecileneGoreAra_TextChanged(object sender, EventArgs e)
        {
            if (comboBox_AramaKriteri.Text != "Arama Kriteri Seçiniz")
            {
                MusteriVeritabani mstrVt = new MusteriVeritabani();
                Musteri mstr = new Musteri();
                try
                {

                    if (comboBox_AramaKriteri.Text == "Adina Göre Ara")
                    {
                        mstr.Adi = textBox_SecileneGoreAra.Text;
                    }
                    else if (comboBox_AramaKriteri.Text == "Soyadina Göre Ara")
                    {
                        mstr.Soyadi = textBox_SecileneGoreAra.Text;
                    }
                    else if (comboBox_AramaKriteri.Text == "Emailine Göre Ara")
                    {
                        mstr.Email = textBox_SecileneGoreAra.Text;
                    }
                    else if (comboBox_AramaKriteri.Text == "TCKN'ye Göre Ara")
                    {
                        mstr.TCKN = textBox_SecileneGoreAra.Text;
                    }
                    else
                    {
                        label_Message.Text = "Hatalı arama kriteri seçtiniz!";
                    }

                    dataGridView_Musteriler.DataSource = mstrVt.Listele(mstr);
                    label_Message.Text = "";
                }
                catch (Exception hata)
                {

                    label_Message.Text = "Arama Hata : " + hata.Message.ToString();
                }
            }
            else
            {
                label_Message.Text = "Arama Kriteri Seçiniz !";
            }
        }

        private void dataGridView_Musteriler_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox_Email.Text = dataGridView_Musteriler.SelectedRows[0].Cells["Email"].Value.ToString();
            textBox_Id.Text = dataGridView_Musteriler.SelectedRows[0].Cells["Id"].Value.ToString();
            textBox_Adi.Text = dataGridView_Musteriler.SelectedRows[0].Cells["Adi"].Value.ToString();
            textBox_Soyadi.Text = dataGridView_Musteriler.SelectedRows[0].Cells["Soyadi"].Value.ToString();
            textBox_TCKN.Text = dataGridView_Musteriler.SelectedRows[0].Cells["TCKN"].Value.ToString();
            textBox_Telefon.Text = dataGridView_Musteriler.SelectedRows[0].Cells["Telefon"].Value.ToString();
            richTextBox_Adres.Text = dataGridView_Musteriler.SelectedRows[0].Cells["Adres"].Value.ToString();
        }

       
    }
}
