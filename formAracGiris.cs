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
    public partial class formAracGiris : Form
    {
        public formAracGiris()
        {
            InitializeComponent();
            Load += formAracGiris_Load;
        }

        private void button_AracGirisYap_Click(object sender, EventArgs e)
        {
            
            Arac arc = new Arac();
            arc.Marka = textBox_Marka.Text;
            arc.Model = textBox_Model.Text;
            arc.Plaka = textBox_Plaka.Text;
            arc.MusteriId = int.Parse(textBox_MusteriId.Text);
            arc.AracGirisTarihi = DateTime.Now;
           
            arc.Durumu = 'A';

            if (textBox_Plaka.Text == "")
            {
                
                label_Message.Text = "Zorunlu Alanları Doldurunuz.";
                
            }
            else
            {
                if ((textBox_Plaka.TextLength < 7) || (textBox_Plaka.TextLength > 9))
                {

                    label_Message.Text = "Plakayı Doğru Giriniz!";

                }
                else
                {
                    button_AracGirisYap.Enabled = true;
                    AracVeritabani arcVt = new AracVeritabani();

                    Alanlar aln = new Alanlar();
                    AlanlarVeritabani alnVt = new AlanlarVeritabani();
                    int bosYer = alnVt.toplamBosYer();

                    if (bosYer == 0)
                    {
                        label_Message.Text = "Otopark Dolu";

                    }
                    else
                    {
                        label_Message.Text = "Araç Giriş Başarılı. Id : " + arcVt.EkleVeIdDon(arc).ToString();

                    }
                }
            }
        }

        private void button_Temizle_Click(object sender, EventArgs e)
        {
            textBox_Marka.Text = "";
            textBox_Model.Text = "";
            textBox_Plaka.Text = "";
            textBox_MusteriId.Text = "0";
            textBox_SecileneGoreAra.Text = "";
            comboBox_AramaKriteri.Text = "Arama Kriteri Seçiniz";
            label_Message.Text = "";


        }

        private void button_MusteriEkle_Click(object sender, EventArgs e)
        {
            formMusteri frmMusteri = new formMusteri();
            frmMusteri.ShowDialog();
        }

        private void formAracGiris_Load(object sender, EventArgs e)
        {
            textBox_MusteriId.Text = "0";
            label_Message.Text = "";
            MusteriVeritabani mstrVt = new MusteriVeritabani();
            dataGridView_Musteriler.DataSource = mstrVt.Listele();
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
            textBox_MusteriId.Text = dataGridView_Musteriler.SelectedRows[0].Cells["Id"].Value.ToString();
            
        }
    }
}
