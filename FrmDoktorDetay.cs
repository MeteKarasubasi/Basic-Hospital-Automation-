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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        SQLBaglantisi bgl = new SQLBaglantisi();
        public string TCKN;
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text= TCKN;
            //Doktor Ad Soyad Getirme
            SqlCommand kmt = new SqlCommand("Select DoktorAd,DoktorSoyad From tablo_Doktorlar where DoktorTC=@p1",bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1",lblTC.Text);
            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read()) {
                
                    lblAdSoyad.Text = dr[0]+" " + dr[1];
            
            }
            bgl.baglanti().Close();

            //Randevuları Getirme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select *From Tbl_Randevular where RandevuDoktor='"+lblAdSoyad.Text+"'",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        
        }

        private void btnBilgiDüzenle_Click(object sender, EventArgs e)
        {
            FrmDoktorDuzenle fr = new FrmDoktorDuzenle();
            fr.TCKN = lblTC.Text;
            fr.Show();
            this.Close();
        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            GirisFormu fr = new GirisFormu();
            fr.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                string sikayet = row.Cells[7].Value.ToString();
                string teshis = row.Cells[8].Value.ToString();
                string hastaID = row.Cells[0].Value.ToString();

                rchSikayet.Text = sikayet;
                rchTeshis.Text = teshis;
                lblid.Text = hastaID;

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTeshis_Click(object sender, EventArgs e)
        {
            SqlCommand guncelleKomutu = new SqlCommand("UPDATE Tbl_Randevular SET HastaTeshis=@t WHERE Randevuid=@id", bgl.baglanti());
            guncelleKomutu.Parameters.AddWithValue("@t", rchTeshis.Text);
            guncelleKomutu.Parameters.AddWithValue("@id", lblid.Text);

            guncelleKomutu.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lblid_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblid.Text))
            {
                string randevuID = lblid.Text;

                SqlCommand selectCommand = new SqlCommand("SELECT Recete FROM Tbl_Randevular WHERE Randevuid=@id", bgl.baglanti());
                selectCommand.Parameters.AddWithValue("@id", randevuID);
                string recete = selectCommand.ExecuteScalar() as string;

                string newRecete = recete + Environment.NewLine + rchRecete.Text;

                SqlCommand guncelleKomutu = new SqlCommand("UPDATE Tbl_Randevular SET Recete=@r WHERE Randevuid=@id", bgl.baglanti());
                guncelleKomutu.Parameters.AddWithValue("@r", newRecete);
                guncelleKomutu.Parameters.AddWithValue("@id", randevuID);

                guncelleKomutu.ExecuteNonQuery();
                bgl.baglanti().Close();

                FrmDoktorDetay_Load(sender, e);

                MessageBox.Show("Reçete başarıyla güncellendi.");
            }
            else
            {
                MessageBox.Show("Lütfen bir hasta seçin.");
            }

         
        }

        private void richTextBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {
           
        }
    }
}
