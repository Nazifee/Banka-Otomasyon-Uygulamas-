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
    public partial class paraYatir : UserControl
    {
        public int MusteriNumarasi { get; set; }
        public paraYatir()
        {
            InitializeComponent();
        }


        private void txtYatirilacakMiktar_Enter(object sender, EventArgs e)
        {
            txtYatirilacakMiktar.Text = "";
        }

        private void txtYatirilacakMiktar_Leave(object sender, EventArgs e)
        {
            if (txtYatirilacakMiktar.Text == "")
                txtYatirilacakMiktar.Text = "Yatırılacak Tutarı Giriniz";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            decimal yatirilacak = Convert.ToDecimal(txtYatirilacakMiktar.Text);

            int secilenhesap = Convert.ToInt32(drpHesapNo.SelectedItem);

            foreach (var m in frmGiris.Banka.MusteriListele())
            {
                foreach (var h in m.Hesaplar)
                {
                    if (h.HesapNumarasi == secilenhesap)
                    {

                        MessageBox.Show(h.ParaYatirma(yatirilacak));
                        lblBakiye.Text = h.Bakiye.ToString() + "₺";
                        HesapOzeti ho = new HesapOzeti();
                        ho.Bakiye = h.Bakiye;
                        ho.IslemTutari = yatirilacak;
                        ho.Tarih = DateTime.Now;
                        ho.YapilanIslem = "Para Yatırma";
                        ho.IslemUcreti = 0;
                        h.HesapOzetiEkle(ho);
                    }
                }
                
            }
        }

        private void paraYatir_Load(object sender, EventArgs e)
        {
            
        }

        private void drpHesapNo_onItemSelected(object sender, EventArgs e)
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
                            lblBakiye.Text = h.Bakiye.ToString()+"₺";
                            
                        }
                    }

                }
            }

        }

        private void paraYatir_VisibleChanged(object sender, EventArgs e)
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
    }
}
