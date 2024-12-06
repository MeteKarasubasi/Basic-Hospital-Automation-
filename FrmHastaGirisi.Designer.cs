namespace HastaneYönetimOtomasyonu
{
    partial class FrmHastaGirisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaGirisi));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lnkUyeOl = new System.Windows.Forms.LinkLabel();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(139, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik No :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(214, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lnkUyeOl
            // 
            this.lnkUyeOl.AutoSize = true;
            this.lnkUyeOl.BackColor = System.Drawing.Color.Transparent;
            this.lnkUyeOl.ForeColor = System.Drawing.Color.Yellow;
            this.lnkUyeOl.LinkColor = System.Drawing.Color.Yellow;
            this.lnkUyeOl.Location = new System.Drawing.Point(460, 293);
            this.lnkUyeOl.Name = "lnkUyeOl";
            this.lnkUyeOl.Size = new System.Drawing.Size(72, 25);
            this.lnkUyeOl.TabIndex = 2;
            this.lnkUyeOl.TabStop = true;
            this.lnkUyeOl.Text = "Üye Ol";
            this.lnkUyeOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkUyeOl_LinkClicked);
            // 
            // mskTC
            // 
            this.mskTC.Location = new System.Drawing.Point(294, 244);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(147, 30);
            this.mskTC.TabIndex = 3;
            this.mskTC.ValidatingType = typeof(int);
            this.mskTC.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskTC_MaskInputRejected);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(294, 288);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(147, 30);
            this.txtSifre.TabIndex = 4;
            this.txtSifre.UseSystemPasswordChar = true;
            this.txtSifre.TextChanged += new System.EventHandler(this.txtSifre_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Calligraphy", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(78, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(521, 64);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hasta Giris Paneli";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(324, 324);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(88, 41);
            this.btnGiris.TabIndex = 6;
            this.btnGiris.Text = "Giriş ";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(552, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmHastaGirisi
            // 
            this.AcceptButton = this.btnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(691, 515);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.mskTC);
            this.Controls.Add(this.lnkUyeOl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmHastaGirisi";
            this.Text = "Hasta Girişi";
            this.Load += new System.EventHandler(this.FrmHastaGirisi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lnkUyeOl;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button button1;
    }
}