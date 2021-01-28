using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class frmProgressBar : Form
    {
        public frmProgressBar()
        {
            InitializeComponent();
        }
        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //this.progressBar1.Increment(1);
            
            progressBar1.Maximum = 500;
            progressBar1.PerformStep();
            if (progressBar1.Value == 500)
            {
                timer1.Enabled = false;
                this.Hide();
                frmLogin form = new frmLogin();
                form.Closed += (s, args) => this.Close();
                form.Show();
            }
        }

        private void frmProgressBar_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
