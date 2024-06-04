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

namespace hastane_proje
{
    public partial class Frmbilgidüzenle : Form
    {
        public Frmbilgidüzenle()
        {
            InitializeComponent();
        }
        public string TCno;
        sqlbaglantisi blg = new sqlbaglantisi();
        private void Frmbilgidüzenle_Load(object sender, EventArgs e)
        {
            msktc.Text = TCno;
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar where HastaTC=@p1", blg.baglanti());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtad.Text = dr[1].ToString();
                txtsoyad.Text = dr[2].ToString();
                msktlf.Text = dr[4].ToString();
                txtsifre.Text = dr[5].ToString();
                cmbcinsiyet.Text = dr[6].ToString();
                                           
            }
            blg.baglanti().Close();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update Tbl_Hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,Hastasifre=@p4,HastaCinsiyet=@p5 where HastaTC=@p6",blg.baglanti());
            komut2.Parameters.AddWithValue("@p1", txtad);
            komut2.Parameters.AddWithValue("@p2", txtsoyad);
            komut2.Parameters.AddWithValue("@p3", msktlf);
            komut2.Parameters.AddWithValue("@p4", txtsifre);
            komut2.Parameters.AddWithValue("@p5", cmbcinsiyet);
            komut2.Parameters.AddWithValue("@p6", msktc);
            komut2.ExecuteNonQuery();
            blg.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
