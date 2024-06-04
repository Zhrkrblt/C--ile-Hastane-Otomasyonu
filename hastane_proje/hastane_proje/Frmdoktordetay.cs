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
    public partial class Frmdoktordetay : Form
    {
        public Frmdoktordetay()
        {
            InitializeComponent();
        }
        sqlbaglantisi blg = new sqlbaglantisi();
        public string tc;
        private void Frmdoktordetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = tc;

            // Doktor Ad Soyad Çekme
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorTC=@p1", blg.baglanti());
            komut.Parameters.AddWithValue("@p1", lbltc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0] + " " +dr[1];
            }
            blg.baglanti().Close();

            //Randevular
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From tbl_randevular where RandevuDoktor='" + lbladsoyad.Text + "'", blg.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btndegistir_Click(object sender, EventArgs e)
        {
            frmdoktorbilgidüzenle fr = new frmdoktorbilgidüzenle();
            fr.tc = lbltc.Text;
            fr.Show();
        }

        private void btnduyurular_Click(object sender, EventArgs e)
        {
            frmduyurular fr = new frmduyurular();
            fr.Show();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            rchsikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
