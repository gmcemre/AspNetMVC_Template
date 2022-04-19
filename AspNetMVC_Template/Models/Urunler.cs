using System;
using System.Collections.Generic;

namespace AspNetMVC_Template.Models
{
    public partial class Urunler
    {
        public Urunler()
        {
            this.Satis_Detaylari = new List<Satis_Detaylari>();
        }

        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public Nullable<int> TedarikciID { get; set; }
        public Nullable<int> KategoriID { get; set; }
        public string BirimdekiMiktar { get; set; }
        public Nullable<decimal> BirimFiyati { get; set; }
        public Nullable<short> HedefStokDuzeyi { get; set; }
        public Nullable<short> YeniSatis { get; set; }
        public Nullable<short> EnAzYenidenSatisMikatari { get; set; }
        public byte[] Resim { get; set; }
        public bool Sonlandi { get; set; }
        public virtual Kategoriler Kategoriler { get; set; }
        public virtual ICollection<Satis_Detaylari> Satis_Detaylari { get; set; }
        public virtual Tedarikciler Tedarikciler { get; set; }
    }
}
