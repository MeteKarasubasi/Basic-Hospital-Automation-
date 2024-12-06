namespace HastaneYönetimOtomasyonu
{
    partial class FrmDoktorDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rchSikayet = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.btnDuyurular = new System.Windows.Forms.Button();
            this.btnBilgiDüzenle = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblid = new System.Windows.Forms.Label();
            this.LABEL6 = new System.Windows.Forms.Label();
            this.btnTeshis = new System.Windows.Forms.Button();
            this.rchTeshis = new System.Windows.Forms.RichTextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rchRecete = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblAdSoyad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblTC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(19, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(295, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişisel Bilgiler";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.ForeColor = System.Drawing.Color.Yellow;
            this.lblAdSoyad.Location = new System.Drawing.Point(112, 45);
            this.lblAdSoyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(122, 20);
            this.lblAdSoyad.TabIndex = 3;
            this.lblAdSoyad.Text = "DoktorAdSoyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(49, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TCKN :";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTC.ForeColor = System.Drawing.Color.Yellow;
            this.lblTC.Location = new System.Drawing.Point(112, 24);
            this.lblTC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(108, 20);
            this.lblTC.TabIndex = 2;
            this.lblTC.Text = "00000000000";
            this.lblTC.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(26, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.rchSikayet);
            this.groupBox2.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox2.Location = new System.Drawing.Point(19, 124);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(295, 153);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Detayları";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(11, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hasta Şikayetleri";
            // 
            // rchSikayet
            // 
            this.rchSikayet.Location = new System.Drawing.Point(15, 54);
            this.rchSikayet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rchSikayet.Name = "rchSikayet";
            this.rchSikayet.Size = new System.Drawing.Size(262, 149);
            this.rchSikayet.TabIndex = 0;
            this.rchSikayet.Text = "";
            this.rchSikayet.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(326, 27);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(674, 441);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(670, 424);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.BtnCikis);
            this.groupBox4.Controls.Add(this.btnDuyurular);
            this.groupBox4.Controls.Add(this.btnBilgiDüzenle);
            this.groupBox4.Location = new System.Drawing.Point(328, 466);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(671, 70);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // BtnCikis
            // 
            this.BtnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCikis.Location = new System.Drawing.Point(450, 17);
            this.BtnCikis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(178, 48);
            this.BtnCikis.TabIndex = 6;
            this.BtnCikis.Text = "Çıkış";
            this.BtnCikis.UseVisualStyleBackColor = true;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // btnDuyurular
            // 
            this.btnDuyurular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuyurular.Location = new System.Drawing.Point(243, 17);
            this.btnDuyurular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDuyurular.Name = "btnDuyurular";
            this.btnDuyurular.Size = new System.Drawing.Size(178, 48);
            this.btnDuyurular.TabIndex = 5;
            this.btnDuyurular.Text = "Duyurular";
            this.btnDuyurular.UseVisualStyleBackColor = true;
            this.btnDuyurular.Click += new System.EventHandler(this.btnDuyurular_Click);
            // 
            // btnBilgiDüzenle
            // 
            this.btnBilgiDüzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBilgiDüzenle.Location = new System.Drawing.Point(36, 17);
            this.btnBilgiDüzenle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBilgiDüzenle.Name = "btnBilgiDüzenle";
            this.btnBilgiDüzenle.Size = new System.Drawing.Size(178, 48);
            this.btnBilgiDüzenle.TabIndex = 4;
            this.btnBilgiDüzenle.Text = "Bilgileri Düzenle";
            this.btnBilgiDüzenle.UseVisualStyleBackColor = true;
            this.btnBilgiDüzenle.Click += new System.EventHandler(this.btnBilgiDüzenle_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.lblid);
            this.groupBox5.Controls.Add(this.LABEL6);
            this.groupBox5.Controls.Add(this.btnTeshis);
            this.groupBox5.Controls.Add(this.rchTeshis);
            this.groupBox5.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox5.Location = new System.Drawing.Point(19, 289);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Size = new System.Drawing.Size(295, 176);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Hasta Teşhisi";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblid.Location = new System.Drawing.Point(106, 15);
            this.lblid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(13, 20);
            this.lblid.TabIndex = 8;
            this.lblid.Text = " ";
            this.lblid.Click += new System.EventHandler(this.lblid_Click);
            // 
            // LABEL6
            // 
            this.LABEL6.AutoSize = true;
            this.LABEL6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LABEL6.Location = new System.Drawing.Point(25, 15);
            this.LABEL6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LABEL6.Name = "LABEL6";
            this.LABEL6.Size = new System.Drawing.Size(85, 20);
            this.LABEL6.TabIndex = 6;
            this.LABEL6.Text = "Hasta ID : ";
            // 
            // btnTeshis
            // 
            this.btnTeshis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeshis.ForeColor = System.Drawing.Color.Black;
            this.btnTeshis.Location = new System.Drawing.Point(82, 140);
            this.btnTeshis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTeshis.Name = "btnTeshis";
            this.btnTeshis.Size = new System.Drawing.Size(130, 30);
            this.btnTeshis.TabIndex = 7;
            this.btnTeshis.Text = "Teşhis Koy";
            this.btnTeshis.UseVisualStyleBackColor = true;
            this.btnTeshis.Click += new System.EventHandler(this.btnTeshis_Click);
            // 
            // rchTeshis
            // 
            this.rchTeshis.Location = new System.Drawing.Point(15, 43);
            this.rchTeshis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rchTeshis.Name = "rchTeshis";
            this.rchTeshis.Size = new System.Drawing.Size(262, 93);
            this.rchTeshis.TabIndex = 0;
            this.rchTeshis.Text = "";
            this.rchTeshis.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged_1);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.rchRecete);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox6.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox6.Location = new System.Drawing.Point(19, 470);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox6.Size = new System.Drawing.Size(295, 137);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Reçete";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(52, 91);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Reçete yaz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rchRecete
            // 
            this.rchRecete.Location = new System.Drawing.Point(4, 22);
            this.rchRecete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rchRecete.Name = "rchRecete";
            this.rchRecete.Size = new System.Drawing.Size(287, 65);
            this.rchRecete.TabIndex = 0;
            this.rchRecete.Text = "";
            this.rchRecete.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged_2);
            // 
            // FrmDoktorDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1009, 618);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorDetay";
            this.Text = "Doktor Paneli";
            this.Load += new System.EventHandler(this.FrmDoktorDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rchSikayet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.Button btnDuyurular;
        private System.Windows.Forms.Button btnBilgiDüzenle;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox rchTeshis;
        private System.Windows.Forms.Button btnTeshis;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label LABEL6;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RichTextBox rchRecete;
        private System.Windows.Forms.Button button1;
    }
}