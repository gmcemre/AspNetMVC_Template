using AspNetMVC_Template.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetMVC_Template.App_Classes
{
    public class Sepet
    {
        private List<Urunler> _Urunler = new List<Urunler>();

        public List<Urunler> Urunler
        {
            get { return _Urunler; }
            set { _Urunler = value; }
        }

    }
}