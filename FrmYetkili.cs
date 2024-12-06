using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneYönetimOtomasyonu
{
    public partial class FrmYetkili : Form
    {
        public FrmYetkili()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void FrmYetkili_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris fr = new FrmDoktorGiris();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAsistanGiris fr = new FrmAsistanGiris();
            fr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GirisFormu gr = new GirisFormu();
            gr.Show();
            this.Close();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {

        }
    }
}
