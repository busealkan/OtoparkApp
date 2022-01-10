using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H5190059_BuseAlkan.Sınıflar.Varliklar
{
    class Fiyat
    {
        private int ıd;
        private decimal sifirBirSaatFiyat;
        private decimal birIkiSaatFiyat;
        private decimal ıkiDortSaatFiyat;
        private decimal dortAltiSaatFiyat;
        private decimal gunBoyuSaatFiyat;
        private char durumu;
        private string aciklama;

        public int Id { get => ıd; set => ıd = value; }
        public decimal SifirBirSaatFiyat { get => sifirBirSaatFiyat; set => sifirBirSaatFiyat = value; }
        public decimal BirIkiSaatFiyat { get => birIkiSaatFiyat; set => birIkiSaatFiyat = value; }
        public decimal IkiDortSaatFiyat { get => ıkiDortSaatFiyat; set => ıkiDortSaatFiyat = value; }
        public decimal DortAltiSaatFiyat { get => dortAltiSaatFiyat; set => dortAltiSaatFiyat = value; }
        public decimal GunBoyuSaatFiyat { get => gunBoyuSaatFiyat; set => gunBoyuSaatFiyat = value; }
        public char Durumu { get => durumu; set => durumu = value; }
        public string Aciklama { get => aciklama; set => aciklama = value; }
    }
}
