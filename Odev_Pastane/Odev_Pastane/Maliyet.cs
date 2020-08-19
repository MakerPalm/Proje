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
    public partial class Maliyet : Form
    {
        //veritabanı bağlantısını oluşturuyoruz
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VOOP8II;Initial Catalog=Odev;Integrated Security=True");
       
        public Maliyet()
        {
            InitializeComponent();
        }

        void KasaListe()
        {
            SqlDataAdapter da3 = new SqlDataAdapter("select * from TBL_KASA", con);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;
        }

        //Malzeme listesini getirecek metod
        void MalzemeListe()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_MALZEMELER", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt; 
            
        }
        void Urunler()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select* from TBL_URUNLER", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmb_Urun.ValueMember = "ID";
            cmb_Urun.DisplayMember = "AD";
            cmb_Urun.DataSource = dt;
            con.Close();

        }
       void Malzemeler()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select*from TBL_MALZEMELER", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmb_malzeme.ValueMember = "URUNID";
            cmb_malzeme.DisplayMember = "AD";
            cmb_malzeme.DataSource = dt;
            con.Close();
        }
        //Urun listesini getirecek metod
        void UrunListesi()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select * From TBL_URUNLER", con);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }
        private void Maliyet_Load(object sender, EventArgs e)
        {
            Urunler();
            //Malzemeler();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void BtnMalzeme_Click(object sender, EventArgs e)
        {
            MalzemeListe();


        }

        private void BtnUrun_Click(object sender, EventArgs e)
        {
            UrunListesi();
        }

        private void BtnKasa_Click(object sender, EventArgs e)
        {
            KasaListe();
        }

        private void btn_mal_ekle_Click(object sender, EventArgs e)
        {
            //connectionu açtık
            con.Open();
            //Classtan objeyi yaptık abstract classtan id verisini aldık
            Malzemeler malzeme = new Malzemeler();
            SqlCommand ekle = new SqlCommand("insert into TBL_MALZEMELER (ad,stok,fiyat,notlar) values (@AD,@STOK,@FIYAT,@NOTLAR)", con);
            malzeme.AD = MalzemeAD.Text;
            malzeme.STOK = Convert.ToDouble(MalzemeStok.Text);
            malzeme.FIYAT = Convert.ToDouble(MalzemeFiyat.Text);
            malzeme.NOTLAR = MalzemeNot.Text;
            ekle.Parameters.AddWithValue("@AD", malzeme.AD);
            ekle.Parameters.AddWithValue("@STOK", malzeme.STOK);
            ekle.Parameters.AddWithValue("@FIYAT", malzeme.FIYAT);
            ekle.Parameters.AddWithValue("@NOTLAR", malzeme.NOTLAR);
            ekle.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Malzeme Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MalzemeListe();
        }

        private void btn_urun_ekle_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun();
            con.Open();
            SqlCommand ekle = new SqlCommand("insert into TBL_URUNLER (ad,mfiyat,sfiyat,stok) values (@AD,@MFIYAT,@SFIYAT,@STOK)", con);
            urun.AD = Urun_AD.Text;
            urun.M_FIYAT = Convert.ToDouble(Urun_m_fiyat.Text);
            urun.S_FIYAT = Convert.ToDouble(Urun_s_fiyat.Text);
            urun.STOK = Convert.ToDouble(Urun_Stok.Text);
            ekle.Parameters.AddWithValue("@AD", urun.AD);
            ekle.Parameters.AddWithValue("@MFIYAT", urun.M_FIYAT);
            ekle.Parameters.AddWithValue("@SFIYAT", urun.S_FIYAT);
            ekle.Parameters.AddWithValue("@STOK", urun.STOK);
            ekle.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Urunler Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UrunListesi();

        }
        private void urun_ol_ekle_Click(object sender, EventArgs e)
        {
            Urun_2 uRuN = new Urun_2();
            con.Open();
            SqlCommand ekle = new SqlCommand("insert into TBL_FIRIN (ad,malzeme,miktar,maliyet) values (@AD,@MALZEME,@MIKTAR,@MALIYET)", con);
            uRuN.AD = cmb_malzeme.Text;
            uRuN.MALZEME = cmb_Urun.Text;
            uRuN.MIKTAR = Convert.ToDouble(urun_miktar.Text);
            uRuN.MALIYET = Convert.ToDouble(urun_maliyet.Text);
            ekle.Parameters.AddWithValue("@AD", uRuN.AD);
            ekle.Parameters.AddWithValue("@MALZEME", uRuN.MALZEME);
            ekle.Parameters.AddWithValue("@MIKTAR", uRuN.MIKTAR);
            ekle.Parameters.AddWithValue("@MALIYET", uRuN.MALIYET);
            ekle.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("malzeme eklendi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Malzeme_temizle_Click(object sender, EventArgs e)
        {
            MalzemeAD.Text = "";
            MalzemeFiyat.Text = "";
            MalzemeID.Text = "";
            MalzemeStok.Text = "";
            MalzemeNot.Text = "";
        }

        private void Urun_Temizle_Click(object sender, EventArgs e)
        {
            Urun_ID.Text = "";
            Urun_AD.Text = "";
            Urun_m_fiyat.Text = "";
            Urun_s_fiyat.Text = "";
            Urun_Stok.Text = "";
        }

        private void Urunol_temizle_Click(object sender, EventArgs e)
        {
            cmb_Urun.Text = "";
            cmb_malzeme.Text = "";
            urun_miktar.Text = "";
            urun_maliyet.Text = "";
        }

        private void urun_miktar_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void cmb_malzeme_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

        }
    }
}
