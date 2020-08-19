using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_Pastane
{
    class Urun_2 : Urun
    {
        private string m_ad;
        private string m_malzeme;
        private double miktar;
        private double maliyet;
        public string AD
        {
            get { return m_ad; }
            set { m_ad = value; }
        }
        public string MALZEME
        {
            get { return m_malzeme; }
            set { m_malzeme = value; }
        }

        public double MIKTAR
        {
            get { return miktar; }
            set { miktar = value; }

        }

        public double MALIYET
        {
            get { return maliyet; }
            set { maliyet = value;  }
        }
    }
}
