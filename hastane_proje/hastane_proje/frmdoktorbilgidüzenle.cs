﻿using System;
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
    public partial class frmdoktorbilgidüzenle : Form
    {
        public frmdoktorbilgidüzenle()
        {
            InitializeComponent();
        }
        sqlbaglantisi blg = new sqlbaglantisi();
        public string tc;
        private void frmdoktorbilgidüzenle_Load(object sender, EventArgs e)
        {
            msktc.Text = tc;

            SqlCommand komut = new SqlCommand("Select * From Tbl_Doktorlar where DoktorTC=@p1",blg.baglanti());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtad.Text = dr[1].ToString();
                txtsoyad.Text = dr[2].ToString();
                cmbbrans.Text = dr[3].ToString();
                txtsifre.Text = dr[5].ToString();

            }
            blg.baglanti().Close();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 where DoktorTC=@p5",blg.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbbrans.Text);
            komut.Parameters.AddWithValue("@p4", txtsifre.Text);
            komut.Parameters.AddWithValue("@p5", msktc.Text);
            komut.ExecuteNonQuery();
            blg.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi");

        }
    }
}
