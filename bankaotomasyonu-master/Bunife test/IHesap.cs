using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunife_test
{
    public interface IHesap
    {
        string ParaYatirma(decimal Miktar);

        string ParaCekme(decimal Miktar);

        void Havale(int GonderenHesapNo,int AliciHesapNo);

        void HesapOzetiEkle(HesapOzeti ho);
    }
}
