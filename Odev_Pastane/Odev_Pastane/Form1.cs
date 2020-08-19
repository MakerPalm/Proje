using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Odev_Pastane
{
    /****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
** NESNEYE DAYALI PROGRAMLAMA DERSİ
** 2019-2020 YAZ DÖNEMİ
**
** PROJE NUMARASI.........: 01
** ÖĞRENCİ ADI : emirhan mahir küçük
** ÖĞRENCİ NUMARASI.......: b181200016
** DERSİN ALINDIĞI GRUP...: A
****************************************************************************/
    public partial class Form1 : Form
    {

        Maliyet mr;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text=="admin" &&textBox2.Text=="admin")
            //{
            //    mr = new Maliyet();
            //    mr.Show();
            //    this.Hide();
            //} else
            //{
            //    MessageBox.Show("Kullanici Adi: admin Sifre : admin deneyiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
                mr = new Maliyet();
                mr.Show();
               this.Hide();
        }
    }
}
