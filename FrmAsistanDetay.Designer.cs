namespace HastaneYönetimOtomasyonu
{
    partial class FrmAsistanDetay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAsistanDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOluştur = new System.Windows.Forms.Button();
            this.rchDuyuru = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.chkDurum = new System.Windows.Forms.CheckBox();
            this.mskTCKN = new System.Windows.Forms.MaskedTextBox();
            this.cmbDoktorlar = new System.Windows.Forms.ComboBox();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.mskTxtSaat = new System.Windows.Forms.MaskedTextBox();
            this.msktxtTarih = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnDuyurular = new System.Windows.Forms.Button();
            this.btnRandevular = new System.Windows.Forms.Button();
            this.btnBransis = new System.Windows.Forms.Button();
            this.btnDocis = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.lblAdSoyad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblTC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(23, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgi";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.Location = new System.Drawing.Point(165, 69);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(150, 20);
            this.lblAdSoyad.TabIndex = 3;
            this.lblAdSoyad.Text = "SekreterAdSoyad";
            this.lblAdSoyad.Click += new System.EventHandler(this.lblAdSoyad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(77, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TCKN : ";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTC.Location = new System.Drawing.Point(165, 44);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(119, 20);
            this.lblTC.TabIndex = 2;
            this.lblTC.Text = "00000000000";
            this.lblTC.Click += new System.EventHandler(this.lblTC_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(42, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad : ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnOluştur);
            this.groupBox2.Controls.Add(this.rchDuyuru);
            this.groupBox2.Location = new System.Drawing.Point(23, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 332);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // btnOluştur
            // 
            this.btnOluştur.Location = new System.Drawing.Point(85, 281);
            this.btnOluştur.Name = "btnOluştur";
            this.btnOluştur.Size = new System.Drawing.Size(198, 45);
            this.btnOluştur.TabIndex = 4;
            this.btnOluştur.Text = "Duyuru Oluştur";
            this.btnOluştur.UseVisualStyleBackColor = true;
            this.btnOluştur.Click += new System.EventHandler(this.btnOluştur_Click);
            // 
            // rchDuyuru
            // 
            this.rchDuyuru.Location = new System.Drawing.Point(21, 61);
            this.rchDuyuru.Name = "rchDuyuru";
            this.rchDuyuru.Size = new System.Drawing.Size(347, 214);
            this.rchDuyuru.TabIndex = 3;
            this.rchDuyuru.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnKaydet);
            this.groupBox3.Controls.Add(this.chkDurum);
            this.groupBox3.Controls.Add(this.mskTCKN);
            this.groupBox3.Controls.Add(this.cmbDoktorlar);
            this.groupBox3.Controls.Add(this.cmbBrans);
            this.groupBox3.Controls.Add(this.mskTxtSaat);
            this.groupBox3.Controls.Add(this.msktxtTarih);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(417, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 491);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Planlama";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(94, 397);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(122, 39);
            this.btnKaydet.TabIndex = 18;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // chkDurum
            // 
            this.chkDurum.AutoSize = true;
            this.chkDurum.Location = new System.Drawing.Point(94, 352);
            this.chkDurum.Name = "chkDurum";
            this.chkDurum.Size = new System.Drawing.Size(76, 24);
            this.chkDurum.TabIndex = 17;
            this.chkDurum.Text = "Durum";
            this.chkDurum.UseVisualStyleBackColor = true;
            // 
            // mskTCKN
            // 
            this.mskTCKN.Location = new System.Drawing.Point(94, 302);
            this.mskTCKN.Mask = "00000000000";
            this.mskTCKN.Name = "mskTCKN";
            this.mskTCKN.Size = new System.Drawing.Size(137, 26);
            this.mskTCKN.TabIndex = 16;
            this.mskTCKN.ValidatingType = typeof(int);
            // 
            // cmbDoktorlar
            // 
            this.cmbDoktorlar.FormattingEnabled = true;
            this.cmbDoktorlar.Location = new System.Drawing.Point(94, 254);
            this.cmbDoktorlar.Name = "cmbDoktorlar";
            this.cmbDoktorlar.Size = new System.Drawing.Size(137, 28);
            this.cmbDoktorlar.TabIndex = 15;
            this.cmbDoktorlar.SelectedIndexChanged += new System.EventHandler(this.cmbDoktorlar_SelectedIndexChanged);
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(94, 205);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(137, 28);
            this.cmbBrans.TabIndex = 14;
            this.cmbBrans.SelectedIndexChanged += new System.EventHandler(this.cmbBranş_SelectedIndexChanged);
            // 
            // mskTxtSaat
            // 
            this.mskTxtSaat.Location = new System.Drawing.Point(94, 158);
            this.mskTxtSaat.Mask = "00:00";
            this.mskTxtSaat.Name = "mskTxtSaat";
            this.mskTxtSaat.Size = new System.Drawing.Size(137, 26);
            this.mskTxtSaat.TabIndex = 13;
            this.mskTxtSaat.ValidatingType = typeof(System.DateTime);
            // 
            // msktxtTarih
            // 
            this.msktxtTarih.Location = new System.Drawing.Point(94, 112);
            this.msktxtTarih.Mask = "00/00/0000";
            this.msktxtTarih.Name = "msktxtTarih";
            this.msktxtTarih.Size = new System.Drawing.Size(137, 26);
            this.msktxtTarih.TabIndex = 12;
            this.msktxtTarih.ValidatingType = typeof(System.DateTime);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 300);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 20);
            this.label11.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Doktor : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "TCKN : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Branş : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Saat : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tarih : ";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(730, 34);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(383, 236);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mevcut Branşlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(377, 211);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(730, 276);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(383, 359);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Kadromuz";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 22);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(377, 334);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.btnYenile);
            this.groupBox6.Controls.Add(this.btnCikis);
            this.groupBox6.Controls.Add(this.btnDuyurular);
            this.groupBox6.Controls.Add(this.btnRandevular);
            this.groupBox6.Controls.Add(this.btnBransis);
            this.groupBox6.Controls.Add(this.btnDocis);
            this.groupBox6.Location = new System.Drawing.Point(28, 531);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(696, 137);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(1, 87);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(342, 44);
            this.btnYenile.TabIndex = 5;
            this.btnYenile.Text = "Tabloları Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(348, 87);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(342, 44);
            this.btnCikis.TabIndex = 4;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnDuyurular
            // 
            this.btnDuyurular.Location = new System.Drawing.Point(513, 29);
            this.btnDuyurular.Name = "btnDuyurular";
            this.btnDuyurular.Size = new System.Drawing.Size(177, 52);
            this.btnDuyurular.TabIndex = 3;
            this.btnDuyurular.Text = "Duyurular";
            this.btnDuyurular.UseVisualStyleBackColor = true;
            this.btnDuyurular.Click += new System.EventHandler(this.btnDuyurular_Click);
            // 
            // btnRandevular
            // 
            this.btnRandevular.Location = new System.Drawing.Point(329, 29);
            this.btnRandevular.Name = "btnRandevular";
            this.btnRandevular.Size = new System.Drawing.Size(178, 52);
            this.btnRandevular.TabIndex = 2;
            this.btnRandevular.Text = "Randevu Listesi";
            this.btnRandevular.UseVisualStyleBackColor = true;
            this.btnRandevular.Click += new System.EventHandler(this.btnRandevular_Click);
            // 
            // btnBransis
            // 
            this.btnBransis.Location = new System.Drawing.Point(165, 29);
            this.btnBransis.Name = "btnBransis";
            this.btnBransis.Size = new System.Drawing.Size(158, 52);
            this.btnBransis.TabIndex = 1;
            this.btnBransis.Text = "Branş İşlemleri";
            this.btnBransis.UseVisualStyleBackColor = true;
            this.btnBransis.Click += new System.EventHandler(this.btnBransis_Click);
            // 
            // btnDocis
            // 
            this.btnDocis.Location = new System.Drawing.Point(0, 29);
            this.btnDocis.Name = "btnDocis";
            this.btnDocis.Size = new System.Drawing.Size(159, 52);
            this.btnDocis.TabIndex = 0;
            this.btnDocis.Text = "Doktor İşlemleri";
            this.btnDocis.UseVisualStyleBackColor = true;
            this.btnDocis.Click += new System.EventHandler(this.btnDocis_Click);
            // 
            // FrmAsistanDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1125, 668);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmAsistanDetay";
            this.Text = "Asistan Paneli";
            this.Load += new System.EventHandler(this.FrmAsistanDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOluştur;
        private System.Windows.Forms.RichTextBox rchDuyuru;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox msktxtTarih;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.CheckBox chkDurum;
        private System.Windows.Forms.MaskedTextBox mskTCKN;
        private System.Windows.Forms.ComboBox cmbDoktorlar;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.MaskedTextBox mskTxtSaat;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDocis;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnRandevular;
        private System.Windows.Forms.Button btnBransis;
        private System.Windows.Forms.Button btnDuyurular;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnYenile;
    }
}