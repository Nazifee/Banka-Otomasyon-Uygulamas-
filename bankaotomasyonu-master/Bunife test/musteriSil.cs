using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bunife_test
{
    public partial class musteriSil : UserControl
    {
       
        public musteriSil()
        {
            InitializeComponent();
        }

        private void musteriSil_Load(object sender, EventArgs e)
        {

        }

        private void btnHesapSil_Click(object sender, EventArgs e)
        {
            int MusteriNumarasi;
            MusteriNumarasi = Convert.ToInt32(txtMusteriNo.Text);

            foreach (var m in frmGiris.Banka.MusteriListele())
            {

                if (m.MusteriNumarasi == MusteriNumarasi)
                {
                    frmGiris.Banka.MusteriSil(m);

                    MessageBox.Show("Müşteri Başarıyla silinmiştir..");
                    break;

                }

            }
        }

        private void txtMusteriNo_Enter(object sender, EventArgs e)
        {
            txtMusteriNo.Text = "";
        }

        private void txtMusteriNo_Leave(object sender, EventArgs e)
        {
            if (txtMusteriNo.Text == "")
                txtMusteriNo.Text = "Müşteri Numarası";
        }
    }
}
