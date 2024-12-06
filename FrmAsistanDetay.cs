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
    public partial class FrmAsistanDetay : Form
    {
        public FrmAsistanDetay()
        {
            InitializeComponent();
        }
        public string tckn;
        SQLBaglantisi bgl = new SQLBaglantisi();
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void FrmAsistanDetay_Load(object sender, EventArgs e)
        {
            //Asistan Ad Soyad ve TC Getirme
            lblTC.Text = tckn;
            SqlCommand komut1 = new SqlCommand("Select AsistanAdSoyad From tablo_Asistan where AsistanTC=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblAdSoyad.Text = dr1[0].ToString();

            }
            bgl.baglanti().Close();

            //Branşları DataGride getirme
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From tablo_Branslar", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Doktorları DataGride getirme
            DataTable dt2 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select (DoktorAd+' '+DoktorSoyad) as 'Doktor Adı ve Soyadı',DoktorBrans From tablo_Doktorlar", bgl.baglanti());
            da1.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Branşı ComboBox'a getirme
            cmbBrans.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select BransAd From tablo_Branslar ", bgl.baglanti());

            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {

                cmbBrans.Items.Add(dr3[0].ToString());
               
            }
            bgl.baglanti().Close();
            


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTC_Click(object sender, EventArgs e)
        {

        }

        private void lblAdSoyad_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Seçilen tarih ve saatte başka randevu var mı kontrolü
            SqlCommand kontrolKomut = new SqlCommand("SELECT COUNT(*) FROM Tbl_Randevular WHERE RandevuTarih = @r1 AND RandevuSaat = @r2", bgl.baglanti());
            kontrolKomut.Parameters.AddWithValue("@r1", msktxtTarih.Text);
            kontrolKomut.Parameters.AddWithValue("@r2", mskTxtSaat.Text);

            int randevuSayisi = Convert.ToInt32(kontrolKomut.ExecuteScalar());

            if (randevuSayisi > 0)
            {
                MessageBox.Show("Seçilen tarih ve saatte başka bir randevu bulunmaktadır. Lütfen farklı bir tarih veya saat seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Randevu kaydetme işlemi
                SqlCommand komutkaydet = new SqlCommand("INSERT INTO Tbl_Randevular (RandevuTarih, RandevuSaat, RandevuBrans, RandevuDoktor, HastaTC, RandevuDurum) VALUES (@r1, @r2, @r3, @r4, @r5, @r6)", bgl.baglanti());
                komutkaydet.Parameters.AddWithValue("@r1", msktxtTarih.Text);
                komutkaydet.Parameters.AddWithValue("@r2", mskTxtSaat.Text);
                komutkaydet.Parameters.AddWithValue("@r3", cmbBrans.Text);
                komutkaydet.Parameters.AddWithValue("@r4", cmbDoktorlar.Text);
                komutkaydet.Parameters.AddWithValue("@r5", mskTCKN.Text);
                komutkaydet.Parameters.AddWithValue("@r6", chkDurum.Checked);
                komutkaydet.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Randevu Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }

        private void cmbBranş_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktorlar.Items.Clear();
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From tablo_Doktorlar where DoktorBrans=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",cmbBrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbDoktorlar.Items.Add(dr[0]+" " + dr[1]);

            }
            bgl.baglanti().Close();

        }

        private void cmbDoktorlar_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnOluştur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (Duyuru) values (@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1",rchDuyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluştuuruldu....");
        }

        private void btnDocis_Click(object sender, EventArgs e)
        {
            FrmDoktorİslemleri fr = new FrmDoktorİslemleri();
            fr.Show();
    
            
        }
        public void GuncelleDataGridView1()
        {
            // Branşları DataGride getirme
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From tablo_Branslar", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }

        public void GuncelleDataGridView2()
        {
            // Doktorları DataGride getirme
            DataTable dt2 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select (DoktorAd+' '+DoktorSoyad) as 'Doktor Adı ve Soyadı',DoktorBrans From tablo_Doktorlar", bgl.baglanti());
            da1.Fill(dt2);
            dataGridView2.DataSource = dt2;
        }

        private void btnBransis_Click(object sender, EventArgs e)
        {
            FrmBrans fr= new FrmBrans();
            fr.Show();
            this.Close();
         
        }

        private void btnRandevular_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi frr= new FrmRandevuListesi();
            frr.Show();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
           
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
           GirisFormu gr = new GirisFormu();
            gr.Show();
            this.Close();
        }
        public void AsistanBilgileriniGuncelle(string adSoyad, string tc)
        {
            // Parametreler ile formdaki Label kontrol değerlerini güncelle
            lblAdSoyad.Text = adSoyad;
            lblTC.Text = tc;
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            GuncelleDataGridView1();
            GuncelleDataGridView2();
        }
    }
}
