using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunife_test
{
    public class Banka
    {



        private List<Musteri> Musteriler { get; set; }

        public string BankaAdi { get; set; }



        public Banka()
        {
            Musteriler = new List<Musteri>();
        }

        public void MusteriEkle(Musteri m)
        {
            if (Musteriler.Count == 0)
            {
                Random r = new Random();
                m.MusteriNumarasi = r.Next(1,1000);
                Random r1 = new Random();
                m.Sifre = r1.Next(1000,9999);
            }
            else
            {

                foreach (var m1 in Musteriler)
                {
                    Random r = new Random();
                    int no = r.Next(1,1000);
                    Random r1 = new Random();
                    int no1=r1.Next(1000,9999);
                    if (no != m1.MusteriNumarasi)
                    {

                        m.MusteriNumarasi = no;

                    }
                    if (no1 != m1.Sifre)
                    {

                        m.Sifre = no1;

                    }

                    
                }

            }
            Musteriler.Add(m);

        }


        public List<Musteri> MusteriListele()
        {

            return Musteriler;

        }

        public void MusteriSil(Musteri m)
        {
            Musteriler.Remove(m);
        }

    }
}
