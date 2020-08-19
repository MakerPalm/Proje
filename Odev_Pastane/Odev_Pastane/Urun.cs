using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_Pastane
{
    class Urun:Identification
    {
        private int m_id;
        private string m_Ad;
        private double m_Stok;
        private double m_m_fiyat;
        private double m_s_fiyat;
        public override int ID
        {
            get { return m_id; }
            set { m_id = value; }
        }
        public string AD
        {
            get { return m_Ad; }
            set { m_Ad = value; }
        }
        public double STOK
        {
            get { return m_Stok; }
            set { m_Stok = value; }
        }
        public double M_FIYAT
        {
            get { return m_m_fiyat; }
            set { m_m_fiyat = value; }
        }
        public double S_FIYAT
        {
            get { return m_s_fiyat; }
            set { m_s_fiyat = value; }
        }

    }
}
