using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H5190059_BuseAlkan.Sınıflar.Varliklar
{
    class Musteri
    {
        private int ıd;
        private string adi;
        private string soyadi;
        private char durumu;
        private string email;
        private string telefon;
        private string adres;
        private string tCKN;

        public int Id { get => ıd; set => ıd = value; }
        public string Adi { get => adi; set => adi = value; }
        public string Soyadi { get => soyadi; set => soyadi = value; }
        public char Durumu { get => durumu; set => durumu = value; }
        public string Email { get => email; set => email = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public string Adres { get => adres; set => adres = value; }
        public string TCKN { get => tCKN; set => tCKN = value; }
    }
}
