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
    public partial class hesapSil : UserControl
    {
        public hesapSil()
        {
            InitializeComponent();
        }

        private void txtMusteriNo_OnValueChanged(object sender, EventArgs e)
        {
            drpHesapNo.Items.Clear();
            int MusteriNumarasi;

            if (txtMusteriNo.Text == "" || txtMusteriNo.Text == "Müşteri Numarası")
            {


            }
            else
            {
                MusteriNumarasi = Convert.ToInt32(txtMusteriNo.Text);
                foreach (var m in frmGiris.Banka.MusteriListele())
                {

                    if (m.MusteriNumarasi == MusteriNumarasi)
                    {
                        foreach (var h in m.Hesaplar)
                        {
                           
                            drpHesapNo.Items.Add(h.HesapNumarasi.ToString());
                        }

                    }

                }

            }
        }

        private void btnHesapSil_Click(object sender, EventArgs e)
        {
            int silinecek = Convert.ToInt32(drpHesapNo.SelectedItem);
            foreach (var m in frmGiris.Banka.MusteriListele())
            {
                foreach (var h in m.Hesaplar)
                {
                    if (h.HesapNumarasi == silinecek)
                    {

                        m.HesapKapat(h);
                        MessageBox.Show("Hesap başarıyla silinmiştir.");
                        break;
                    }
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
