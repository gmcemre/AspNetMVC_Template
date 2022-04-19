using System;
using System.Collections.Generic;

namespace AspNetMVC_Template.Models
{
    public partial class Ayrintili_Satis_Detaylari
    {
        public int SatisID { get; set; }
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public decimal BirimFiyati { get; set; }
        public short Miktar { get; set; }
        public float İndirim { get; set; }
        public Nullable<decimal> ExtendedPrice { get; set; }
    }
}
