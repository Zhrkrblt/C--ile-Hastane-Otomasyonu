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
    public partial class Frmrandevulistesi : Form
    {
        public Frmrandevulistesi()
        {
            InitializeComponent();
        }
        sqlbaglantisi blg = new sqlbaglantisi();
        private void Frmrandevulistesi_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From tbl_randevular", blg.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public int secilen;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
    }
}
