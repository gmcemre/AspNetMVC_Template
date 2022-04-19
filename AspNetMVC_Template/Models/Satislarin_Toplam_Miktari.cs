using System;
using System.Collections.Generic;

namespace AspNetMVC_Template.Models
{
    public partial class Satislarin_Toplam_Miktari
    {
        public Nullable<decimal> SaleAmount { get; set; }
        public int SatisID { get; set; }
        public string SirketAdi { get; set; }
        public Nullable<System.DateTime> SevkTarihi { get; set; }
    }
}
