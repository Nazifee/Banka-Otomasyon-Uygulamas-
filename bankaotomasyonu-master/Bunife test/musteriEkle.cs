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
    public partial class musteriEkle : UserControl

    {
        public musteriEkle()
        {
            InitializeComponent();
        }


        public void MusteriListele()
        {
            //lstMusteriler.Items.Clear();
            //foreach (var m in frmGiris.Banka.MusteriListele())
            //{
            //    lstMusteriler.Items.Add("Müşteri Numarası :"+m.MusteriNumarasi);


            //}
            lstwMusteriListele.Items.Clear();
            foreach (var m in frmGiris.Banka.MusteriListele())
            {
                ListViewItem a = new ListViewItem();
                a.Text = m.MusteriNumarasi.ToString();
                a.SubItems.Add(m.Kimlik.Ad);
                a.SubItems.Add(m.Kimlik.Soyad);
                a.SubItems.Add(m.Iletisim.Telefon.ToString());
                a.SubItems.Add(m.Iletisim.Email);
                if (m.MusteriTuru == true)
                {
                    a.SubItems.Add("Ticari Müşteri");
                }
                else
                {
                    a.SubItems.Add("Bireysel Müşteri");
                }
                lstwMusteriListele.Items.Add(a);
            }


        }
        private void txtAd_Enter(object sender, EventArgs e)
        {
            txtAd.Text = "";
        }
        private void txtSoyad_Enter(object sender, EventArgs e)
        {
            txtSoyad.Text = "";
        }
        private void txtTc_Enter(object sender, EventArgs e)
        {
            txtTc.Text = "";
        }
        private void txtDogumYeri_Enter(object sender, EventArgs e)
        {
            txtDogumYeri.Text = "";
        }
        private void txtAdres_Enter(object sender, EventArgs e)
        {
            txtAdres.Text = "";
        }
        private void txtTelefon_Enter(object sender, EventArgs e)
        {
            txtTelefon.Text = "";
        }
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            txtEmail.Text = "";
        }

        private void txtAd_Leave(object sender, EventArgs e)
        {
            if(txtAd.Text=="")
                txtAd.Text = "Ad";
        }

        private void txtSoyad_Leave(object sender, EventArgs e)
        {
            if (txtSoyad.Text == "")
                txtSoyad.Text = "Soyad";
        }

        private void txtTc_Leave(object sender, EventArgs e)
        {
            if (txtTc.Text == "")
                txtTc.Text = "Tc Kimlik Numarası";
        }

        private void txtDogumYeri_Leave(object sender, EventArgs e)
        {
            if (txtDogumYeri.Text == "")
                txtDogumYeri.Text = "Doğum Yeri";
        }

        private void txtAdres_Leave(object sender, EventArgs e)
        {
            if (txtAdres.Text == "")
                txtAdres.Text = "Adres";
        }

        private void txtTelefon_Leave(object sender, EventArgs e)
        {
            if (txtTelefon.Text == "")
                txtTelefon.Text = "Telefon";
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
                txtEmail.Text = "Email";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string Ad, Soyad, DogumYeri, Adres, Email;
            ulong Telefon=0, TcKimlikNo=0;
            DateTime DogumTarihi;
            Boolean MusteriTuru;
            Ad = txtAd.Text;
            Soyad = txtSoyad.Text;
            DogumYeri = txtDogumYeri.Text;
            Adres = txtAdres.Text;
            Email = txtEmail.Text;
            if (rdbBireysel.Checked)
            {
                MusteriTuru = false;

            }
            else
            {
                MusteriTuru = true;
            }
            if ((txtTc.Text != "" && txtTc.Text != "Tc Kimlik Numarası") && (txtTelefon.Text != "" && txtTelefon.Text != "Telefon")) { 
                Telefon = Convert.ToUInt64(txtTelefon.Text);
                TcKimlikNo = Convert.ToUInt64(txtTc.Text);
            }
            DogumTarihi = Convert.ToDateTime(dtDogumTarihi.Value);

            if (Ad == "Ad" || Ad == "" || Soyad == "Soyad" || Soyad == "" || DogumYeri == "Doğum Yeri" || DogumYeri == "" || Adres == "Adres" || Adres == "" || Email == "Email" || Email == "" || txtTc.Text == "Tc Kimlik Numarası" || txtTc.Text=="" || DogumTarihi==null )
            {

                MessageBox.Show("Lütfen boş alan bırakmayınız..");


            }
            else
            {
                if (MusteriTuru == false) { 
                    BireyselMusteri m = new BireyselMusteri();
                    m.Kimlik.Ad = Ad;
                    m.Kimlik.Soyad = Soyad;
                    m.Kimlik.DogumTarihi = DogumTarihi;
                    m.Kimlik.DogumYeri = DogumYeri;

                    m.Kimlik.TcKimlikNo = TcKimlikNo;

                    m.Iletisim.Adres = Adres;

                    m.Iletisim.Email = Email;

                    m.Iletisim.Telefon = Telefon;
                    
                    frmGiris.Banka.MusteriEkle(m);

                    MessageBox.Show("Musteri Numarası : "+m.MusteriNumarasi+"Musterinin Sifresi : "+m.Sifre);
                    MusteriListele();
                
                    

                }
                else
                {
                    
                    TicariMusteri m = new TicariMusteri();
                    m.Kimlik.Ad = Ad;
                    m.Kimlik.Soyad = Soyad;
                    m.Kimlik.DogumTarihi = DogumTarihi;
                    m.Kimlik.DogumYeri = DogumYeri;

                    m.Kimlik.TcKimlikNo = TcKimlikNo;

                    m.Iletisim.Adres = Adres;

                    m.Iletisim.Email = Email;

                    m.Iletisim.Telefon = Telefon;

                    frmGiris.Banka.MusteriEkle(m);

                    MessageBox.Show("Musteri Numarası : " + m.MusteriNumarasi + "Musterinin Sifresi : " + m.Sifre);

                    MusteriListele();
                    

                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void musteriEkle_Load(object sender, EventArgs e)
        {
            MusteriListele();
            
        }

        private void lstMusteriler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void musteriEkle_VisibleChanged(object sender, EventArgs e)
        {
            MusteriListele();
        }
    }
}
