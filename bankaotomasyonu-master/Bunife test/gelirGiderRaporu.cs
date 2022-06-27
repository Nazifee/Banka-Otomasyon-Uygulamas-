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
    public partial class gelirGiderRaporu : UserControl
    {
        public int MusteriNumarasi;
        public gelirGiderRaporu()
        {
            InitializeComponent();
        }

        private void dtpTarih_onValueChanged(object sender, EventArgs e)
        {
            lstwGelirGider.Items.Clear();
            DateTime tarih = Convert.ToDateTime(dtpTarih.Value);
            decimal gelen=0, giden=0,geneltoplam;
            foreach (var m in frmGiris.Banka.MusteriListele())
            {
                foreach (var h in m.Hesaplar)
                {

                    foreach (var ho in h.HesapOzeti)
                    {
                        if (ho.YapilanIslem == "Para Yatırma")
                        {
                            if (ho.Tarih == tarih) {    
                                gelen +=Convert.ToDecimal(ho.IslemTutari)+Convert.ToDecimal(ho.IslemUcreti);
                            }

                        }
                        else if (ho.YapilanIslem == "Para Çekme")
                        {
                            if (ho.Tarih == tarih)
                            {
                                giden += Convert.ToDecimal(ho.IslemTutari);
                            }
                            

                        }
                    }

                }
                
                geneltoplam=gelen+giden;
                ListViewItem l = new ListViewItem();

                l.Text = gelen.ToString();

                l.SubItems.Add(giden.ToString());

                l.SubItems.Add(geneltoplam.ToString());

                lstwGelirGider.Items.Add(l);

            }

        
        }
    }
}
