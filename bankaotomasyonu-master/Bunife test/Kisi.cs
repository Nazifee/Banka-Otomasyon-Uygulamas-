using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunife_test
{
    public abstract class Kisi
    {
        public Iletisim Iletisim { get; set; }

        public Kimlik Kimlik { get; set; }

        public Kisi()
        {

            Kimlik = new Kimlik();

            Iletisim = new Iletisim();

            
        }

    }
}
