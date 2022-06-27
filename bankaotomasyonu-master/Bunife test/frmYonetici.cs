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
    public partial class frmYonetici : Form
    {
        public Banka Banka { get; set; }
        private bool mouseDown;
        private Point lastLocation;
        public frmYonetici()
        {
            InitializeComponent();
        }

        private void headerPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
           
        }

        private void headerPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                Cursor.Current = Cursors.SizeAll;
                this.Update();
            }
        }

        private void headerPanel_MouseUp(object sender, MouseEventArgs e)
        {

            mouseDown = false;


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmYonetici_Load(object sender, EventArgs e)
        {
            lblHeader.Text = btnMusteriEkle.Text;
            hesapEkle1.Visible = false;
            hesapSil1.Visible = false;
            musteriSil1.Visible = false;
            gelirGiderRaporu1.Visible = false;
            

        }
        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            lblHeader.Text = btnMusteriEkle.Text;
            hesapEkle1.Visible = false;
            musteriEkle1.Visible = true;
            hesapSil1.Visible = false;
            musteriSil1.Visible = false;
            gelirGiderRaporu1.Visible = false;

        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            lblHeader.Text = btnMusteriSil.Text;
            musteriEkle1.Visible = false;
            hesapEkle1.Visible = false;
            hesapSil1.Visible = false;
            musteriSil1.Visible = true;
            gelirGiderRaporu1.Visible = false;


        }

        private void btnHesapEkle_Click(object sender, EventArgs e)
        {
            lblHeader.Text = btnHesapEkle.Text;
            musteriEkle1.Visible = false;
            hesapEkle1.Visible = true;
            hesapSil1.Visible = false;
            musteriSil1.Visible = false;
            gelirGiderRaporu1.Visible = false;

        }

        private void btnHesapSil_Click(object sender, EventArgs e)
        {
            lblHeader.Text = btnHesapSil.Text;
            musteriEkle1.Visible = false;
            hesapEkle1.Visible = false;
            hesapSil1.Visible = true;
            musteriSil1.Visible = false;
            gelirGiderRaporu1.Visible = false;
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            lblHeader.Text = btnRapor.Text;
            hesapEkle1.Visible = false;
            musteriEkle1.Visible = false;
            hesapSil1.Visible = false;
            musteriSil1.Visible = false;
            gelirGiderRaporu1.Visible = true;
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            frmGiris frm = new frmGiris();
            frm.Show();
            this.Visible = false;
            
        }

      
    }
}
