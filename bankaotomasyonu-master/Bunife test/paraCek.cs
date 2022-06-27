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
    public partial class paraCek : UserControl
    {
        public int MusteriNumarasi;
        public paraCek()
        {
            InitializeComponent();
        }

        private void txtCekilecekMiktari_Enter(object sender, EventArgs e)
        {
            txtCekilecekMiktari.Text = "";
        }

        private void txtCekilecekMiktari_Leave(object sender, EventArgs e)
        {
            if(txtCekilecekMiktari.Text == "")
                txtCekilecekMiktari.Text = "Çekilecek Miktarı Giriniz";
        }

        private void paraCek_VisibleChanged(object sender, EventArgs e)
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

        private void btnEkle_Click(object sender, EventArgs e)
        {
            decimal cekilecek = Convert.ToInt32(txtCekilecekMiktari.Text);
            int secilenHesap = Convert.ToInt32(drpHesapNo.SelectedItem);
            foreach (var m in frmGiris.Banka.MusteriListele())
            {
                foreach (var h in m.Hesaplar)
                {
                    if (h.HesapNumarasi == secilenHesap)
                    {

                        MessageBox.Show(h.ParaCekme(cekilecek));
                        lblBakiye.Text = h.Bakiye.ToString() + "₺";
                        HesapOzeti ho = new HesapOzeti();
                        ho.Bakiye = h.Bakiye;
                        ho.IslemTutari = -cekilecek;
                        ho.YapilanIslem = "Para Çekme";
                        ho.Tarih = DateTime.Now;
                        ho.IslemUcreti = 0;
                        h.HesapOzetiEkle(ho);
                    }
                }

            }
        }
    }
}
