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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;

namespace HastaneYönetimOtomasyonu
{
    public partial class FrmBrans : Form
    {
        public FrmBrans()
        {
            InitializeComponent();
        }
        SQLBaglantisi bgl = new SQLBaglantisi();
        private void FrmBrans_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From tablo_Branslar",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            GuncelleProgressBar();

            SqlCommand komut = new SqlCommand("insert into tablo_branslar (BransAd) values (@b1)",bgl.baglanti());
            komut.Parameters.AddWithValue("@b1",BransAd.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti();
            GuncelleDataGridView();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        int secilen = dataGridView1.SelectedCells[0].RowIndex;
            bransID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            BransAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GuncelleProgressBar();

            SqlCommand komut = new SqlCommand("delete From tablo_Branslar where Bransid=@b1",bgl.baglanti());
            komut.Parameters.AddWithValue("@b1",bransID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            GuncelleDataGridView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GuncelleProgressBar();


            SqlCommand komut = new SqlCommand("update tablo_Branslar set BransAd=@p1 where Bransid=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",BransAd.Text);
            komut.Parameters.AddWithValue("@p2",bransID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();


            GuncelleDataGridView();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            FrmAsistanDetay fr = new FrmAsistanDetay();
            fr.Show();
            this.Hide();
        }
        private void GuncelleProgressBar()
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
        }
        private void GuncelleDataGridView()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From tablo_Branslar", bgl.baglanti());
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }
    }
}
