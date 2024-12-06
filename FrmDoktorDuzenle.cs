using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneYönetimOtomasyonu
{
    public partial class FrmDoktorDuzenle : Form
    {
        public FrmDoktorDuzenle()
        {
            InitializeComponent();
        }
        SQLBaglantisi bgl = new SQLBaglantisi();
        public string TCKN;
        private void FrmDoktorDuzenle_Load(object sender, EventArgs e)
        {
            mskTC.Text = TCKN;
            
            SqlCommand kmt = new SqlCommand("Select * From tablo_Doktorlar where DoktorTC=@p1",bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", mskTC.Text);
            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                txtAd.Text = dr[1].ToString();
                txtSoyad.Text = dr[2].ToString();
                cmbBrans.Text = dr[3].ToString();
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
                    MessageBox.Show(this, "İşlem tamamlandı! Lütfen Tekrar Giriş Yapınız...", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }));
            }));

            thread.Start();


            SqlCommand komut = new SqlCommand("Update tablo_Doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 where DoktorTC=@p5",bgl.baglanti());
komut.Parameters.AddWithValue("@p1",txtAd.Text);
komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
komut.Parameters.AddWithValue("@p3", cmbBrans.Text);
komut.Parameters.AddWithValue("@p4", txtSifre.Text);
komut.Parameters.AddWithValue("@p5", mskTC.Text); 
komut.ExecuteNonQuery();
           
        bgl.baglanti().Close();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris fr = new FrmDoktorGiris();
            fr.Show();
            this.Close();
        }
    }
}
