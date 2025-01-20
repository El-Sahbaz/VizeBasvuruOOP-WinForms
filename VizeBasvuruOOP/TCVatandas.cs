using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizeBasvuruOOP
{
    class TCVatandas
    {
        public long TCKimlikNo { get; set; }
        public string AdSoyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public DateTime SistemeKayitTarihi { get; set; }

        public TCVatandas()
        {
            SistemeKayitTarihi = DateTime.Now;
        }

        public string VizeAl()
        {
            int Yas = YasHesapla(DogumTarihi);
            if(Yas >= 18)
            {
                return "Başvuru Yapabilirsiniz.";
            }
            else
            {
                return "Veli Izni Gerekli";
            }

        }

        private int YasHesapla(DateTime dogumTarihi)
        {           
            return  DateTime.Today.Year - dogumTarihi.Year;
        }
    }
}
