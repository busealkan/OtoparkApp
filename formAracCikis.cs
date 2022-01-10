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
    public partial class formAracCikis : Form
    {
        public formAracCikis()
        {
            InitializeComponent();
            Load += formAracCikis_Load;
        }

        private void formAracCikis_Load(object sender, EventArgs e)
        {
            label_Message.Text = "";
            label_ToplamSaat.Text = "";
            label_ToplamUcret.Text = "";
            
        }

        private void button_AracCikisYap_Click(object sender, EventArgs e)
        {
            try
            {
                Arac arc = new Arac();
                AracVeritabani arcVt = new AracVeritabani();
                arc.Plaka = textBox_Plaka.Text;

                if (arcVt.aracVarMi(arc) == true)
                {
                    int aracId = arcVt.aracIdGetir(arc);

                    


                    Fiyat fyt = new Fiyat();
                    FiyatVeriTabani fytVt = new FiyatVeriTabani();

                    OtoparkKazanc otoPrkKznc = new OtoparkKazanc();
                    otoPrkKznc.AracId = aracId;
                    string fiyat = fytVt.fiyatListele(arc).ToString().Substring(0, 2);
                    otoPrkKznc.Ucret = decimal.Parse(fiyat);
                    OtoparkKazancVeritabani otoPrkKzncVt = new OtoparkKazancVeritabani();
                    if (arcVt.gunListele(arc) >= 1)
                    {
                        otoPrkKznc.Saat = arcVt.saatListele(arc) + arcVt.gunListele(arc) * 24;
                        otoPrkKzncVt.Ekle(otoPrkKznc);
                    }
                    else
                    {
                        otoPrkKznc.Saat = arcVt.saatListele(arc);
                        otoPrkKzncVt.Ekle(otoPrkKznc);
                    }
                    


                    arcVt.Guncelle(arc);

                    label_Message.Text = "Araç Çıkış Başarılı";
                }
                else
                {
                    label_Message.Text = "Araç Bulunamadı.";
                }


                
            }
            catch (Exception hata)
            {
                label_Message.Text = hata.ToString();
            }

        }

        private void textBox_Plaka_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Arac arc = new Arac();
                AracVeritabani arcVt = new AracVeritabani();
                arc.Plaka = textBox_Plaka.Text;
               
                if (arcVt.aracVarMi(arc)==true)
                {
                    arcVt.cikisSaatGuncelle(arc);
                    Fiyat fyt = new Fiyat();
                    FiyatVeriTabani fytVt = new FiyatVeriTabani();

                    if(arcVt.gunListele(arc)==0 && arcVt.saatListele(arc) == 0)
                    {
                        label_ToplamSaat.Text = arcVt.gunListele(arc).ToString() + " Gün " + arcVt.saatListele(arc) + " Saat " + arcVt.dakikaListele(arc) + " Dakika";

                    }
                    else
                    {
                        label_ToplamSaat.Text = arcVt.gunListele(arc).ToString() + " Gün " + arcVt.saatListele(arc).ToString() + " Saat ";

                    }

                    label_ToplamUcret.Text = fytVt.fiyatListele(arc).ToString().Substring(0, 2) + " TL";
                }
                else
                {
                    label_Message.Text = "Araç Bulunamadı.";
                }

               

            }
            catch (Exception hata)
            {
                label_Message.Text = hata.ToString();
            }
        }
    }
}
