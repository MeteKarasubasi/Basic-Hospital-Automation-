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
    public partial class FrmHastaDetay : Form
    {

        public FrmHastaDetay()
        {
            InitializeComponent();
        }
        SQLBaglantisi bgl = new SQLBaglantisi();
        public string tc;
        public string TCKNLabel
        {
            get { return lblTCKN.Text; }
            set { lblTCKN.Text = value; }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            lblTCKN.Text = tc;
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad From tablo_Hastalar where HastaTC = @p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",tc);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblHastaAdı.Text= dr[0].ToString() +" "+ dr[1].ToString();
            }
            bgl.baglanti().Close();


            //Geçmiş randevuları listeleme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Randevular WHERE RandevuDurum=1 AND HastaTC=@p1 ORDER BY Randevuid ASC", bgl.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@p1", lblTCKN.Text);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Branş Getirme
            SqlCommand komut2 = new SqlCommand("Select BransAd From tablo_Branslar ",bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while(dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0].ToString());
            }
            bgl.baglanti().Close();
           
            
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktorlar.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad From tablo_Doktorlar where DoktorBrans=@p1 ",bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1",cmbBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read()) {

                cmbDoktorlar.Items.Add(dr3[0].ToString()+" " + dr3[1].ToString());
                bgl.baglanti() .Close();
            
            }
        }

        private void cmbDoktorlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuBrans='"+cmbBrans.Text+"'" + " and RandevuDoktor='"+cmbDoktorlar.Text+"'and RandevuDurum=0",bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;



            
            // Seçilen doktora ait randevuları getirme
            DataTable dtDoktorRandevular = new DataTable();
            using (SqlDataAdapter daDoktorRandevular = new SqlDataAdapter("SELECT * FROM Tbl_Randevular WHERE RandevuDoktor=@p1 AND RandevuDurum=0", bgl.baglanti()))
            {
                daDoktorRandevular.SelectCommand.Parameters.AddWithValue("@p1", cmbDoktorlar.Text);
                daDoktorRandevular.Fill(dtDoktorRandevular);
            }

            dataGridView2.DataSource = dtDoktorRandevular;


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDuzenle fr = new FrmBilgiDuzenle();
            fr.tcno = lblTCKN.Text;
            fr.Show();
            this.Close();
        
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select (DoktorAd+' '+DoktorSoyad) as 'Doktor Adı ve Soyadı',DoktorBrans From tablo_Doktorlar", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            Randevuid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Visible = true;

            // Animasyonlu ProgressBar
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
                    
                }));
            }));

            thread.Start();

            try
            {
                // Yeni randevu ekleme
                SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Randevular (RandevuBrans, RandevuDoktor, HastaTC, HastaSikayet, RandevuDurum) VALUES (@brans, @doktor, @tc, @sikayet, @durum)", bgl.baglanti());
                komut.Parameters.AddWithValue("@brans", cmbBrans.Text);
                komut.Parameters.AddWithValue("@doktor", cmbDoktorlar.Text);
                komut.Parameters.AddWithValue("@tc", lblTCKN.Text);
                komut.Parameters.AddWithValue("@sikayet", rchSikayet.Text);
                komut.Parameters.AddWithValue("@durum", 0); // Yeni randevular için durum 0 olarak ekleniyor

                komut.ExecuteNonQuery();
                MessageBox.Show("Randevu başarıyla alındı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // DataGridView'leri güncelle
                GeçmişRandevularıListeleVeGuncelle();
                DoktorRandevularınıListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bgl.baglanti().Close();
            }
        }

        // Doktorun aktif randevularını listeleme
        private void DoktorRandevularınıListele()
        {
            DataTable dtDoktorRandevular = new DataTable();
            using (SqlDataAdapter daDoktorRandevular = new SqlDataAdapter("SELECT * FROM Tbl_Randevular WHERE RandevuBrans=@p1 AND RandevuDoktor=@p2 AND RandevuDurum=0", bgl.baglanti()))
            {
                daDoktorRandevular.SelectCommand.Parameters.AddWithValue("@p1", cmbBrans.Text);
                daDoktorRandevular.SelectCommand.Parameters.AddWithValue("@p2", cmbDoktorlar.Text);
                daDoktorRandevular.Fill(dtDoktorRandevular);
            }

            dataGridView2.DataSource = dtDoktorRandevular;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            GirisFormu fr = new GirisFormu();
            fr.Show();
            this.Hide();
        }
        private void GeçmişRandevularıListeleVeGuncelle()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Randevular WHERE RandevuDurum=1 AND HastaTC=@p1 ORDER BY Randevuid ASC", bgl.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@p1", lblTCKN.Text);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            string sikayet = dataGridView1.Rows[secilen].Cells[8].Value.ToString();

            richTextBox1.Text = sikayet;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            string hastaTeshis = dataGridView1.Rows[secilen].Cells["HastaTeshis"].Value.ToString();

            richTextBox1.Text = hastaTeshis;

            int secilen1 = dataGridView1.SelectedCells[0].RowIndex;

            string recete = dataGridView1.Rows[secilen1].Cells["Recete"].Value.ToString();

            rchRecete.Text = recete;
        }

        private void rchRecete_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblHastaAdı_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblid_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }

       
    }

