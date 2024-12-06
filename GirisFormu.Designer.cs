namespace HastaneYönetimOtomasyonu
{
    partial class GirisFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisFormu));
            this.btnHasta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnYetkili = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHasta
            // 
            this.btnHasta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHasta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHasta.Image = ((System.Drawing.Image)(resources.GetObject("btnHasta.Image")));
            this.btnHasta.Location = new System.Drawing.Point(508, 260);
            this.btnHasta.Name = "btnHasta";
            this.btnHasta.Size = new System.Drawing.Size(261, 66);
            this.btnHasta.TabIndex = 5;
            this.btnHasta.Text = "Hasta Girişi";
            this.btnHasta.UseVisualStyleBackColor = true;
            this.btnHasta.Click += new System.EventHandler(this.btnHasta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rosewood Std Regular", 40.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(86, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(561, 78);
            this.label1.TabIndex = 7;
            this.label1.Text = "DIGITAL HOSPITAL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(138, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(472, 54);
            this.label5.TabIndex = 12;
            this.label5.Text = "Sağlığınız Emanetimizdir";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(1, 503);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(786, 148);
            this.label6.TabIndex = 13;
            this.label6.Text = "Türkiyenin her yerinde sağlığınız için çalışmaya devam ediyor.\r\nDeneyimli doktor " +
    "kadromuz ve özverili çalışanlarımız ile\r\n7/24 Hizmetinizdeyiz.\r\n\r\n";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(653, 51);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(81, 75);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // btnYetkili
            // 
            this.btnYetkili.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYetkili.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYetkili.Image = ((System.Drawing.Image)(resources.GetObject("btnYetkili.Image")));
            this.btnYetkili.Location = new System.Drawing.Point(147, 260);
            this.btnYetkili.Name = "btnYetkili";
            this.btnYetkili.Size = new System.Drawing.Size(261, 66);
            this.btnYetkili.TabIndex = 17;
            this.btnYetkili.Text = "Doktor/Asistan Girişi";
            this.btnYetkili.UseVisualStyleBackColor = true;
            this.btnYetkili.Click += new System.EventHandler(this.btnYetkili_Click);
            // 
            // GirisFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(871, 679);
            this.Controls.Add(this.btnYetkili);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHasta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GirisFormu";
            this.Text = "Digital Hospital";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHasta;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnYetkili;
    }
}

