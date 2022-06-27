using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunife_test
{
    public class Hesap:IHesap
    {

        public int HesapNumarasi { get; set; }

        public decimal Bakiye { get; set; }
        public DateTime AcilisTarihi { get; set; }

        
        public List<HesapOzeti> HesapOzeti { get; set; }

        public Hesap()
        {
            AcilisTarihi = DateTime.Now;
            HesapOzeti = new List<HesapOzeti>();
        }
        public string ParaYatirma(decimal Miktar)
        {
            
            this.Bakiye += Miktar;

            return "Para Yatırma İşleminiz başarıyla gerçekleştirildi";
        }

        public string ParaCekme(decimal Miktar)
        {
            if (Miktar > Bakiye)
            {

                return "Bakiyeniz yeterli değil";
            }
            else if(Miktar>750){
                return "750₺ den fazla çekemezsiniz.";
            }
            else
            {

                this.Bakiye -= Miktar;

                return "Para çekme işleminiz başarıyla gerçekleştirildi";

            }
        }


        public void Havale(int GonderenHesapNo, int AliciHesapNo)
        {
            throw new NotImplementedException();
        }


        public void HesapOzetiEkle(HesapOzeti ho)
        {
            HesapOzeti.Add(ho);
        }
    }
}
