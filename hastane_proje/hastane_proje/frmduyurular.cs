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
    public partial class frmduyurular : Form
    {
        public frmduyurular()
        {
            InitializeComponent();
        }
        sqlbaglantisi blg = new sqlbaglantisi();
        private void frmduyurular_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Duyurular", blg.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
