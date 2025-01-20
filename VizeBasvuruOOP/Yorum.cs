using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizeBasvuruOOP
{
    class Yorum
    {
        public string AdSoyad { get; set; }
        public DateTime YorumYazilmaTarihi { get; set; }
        public string GoreceliZaman 
        {
            get
            {
                TimeSpan sure = DateTime.Now - YorumYazilmaTarihi;

                if (sure.TotalSeconds < 20)
                {
                    return "Şimdi";
                }
                else if (sure.TotalSeconds < 60)
                {
                    return sure.Seconds + " sn önce";
                }
                else if(sure.TotalMinutes < 60)
                {
                    return sure.Minutes + " dk önce";
                }
                else if (sure.Hours >= 1 && sure.TotalHours < 24)
                {
                    return sure.Hours + " saat önce";
                }
                else if (sure.Days >= 1 && sure.Days < 365)
                {
                    return sure.Days + " gün önce";
                }
                else if (sure.Days >=365)
                {
                    return sure.Days / 365 + " yıl önce";
                }
                return sure.Days + " gün" + sure.Hours + " saat" + sure.Minutes + " dakika" + sure.Seconds + " saniye önce";
            }
                
          
        }
        public Yorum()
        {
            YorumYazilmaTarihi = DateTime.Now;
        }





    }
}
