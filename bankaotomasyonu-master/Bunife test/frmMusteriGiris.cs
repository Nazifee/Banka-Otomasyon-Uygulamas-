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
    public partial class frmMusteriGiris : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public frmMusteriGiris()
        {
            InitializeComponent();
        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMusteriGiris_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void frmMusteriGiris_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void frmMusteriGiris_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void frmMusteriGiris_Load(object sender, EventArgs e)
        {
           
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            int musteriNumarasi,sifre,say=0;

            musteriNumarasi = Convert.ToInt32(txtKullaniciAdi.Text);
            sifre = Convert.ToInt32(txtSifre.Text);

            foreach (var m in frmGiris.Banka.MusteriListele())
            {

                if (m.MusteriNumarasi == musteriNumarasi)
                {
                    say++;
                    if (m.Sifre == sifre)
                    {

                        frmMusteri frm = new frmMusteri();
                        frm.MusteriNumarasi = m.MusteriNumarasi;
                        this.Visible = false;
                        frm.Show();

                    }
                    else
                    {
                        MessageBox.Show("Müþteri þifrenizi yanlýþ girdiniz , lütfen yöneticinizden kontrol ediniz.");
                    }

                }
                
                
            }
            if(say==0){
                MessageBox.Show("Müþteri Numaranýzý Yanlýþ Girdiniz.");

            }
        }

        private void txtSifre_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
