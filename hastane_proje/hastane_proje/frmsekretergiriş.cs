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
    public partial class frmsekretergiriş : Form
    {
        public frmsekretergiriş()
        {
            InitializeComponent();
        }
        sqlbaglantisi blg = new sqlbaglantisi();

        private void btngiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Sekreterler where SekreterTC=@p1 and SekreterSifre=@p2", blg.baglanti());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                frmsekreterdetay fr = new frmsekreterdetay();
                fr.tc = msktc.Text;
                fr.Show();
                this.Hide();
           
            }
            else
            {
                MessageBox.Show("Hatalı TC veya şifre");
            }
            blg.baglanti().Close();
                
        }
    }
}
