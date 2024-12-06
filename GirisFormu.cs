using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneYönetimOtomasyonu
{
    public partial class GirisFormu : Form
    {
        const int GWL_STYLE = -16;
        const int WS_BORDER = 0x00800000;
        const int WS_CAPTION = 0x00C00000;
        const int WS_SYSMENU = 0x00080000;
        const int WS_MINIMIZEBOX = 0x00020000;
        const int WS_MAXIMIZEBOX = 0x00010000;

        const int SWP_NOSIZE = 0x0001;
        const int SWP_NOMOVE = 0x0002;
        const int SWP_FRAMECHANGED = 0x0020;

        [DllImport("user32.dll")]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll")]
        private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        public GirisFormu()
        {
            InitializeComponent();

            // Formun kenarlıklarını kaldırma
            int style = GetWindowLong(this.Handle, GWL_STYLE);
            style &= ~(WS_BORDER | WS_CAPTION | WS_SYSMENU | WS_MINIMIZEBOX | WS_MAXIMIZEBOX);
            SetWindowLong(this.Handle, GWL_STYLE, style);
            SetWindowPos(this.Handle, IntPtr.Zero, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE | SWP_FRAMECHANGED);

            // Formu gösterme
            ShowWindow(this.Handle, 1); // SW_SHOWNORMAL

            // Form olaylarını tanımlama
            this.MouseDown += (sender, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            };

            // Formu boyutlandırma, küçültme ve kapatma butonlarını etkinleştirme
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.ControlBox = true;




        }

        // Windows API mesajları
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void Form1_Load(object sender, EventArgs e)
        {
    
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHasta_Click(object sender, EventArgs e)
        {
            FrmHastaGirisi fr = new FrmHastaGirisi();
            fr.Show();
            this.Hide();
        }

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnYetkili_Click(object sender, EventArgs e)
        {
            FrmYetkili fr = new FrmYetkili();
            fr.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}