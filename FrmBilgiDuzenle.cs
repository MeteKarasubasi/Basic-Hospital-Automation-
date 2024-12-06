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
using System.Threading;

namespace HastaneYönetimOtomasyonu
{
    public partial class FrmBilgiDuzenle : Form
    {
        public FrmBilgiDuzenle()
        {
            InitializeComponent();
        }
        public string tcno;

        SQLBaglantisi bgl = new SQLBaglantisi();
        private void FrmBilgiDuzenle_Load(object sender, EventArgs e)
        {
            mskTC.Text = tcno;
            
            SqlCommand komut = new SqlCommand("Select * From tablo_Hastalar where HastaTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",mskTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtAd.Text = dr[1].ToString();
                txtSoyad.Text = dr[2].ToString();
                mskTelefon.Text = dr[4].ToString();
                txtSifre.Text = dr[5].ToString();
                

            }
            bgl.baglanti().Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            progressBar1.Value = 0;
            progressBar1.Visible = true;

            Thread thread = new Thread(new ThreadStart(() =>
            {
                for (int i = 0; i <= 100; i++)
                {
                    Thread.Sleep(10);
                    progressBar1.Invoke(new Action(() => progressBar1.Value = i));
                }

                progressBar1.Invoke(new Action(() => progressBar1.Visible = false));


                this.Invoke(new Action(() =>
                {
                    MessageBox.Show(this, "İşlem tamamlandı! Lütfen Yeniden Giriş Yapınız...", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }));
            }));

            thread.Start();
 

            SqlCommand kmt = new SqlCommand("update tablo_Hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4 where HastaTC=@p5", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1",txtAd.Text);
            kmt.Parameters.AddWithValue("@p2", txtSoyad.Text);
            kmt.Parameters.AddWithValue("@p3", mskTelefon.Text);
            kmt.Parameters.AddWithValue("@p4", txtSifre.Text);
            kmt.Parameters.AddWithValue("@p5", mskTC.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            GirisFormu fr = new GirisFormu();
            fr.Show();
            this.Close();
        }

       
    }
}
