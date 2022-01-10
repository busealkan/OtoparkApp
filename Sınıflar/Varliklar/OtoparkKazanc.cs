using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H5190059_BuseAlkan.Sınıflar.Varliklar
{
    class OtoparkKazanc
    {
        private int ıd;
        private int aracId;
        private decimal ucret;
        private string tarih;
        private int saat;

        public int Id { get => ıd; set => ıd = value; }
        public int AracId { get => aracId; set => aracId = value; }
        public decimal Ucret { get => ucret; set => ucret = value; }
        public string Tarih { get => tarih; set => tarih = value; }
        public int Saat { get => saat; set => saat = value; }
    }
}
