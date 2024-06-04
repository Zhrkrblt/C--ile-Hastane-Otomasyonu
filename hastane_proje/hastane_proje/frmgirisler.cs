using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastane_proje
{
    public partial class frmgirisler : Form
    {
        public frmgirisler()
        {
            InitializeComponent();
        }

        private void btnhastagiris_Click(object sender, EventArgs e)
        {
            frmhastagiris fr = new frmhastagiris();
            fr.Show();
            this.Hide();
                
        }

        private void btndoktorgiris_Click(object sender, EventArgs e)
        {
            Frmdoktorgiris fr = new Frmdoktorgiris();
            fr.Show();
            this.Hide();
        }

        private void btnsekretergiris_Click(object sender, EventArgs e)
        {
            frmsekretergiriş fr = new frmsekretergiriş();
            fr.Show();
            this.Hide();
        }
    }
}
