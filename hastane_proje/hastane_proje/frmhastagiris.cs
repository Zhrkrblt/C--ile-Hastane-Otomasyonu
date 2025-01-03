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
    public partial class frmhastagiris : Form
    {
        public frmhastagiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi blg = new sqlbaglantisi();
        private void lnküyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frmüyeol fr = new Frmüyeol();
            fr.Show();
            
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar where HastaTc=@p1 and HastaSifre=@p2", blg.baglanti());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr =komut.ExecuteReader();
            if (dr.Read())
            {
                frmhastadetay fr = new frmhastadetay();
                fr.tc = msktc.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya Şifre");
                
            }
            blg.baglanti().Close();

            
        }
    }
}
