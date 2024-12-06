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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }
        SQLBaglantisi bgl = new SQLBaglantisi();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From tablo_Doktorlar where DoktorTC=@p1 and DoktorSifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",mskTC.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read()) {

                FrmDoktorDetay frd = new FrmDoktorDetay();
                frd.TCKN = mskTC.Text;
                frd.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TCKN veya Şifre");



            }
            bgl.baglanti().Close();

        }

        private void FrmDoktorGiris_Load(object sender, EventArgs e)
        {

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            GirisFormu fr = new GirisFormu();
            fr.Show();
            this.Hide();
        }
    }
}
