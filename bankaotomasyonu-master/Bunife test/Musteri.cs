using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunife_test
{
    public class Musteri:Kisi
    {
        public int MusteriNumarasi { get; set; }
        public List<Hesap> Hesaplar { get; set; }
        public int Sifre { get; set; }
        public Boolean MusteriTuru { get; set; }
        public Musteri()
        {
            Hesaplar = new List<Hesap>();
            
        }

        public void HesapAc(Hesap h)
        {
            Random r = new Random();
            int no = r.Next(1, 1000);
            if (Hesaplar.Count == 0)
            {

                h.HesapNumarasi = no;

            }
            else
            {
                foreach (var h1 in Hesaplar)
                {
                    Random r1 = new Random();
                    int no1 = r1.Next(1,1000);
                    if (h1.HesapNumarasi != no1)
                    {

                        h.HesapNumarasi = no;

                    }

                }
            }
            Hesaplar.Add(h);

        }

        public void HesapKapat(Hesap h)
        {
            Hesaplar.Remove(h);

        }

    }
}
