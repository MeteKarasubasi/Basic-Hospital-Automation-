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

namespace HastaneYönetimOtomasyonu
{
    public partial class FrmHastaGirisi : Form
    {
        public FrmHastaGirisi()
        {
            InitializeComponent();
        }
        SQLBaglantisi bgl = new SQLBaglantisi();
        private void FrmHastaGirisi_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From tablo_Hastalar Where HastaTC=@p1 and HastaSifre = @p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",mskTC.Text);
            komut.Parameters.AddWithValue("@p2",txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmHastaDetay fr = new FrmHastaDetay();
                fr.tc = mskTC.Text;
                fr.Show();
                this.Close();

            }
            else {
                MessageBox.Show("Hatalı TCKN veya Şifre..."+" "+MessageBoxButtons.OK);
            }
            
            bgl.baglanti().Close();
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void mskTC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lnkUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayıt fr = new FrmHastaKayıt();
            fr.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GirisFormu gr = new GirisFormu();
            gr.Show();
            this.Close();
        }
    }
}
