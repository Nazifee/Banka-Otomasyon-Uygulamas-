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
    public partial class havaleYap : UserControl
    {
        public int MusteriNumarasi;
        public havaleYap()
        {
            InitializeComponent();
        }

        private void txtGonderilenHesap_Enter(object sender, EventArgs e)
        {
            txtGonderilenHesap.Text = "";
        }

        private void txtGonderilenHesap_Leave(object sender, EventArgs e)
        {
            if (txtGonderilenHesap.Text == "")
                txtGonderilenHesap.Text = "Gönderilecek Hesap Numarası";
        }

        private void txtGonderilenAdi_Enter(object sender, EventArgs e)
        {
            txtGonderilenAdi.Text = "";
        }

        private void txtGonderilenAdi_Leave(object sender, EventArgs e)
        {
            if (txtGonderilenAdi.Text == "")
                txtGonderilenAdi.Text = "Gönderilen Adı";
        }

        private void txtGonderilecekMiktar_Enter(object sender, EventArgs e)
        {
            txtGonderilecekMiktar.Text = "";
        }

        private void txtGonderilecekMiktar_Leave(object sender, EventArgs e)
        {
            if (txtGonderilecekMiktar.Text == "")
                txtGonderilecekMiktar.Text = "Gönderilecek Miktarı Giriniz";
        }

        private void havaleYap_VisibleChanged(object sender, EventArgs e)
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

        private void btnHavaleYap_Click(object sender, EventArgs e)
        {
            string Ad;
            int gonderilecekHesapNo;
            decimal Miktar;
            int gonderenHesapNo;
            gonderenHesapNo = Convert.ToInt32(drpHesapNo.SelectedItem);
            Ad = txtGonderilenAdi.Text;
            gonderilecekHesapNo = Convert.ToInt32(txtGonderilenHesap.Text);

            if (gonderenHesapNo == gonderilecekHesapNo)
            {
                MessageBox.Show("Aynı hesaba havale yapamazsınız ...");
            }
            else { 
                Miktar = Convert.ToDecimal(txtGonderilecekMiktar.Text);
                int s1 = 0, s2 = 0,s3=0;
                foreach (var m in frmGiris.Banka.MusteriListele())
                {
                    if (m.Kimlik.Ad == Ad)
                    {
                        s1++; 
                        foreach (var h in m.Hesaplar)
                        {
                            if (h.HesapNumarasi == gonderilecekHesapNo)
                            {
                               
                                s2++;
                                h.Bakiye += Miktar;
                                HesapOzeti ho = new HesapOzeti();
                                ho.Bakiye = h.Bakiye;
                                ho.IslemTutari = Miktar;
                                ho.Tarih = DateTime.Now;
                                ho.YapilanIslem = "Havale";
                                h.HesapOzetiEkle(ho);
                                MessageBox.Show("Havale işleminiz başarıyla gerçekleştirilmiştir.");
                                s3 = 1;
                            }
                        }

                    }
                }
                if (s1 == 0)
                {

                    MessageBox.Show("İsimle hesap numarası uyuşmadı.");
                }
                else if (s2 == 0)
                {
                    MessageBox.Show("Hesap Numarası bulunamadı...");
                }
                if (s3 == 1) {
                    foreach (var m in frmGiris.Banka.MusteriListele())
                    {

                        if (m.MusteriNumarasi == MusteriNumarasi)
                        {
                            foreach (var h in m.Hesaplar)
                            {
                                if (h.HesapNumarasi == gonderenHesapNo)
                                {
                                    if (m.MusteriTuru == true)
                                    {
                                        h.Bakiye -= Miktar;
                                        lblBakiye.Text = h.Bakiye.ToString();
                                        HesapOzeti ho1 = new HesapOzeti();
                                        ho1.Tarih = DateTime.Now;
                                        ho1.YapilanIslem = "Havale";
                                        ho1.IslemTutari = -Miktar;
                                        ho1.Bakiye = h.Bakiye;
                                        ho1.IslemUcreti = 0;
                                        h.HesapOzetiEkle(ho1);
                                    }
                                    else { 
                                        
                                        h.Bakiye -= Miktar+(Miktar*2/100);
                                        
                                        lblBakiye.Text = h.Bakiye.ToString();
                                        HesapOzeti ho1 = new HesapOzeti();
                                        ho1.Tarih = DateTime.Now;
                                        ho1.YapilanIslem = "Havale";
                                        ho1.IslemTutari = -Miktar;
                                        ho1.IslemUcreti -= Miktar * 2 / 100;
                                        ho1.Bakiye = h.Bakiye;
                                        h.HesapOzetiEkle(ho1);
                                    }
                                }
                            }
                        }

                    }
                }
            }

        }
    }
}
