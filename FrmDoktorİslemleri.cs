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
    public partial class FrmDoktorİslemleri : Form
    {
        public FrmDoktorİslemleri()
        {
            InitializeComponent();
        }
    
        SQLBaglantisi bgl = new SQLBaglantisi();
        public string tckno;
        private void FrmDoktorİslemleri_Load(object sender, EventArgs e)
        {

            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From tablo_Doktorlar", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            //Bransları ComboBoxa getirme
            cmbBrans.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select BransAd From tablo_Branslar ", bgl.baglanti());

            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {

                cmbBrans.Items.Add(dr3[0].ToString());

            }
            bgl.baglanti().Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
           
        }

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskTC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }

        

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_AutoSizeColumnModeChanged(object sender, DataGridViewAutoSizeColumnModeEventArgs e)
        {

        }
        FrmAsistanDetay frmAsistanDetay;
        private void button4_Click(object sender, EventArgs e)
        {
            if (frmAsistanDetay == null || frmAsistanDetay.IsDisposed)
            {
                frmAsistanDetay = new FrmAsistanDetay();
                frmAsistanDetay.GuncelleDataGridView1();
                frmAsistanDetay.GuncelleDataGridView2();
              
            }

            this.Close();


        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
            {
                GuncelleDataGridViewler();
            }
        }
        private void GuncelleDataGridViewler()
        {
            if (frmAsistanDetay == null || frmAsistanDetay.IsDisposed)
            {
                frmAsistanDetay = new FrmAsistanDetay();
                frmAsistanDetay.GuncelleDataGridView1();
                frmAsistanDetay.GuncelleDataGridView2();
                
            }
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnSil_Click(object sender, EventArgs e)
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


            SqlCommand komut = new SqlCommand("Delete From tablo_Doktorlar where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            GuncelleDataGridViewler();
            YenileDataGridView1();
        }

        private void btnGuncelle_Click_1(object sender, EventArgs e)
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


            SqlCommand komut = new SqlCommand("Update tablo_Doktorlar set DoktorAd=@d1,DoktorSoyad=@d2,DoktorBrans=@d3,DoktorSifre=@d5 where DoktorTC=@d4", bgl.baglanti());

            komut.Parameters.AddWithValue("@d1", txtAd.Text);
            komut.Parameters.AddWithValue("@d2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@d3", cmbBrans.Text);
            komut.Parameters.AddWithValue("@d4", mskTC.Text);
            komut.Parameters.AddWithValue("@d5", txtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();


            GuncelleDataGridViewler();
            YenileDataGridView1();

        }
        private void YenileDataGridView1()
        {
            // Datagridview1'i yenileme işlemleri buraya eklenecek
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tablo_Doktorlar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnEkle_Click_1(object sender, EventArgs e)
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

            SqlCommand komut = new SqlCommand("insert into tablo_Doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values (@d1,@d2,@d3,@d4,@d5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", txtAd.Text);
            komut.Parameters.AddWithValue("@d2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@d3", cmbBrans.Text);
            komut.Parameters.AddWithValue("@d4", mskTC.Text);
            komut.Parameters.AddWithValue("@d5", txtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            GuncelleDataGridViewler();
            YenileDataGridView1();
        }
    }



}
