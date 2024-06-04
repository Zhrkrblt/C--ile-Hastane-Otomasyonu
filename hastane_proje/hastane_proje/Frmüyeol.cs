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
    public partial class Frmüyeol : Form
    {
        public Frmüyeol()
        {
            InitializeComponent();
        }

        private void Frmüyeol_Load(object sender, EventArgs e)
        {

        }
        sqlbaglantisi blg = new sqlbaglantisi();
        private void btnüyeol2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar(HastaTC,HastaAd,HastaSoyad,HastaTelefon,Hastasifre,HastaCinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)", blg.baglanti());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            komut.Parameters.AddWithValue("@p2", txtad.Text);
            komut.Parameters.AddWithValue("@p3", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p4", msktlf.Text);
            komut.Parameters.AddWithValue("@p5", txtsifre.Text);
            komut.Parameters.AddWithValue("@p6", cmbcinsiyet.Text);
            komut.ExecuteNonQuery();
            blg.baglanti().Close();
            MessageBox.Show("Kaydınız gerçekleşmiştir şifreniz:" + txtsifre.Text,"bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
