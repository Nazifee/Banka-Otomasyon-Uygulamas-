using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using u4_DovizKuru;

namespace Bunife_test
{
    public partial class kur : Form
    {
        public kur()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("http://www.tcmb.gov.tr/kurlar/today.xml"); 
            XmlElement rootEleman = xmlDoc.DocumentElement; 
            XmlNodeList liste = rootEleman.GetElementsByTagName("Currency");   
            List<Doviz> dlist = new List<Doviz>();
            foreach (var item in liste)
            {
                Doviz d = new Doviz();
                XmlElement currency = (XmlElement)item;
                string isim = currency.GetElementsByTagName("Isim").Item(0).InnerText;

                d.DovizAd = isim;
                string alisFiyat = currency.GetElementsByTagName("ForexBuying").Item(0).InnerText;
                string satisFiyat = currency.GetElementsByTagName("ForexSelling").Item(0).InnerText;
                string birim = currency.GetElementsByTagName("Unit").Item(0).InnerText;

                if (!string.IsNullOrEmpty(alisFiyat))
                {
                    d.AlisFiyat = Convert.ToDecimal(alisFiyat) / 10000;
                }
                if (!string.IsNullOrEmpty(satisFiyat))
                {
                    d.SatisFiyat = Convert.ToDecimal(satisFiyat) / 10000;
                }
                if (!string.IsNullOrEmpty(birim))
                {
                    d.Birim = Convert.ToInt32(birim);
                }
                listBox1.Items.Add(d);
                dlist.Add(d);
            }
            dataGridView2.DataSource = dlist;
            int i = 0;
            foreach (var a in dlist)    // datagridview1 e 2 adet sütunu yazdırma
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = a.DovizAd;
                dataGridView1.Rows[i].Cells[1].Value = a.SatisFiyat;
                i++;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Doviz secilenDoviz = (Doviz)listBox1.SelectedItem;
            lblAlis.Text = secilenDoviz.AlisFiyat.ToString();
            lblSatis.Text = secilenDoviz.SatisFiyat.ToString();
            lblBirim.Text = secilenDoviz.Birim.ToString();
        }
    }
}
