using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u4_DovizKuru
{
    class Doviz
    {
        public int Birim { get; set; }
        public string DovizAd { get; set; }
        public decimal AlisFiyat { get; set; }
        public decimal SatisFiyat { get; set; }
        public override string ToString()
        {
            return DovizAd + " " + Birim;
        }
    }
}