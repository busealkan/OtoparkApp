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
    class FiyatVeriTabani : TemelVeritabani
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
            throw new NotImplementedException();
        }

        public override void Sil(object obj)
        {
            throw new NotImplementedException();
        }

        internal int fiyatListele(Arac arc)
        {
            Baglan();
            AracVeritabani arcVt = new AracVeritabani();

            string sorgu = "";
            if (arcVt.gunListele(arc) == 0)
            {
               
                if (arcVt.saatListele(arc) >= 0 && arcVt.saatListele(arc) <= 1)
                {
                    sorgu = "select (SifirBirSaatFiyat) from tbl_Fiyat";
                }
                if (arcVt.saatListele(arc) >= 1 && arcVt.saatListele(arc) <= 2)
                {
                    sorgu = "select (BirIkiSaatFiyat) from tbl_Fiyat";
                }
                if (arcVt.saatListele(arc) >= 2 && arcVt.saatListele(arc) <= 4)
                {
                    sorgu = "select (IkiDortSaatFiyat) from tbl_Fiyat";
                }
                if (arcVt.saatListele(arc) >= 4 && arcVt.saatListele(arc) <= 6)
                {
                    sorgu = "select (DortAltiSaatFiyat) from tbl_Fiyat";
                }
                if (arcVt.saatListele(arc) >= 6 && arcVt.saatListele(arc) <= 23)
                {
                    sorgu = "select (GunBoyuFiyat) from tbl_Fiyat";
                }


            }
            if (arcVt.gunListele(arc) > 0)
            {
                sorgu = "select (GunBoyuFiyat) from tbl_Fiyat";

            }

            komut = new SqlCommand(sorgu, baglanti);
            komut.CommandType = CommandType.Text;
            komut.ExecuteNonQuery();

            int fiyat = int.Parse(komut.ExecuteScalar().ToString().Replace(",",string.Empty));
            
            baglanti.Close();
            baglanti.Dispose();
            return fiyat;
        }
    }
}
