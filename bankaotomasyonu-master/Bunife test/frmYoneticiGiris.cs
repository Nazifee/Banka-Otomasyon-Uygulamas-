using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bunife_test
{
    public partial class frmYoneticiGiris : Form
    {
        public Yonetici y1;
        private bool mouseDown;
        private Point lastLocation;
        public frmYoneticiGiris()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void frmYoneticiGiris_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void frmYoneticiGiris_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void frmYoneticiGiris_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void frmYoneticigiris_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            y1 = new Yonetici();

            y1.KullaniciAdi = "admin";
            y1.Sifre = "admin";

            if (y1.KullaniciKontrol(txtKullaniciAdi.Text, txtSifre.Text) == 1)
            {

                frmYonetici frm = new frmYonetici();
                frm.Show();
                this.Visible=false;

            }
            else
            {
                MessageBox.Show("Kullanýcý Adýnýzý veya þifrenizi yanlýþ girdiniz.");
            }
        }

        private void frmYoneticiGiris_Load_1(object sender, EventArgs e)
        {

        }

        private void txtSifre_OnValueChanged(object sender, EventArgs e)
        {
            txtSifre.isPassword = true;
        }
    }
}
