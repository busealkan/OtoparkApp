using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H5190059_BuseAlkan.Sınıflar.Varliklar
{
    class Alanlar
    {
        private int ıd;
        private string adi;
        private char durumu;

        public int Id { get => ıd; set => ıd = value; }
        public string Adi { get => adi; set => adi = value; }
        public char Durumu { get => durumu; set => durumu = value; }
    }
}
