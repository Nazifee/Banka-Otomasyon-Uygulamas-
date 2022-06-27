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
    public partial class frmMusteri : Form
    {

        public int MusteriNumarasi;
        private bool mouseDown;
        private Point lastLocation;
        public frmMusteri()
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
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnParaCek_Click(object sender, EventArgs e)
        {
            lblHeader1.Text = btnParaCek.Text;
            paraYatir1.Visible = false;
            paraCek1.Visible = true;
            havaleYap1.Visible = false;
            uHesapOzeti1.Visible = false;
            paraCek1.MusteriNumarasi = MusteriNumarasi;
            
        }

        private void btnParaYatir_Click(object sender, EventArgs e)
        {

            lblHeader1.Text = btnParaYatir.Text;
            paraYatir1.Visible = true;
            paraCek1.Visible = false;
            havaleYap1.Visible = false;
            uHesapOzeti1.Visible = false;
            paraYatir1.MusteriNumarasi = MusteriNumarasi;
        }

        private void frmMusteri_Load(object sender, EventArgs e)
        {
            lblHeader1.Text = btnParaYatir.Text;
            paraYatir1.Visible = true;
            paraCek1.Visible = false;
            havaleYap1.Visible = false;
            uHesapOzeti1.Visible = false;
            paraYatir1.MusteriNumarasi = MusteriNumarasi;
            paraCek1.MusteriNumarasi = MusteriNumarasi;
            uHesapOzeti1.MusteriNumarasi = MusteriNumarasi;
            havaleYap1.MusteriNumarasi = MusteriNumarasi;
            
        }

        private void btnHavaleYap_Click(object sender, EventArgs e)
        {
            lblHeader1.Text = btnHavaleYap.Text;
            paraYatir1.Visible = false;
            paraCek1.Visible = false;
            havaleYap1.Visible = true;
            uHesapOzeti1.Visible = false;
            havaleYap1.MusteriNumarasi = MusteriNumarasi;
        }

        private void btnBakiyeGoruntule_Click(object sender, EventArgs e)
        {
            lblHeader1.Text = btnBakiyeGoruntule.Text;
            paraYatir1.Visible = false;
            paraCek1.Visible = false;
            havaleYap1.Visible = false;
            uHesapOzeti1.Visible = true;
            uHesapOzeti1.MusteriNumarasi = MusteriNumarasi;
        }

        private void uHesapOzeti1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            frmGiris frm = new frmGiris();
            frm.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kur kur=new kur();  
            kur.Show();
        }
    }
}
