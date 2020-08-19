
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Odev_Pastane
{
    class Malzemeler:Identification
    {
        private int m_id;
        private string ad;
        private double stok;
        private double fiyat;
        private string notlar;
        
        public override int ID
        {
            get { return m_id; }
            set { m_id = value; }
        }
        public string AD
        {
            get { return ad; }
            set { ad = value; }
        }
        public double STOK
        {
            get { return stok; }
            set { stok = value; }
        }
        public double FIYAT
        {
            get { return fiyat; }
            set { fiyat = value; }
        }
        public string NOTLAR
        {
            get { return notlar; }
            set { notlar = value; }
        }
    }
}