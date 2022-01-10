using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H5190059_BuseAlkan.Sınıflar.Varliklar
{
    class Arac
    {
        private int ıd;
        private string marka;
        private string model;
        private string plaka;
        private int musteriId;
        private DateTime aracGirisTarihi;
        private DateTime aracCikisTarihi;
        private char durumu;

        public int Id { get => ıd; set => ıd = value; }
        public string Marka { get => marka; set => marka = value; }
        public string Model { get => model; set => model = value; }
        public string Plaka { get => plaka; set => plaka = value; }
        public int MusteriId { get => musteriId; set => musteriId = value; }
        public DateTime AracGirisTarihi { get => aracGirisTarihi; set => aracGirisTarihi = value; }
        public DateTime AracCikisTarihi { get => aracCikisTarihi; set => aracCikisTarihi = value; }
        public char Durumu { get => durumu; set => durumu = value; }
    }
}
