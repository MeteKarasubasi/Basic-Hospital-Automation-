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
    public partial class FrmHastaKayıt : Form
    {
        public FrmHastaKayıt()
        {
            InitializeComponent();
        }
        SQLBaglantisi bgl = new SQLBaglantisi();

        private void btnKayıtOl_Click(object sender, EventArgs e)
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
                    MessageBox.Show(this, "İşlem tamamlandı!", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }));
            }));

            thread.Start();


            SqlCommand komut = new SqlCommand("insert into tablo_Hastalar (HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) values(@p1,@p2,@p3,@p4,@p5,@p6)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTC.Text);
            komut.Parameters.AddWithValue("@p4", mskTelefon.Text);
            komut.Parameters.AddWithValue("@p5", txtSifre.Text);
            komut.Parameters.AddWithValue("@p6", cmbCinsiyet.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Gerçekleşmiştir." );


        }

        private void btndon_Click(object sender, EventArgs e)
        {
            FrmHastaGirisi fr = new FrmHastaGirisi();
            fr.Show();
            this.Hide();
        }

        private void btndon_Click_1(object sender, EventArgs e)
        {
            GirisFormu fr = new GirisFormu();
            fr.Show();
            this.Hide();
        }
    }
}
