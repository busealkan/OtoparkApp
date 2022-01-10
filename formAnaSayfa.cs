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
    public partial class formAnaSayfa : Form
    {

        public formAnaSayfa()
        {
            InitializeComponent();
            Load += formAnaSayfa_Load;
            dataGridView_BosAlanlar.DefaultCellStyle.ForeColor = System.Drawing.Color.MidnightBlue;

        }

        private void formAnaSayfa_Load(object sender, EventArgs e)
        {
            toplamArac();
            toplamBosYer();
            toplamKapasite();
            kasaToplamUcret();
            toplamParkSaati();
            AlanlarVeritabani alnVt = new AlanlarVeritabani();
            dataGridView_BosAlanlar.DataSource = alnVt.Listele();

        }
        private  void toplamParkSaati()
        {
            OtoparkKazanc otoPrkKznc = new OtoparkKazanc();
            OtoparkKazancVeritabani otoPrkKzncVt = new OtoparkKazancVeritabani();
            
            if (otoPrkKzncVt.cikisYapanArac() == 0)
            {
                label_ToplamParkSaati.Text = "0 Saat";
            }
            else
            {
                int parkSaat = otoPrkKzncVt.toplamParkSaati();
                label_ToplamParkSaati.Text = parkSaat.ToString() + " Saat";
            }
           
        }
        private  void kasaToplamUcret()
        {
            OtoparkKazanc otoPrkKznc = new OtoparkKazanc(); 
            OtoparkKazancVeritabani otoPrkKzncVt = new OtoparkKazancVeritabani();
            if (otoPrkKzncVt.cikisYapanArac() == 0)
            {
                label_KasaToplamUcret.Text = "0 TL";
            }
            else
            {
                string kazanc = otoPrkKzncVt.kasaToplamUcret().ToString();
                label_KasaToplamUcret.Text =  kazanc+ " TL";
            }

            
        }
        private  void toplamKapasite()
        {
            Alanlar aln = new Alanlar();
            AlanlarVeritabani alnVt = new AlanlarVeritabani();
            int kapasite = alnVt.toplamKapasite();
            label_ToplamKapasite.Text = kapasite.ToString();
        }
        private  void toplamBosYer()
        {
            Alanlar aln = new Alanlar();
            AlanlarVeritabani alnVt = new AlanlarVeritabani();
            int toplamBosYer = alnVt.toplamBosYer();
            label_BosYer.Text = toplamBosYer.ToString();
        }

        private  void toplamArac()
        {
            Alanlar aln = new Alanlar();
            AlanlarVeritabani alnVt = new AlanlarVeritabani();
            int toplamArac = alnVt.toplamArac();
            label_ToplamArac.Text = toplamArac.ToString();
        }

        private void pictureBox_MusteriEkle_Click(object sender, EventArgs e)
        {
            formMusteri frmMusteri = new formMusteri();
            frmMusteri.ShowDialog();
        }

        private void pictureBox_AracGiris_Click(object sender, EventArgs e)
        {
            formAracGiris frmAracGiris = new formAracGiris();
            frmAracGiris.ShowDialog();
        }

        private void pictureBox_AracCikis_Click(object sender, EventArgs e)
        {
            formAracCikis frmAracCikis = new formAracCikis();
            frmAracCikis.ShowDialog();
        }

        private void label_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
