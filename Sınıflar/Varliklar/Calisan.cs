using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H5190059_BuseAlkan.Sınıflar.Varliklar
{
    class Calisan
    {
        public int ıd;
        public string adi;
        public string soyadi;
        public char durumu;
        public DateTime baslamaTarihi;
        public DateTime guncellemeTarihi;
        public string email;
        public string kAdi;
        public string parola;
        public string telefon;
        public string adres;
        public string tCKN;

        public int Id { get => ıd; set => ıd = value; }
        public string Adi { get => adi; set => adi = value; }
        public string Soyadi { get => soyadi; set => soyadi = value; }
        public char Durumu { get => durumu; set => durumu = value; }
        public DateTime BaslamaTarihi { get => baslamaTarihi; set => baslamaTarihi = value; }
        public DateTime GuncellemeTarihi { get => guncellemeTarihi; set => guncellemeTarihi = value; }
        public string Email { get => email; set => email = value; }
        public string KAdi { get => kAdi; set => kAdi = value; }
        public string Parola { get => parola; set => parola = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public string Adres { get => adres; set => adres = value; }
        public string TCKN { get => tCKN; set => tCKN = value; }
    }
}
