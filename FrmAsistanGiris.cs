﻿using System;
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
    public partial class FrmAsistanGiris : Form
    {
        public FrmAsistanGiris()
        {
            InitializeComponent();
        }
        SQLBaglantisi bgl = new SQLBaglantisi();
        private void FrmAsistanGiris_Load(object sender, EventArgs e)
        {
           
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From tablo_Asistan where AsistanTC=@p1 and AsistanSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTC.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmAsistanDetay fr = new FrmAsistanDetay();
                fr.tckn = mskTC.Text;
                fr.Show();
                this.Hide();

            }
            else
            {

                MessageBox.Show("Hatalı Giriş...");
            }
            bgl.baglanti().Close();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            GirisFormu gr = new GirisFormu();
            gr.Show();
            this.Close();
        }
    }
}
