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
    public partial class hesapEkle : UserControl
    {
        public hesapEkle()
        {
            InitializeComponent();
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

        private void btnHesapAc_Click(object sender, EventArgs e)
        {
            int MusteriNumarasi,say=0;
            if (txtMusteriNo.Text=="" || txtMusteriNo.Text=="Müşteri Numarası")
            {

                MessageBox.Show("Lütfen Müşteri Numarası giriniz ...");

            }
            else
            {

                MusteriNumarasi = Convert.ToInt32(txtMusteriNo.Text);
                foreach (var m in frmGiris.Banka.MusteriListele())
                {
                    if (m.MusteriNumarasi == MusteriNumarasi)
                    {
                        say++;
                        Hesap h = new Hesap();

                        m.HesapAc(h);

                        MessageBox.Show("Hesap Açma İşlemi Başarıyla Gerçekleştirildi.Hesap numarasi :"+h.HesapNumarasi);


                    }
                    
                }
                if (say == 0)
                {
                    
                       MessageBox.Show("Böyle bir müşteri bulunmamaktadır.");
                    
                }
            }
        }

        private void btnHesapListele_Click(object sender, EventArgs e)
        {
            int MusteriNumarasi;
            lstwHesaplar.Items.Clear();
            if (txtMusteriNo.Text == "" || txtMusteriNo.Text == "Müşteri Numarası")
            {

                MessageBox.Show("Lütfen Müşteri Numarası giriniz ...");

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

                            ListViewItem l = new ListViewItem();
                            l.Text = h.HesapNumarasi.ToString();
                            l.SubItems.Add(h.Bakiye.ToString());
                            lstwHesaplar.Items.Add(l);
                        }


                    }
                }
            }
        }

        private void hesapEkle_Load(object sender, EventArgs e)
        {

        }

        private void hesapEkle_VisibleChanged(object sender, EventArgs e)
        {
            lstwHesaplar.Items.Clear();
            txtMusteriNo.Text = "Müşteri Numarası";
        }
    }
}
