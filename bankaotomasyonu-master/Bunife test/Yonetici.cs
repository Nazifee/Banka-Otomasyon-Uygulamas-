using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunife_test
{
    public class Yonetici:Kisi
    {

        public string KullaniciAdi { get; set; }

        public string Sifre { get; set; }

        public int KullaniciKontrol(string kullaniciAdi, string sifre)
        {

            if (KullaniciAdi == kullaniciAdi && Sifre == sifre)
                return 1;
            else
                return 0;

        }
    }
}
