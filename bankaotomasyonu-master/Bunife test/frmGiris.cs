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
    public partial class frmGiris : Form
    {
        public static Banka Banka = new Banka();
        private bool mouseDown;
        private Point lastLocation;
        public frmGiris()
        {
            InitializeComponent();
        }

        private void sidePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                Cursor.Current = Cursors.SizeAll;
                this.Update();
            }
        }

        private void sidePanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void sidePanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnYoneticiGiris_Click(object sender, EventArgs e)
        {
            frmYoneticiGiris frm = new frmYoneticiGiris();
            frm.Show();
            this.Visible=false;

            
        }
        
        

        private void btnMusteriGiris_Click(object sender, EventArgs e)
        {
            frmMusteriGiris frm = new frmMusteriGiris();
            frm.Show();
            this.Visible = false;
        }
    }
}
