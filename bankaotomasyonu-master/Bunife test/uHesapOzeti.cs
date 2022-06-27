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

    
    public partial class uHesapOzeti : UserControl
    {
        public int MusteriNumarasi;
        public uHesapOzeti()
        {
            InitializeComponent();
        }

        private void uHesapOzeti_VisibleChanged(object sender, EventArgs e)
        {
            drpHesapNo.Items.Clear();


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

        private void drpHesapNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int hesapno = Convert.ToInt32(drpHesapNo.SelectedItem);
            foreach (var m in frmGiris.Banka.MusteriListele())
            {
                if (m.MusteriNumarasi == MusteriNumarasi)
                {

                    foreach (var h in m.Hesaplar)
                    {
                        if (h.HesapNumarasi == hesapno)
                        {
                            lblBakiye.Text = h.Bakiye.ToString() + "₺";

                        }
                    }

                }
            }
        }

        private void btnHesapOzeti_Click(object sender, EventArgs e)
        {
            lstwHesapOzeti.Items.Clear();
            int secilenhesap = Convert.ToInt32(drpHesapNo.SelectedItem);
            foreach (var m in frmGiris.Banka.MusteriListele())
            {
                foreach (var h in m.Hesaplar)
                {
                    if (h.HesapNumarasi == secilenhesap)
                    {

                        foreach (var ho in h.HesapOzeti)
                        {
                            ListViewItem l = new ListViewItem();
                            l.Text = ho.Tarih.ToShortDateString();
                            l.SubItems.Add(ho.YapilanIslem);
                            l.SubItems.Add(ho.IslemTutari.ToString()+"₺");
                            l.SubItems.Add(ho.Bakiye.ToString()+"₺");
                            l.SubItems.Add(ho.IslemUcreti.ToString()+"₺");
                            lstwHesapOzeti.Items.Add(l);
                        }
                    }
                }

            }
        }
    }
}
