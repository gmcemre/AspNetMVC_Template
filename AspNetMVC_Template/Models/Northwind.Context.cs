﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AspNetMVC_Template.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class NorthwindEntities : DbContext
    {
        public NorthwindEntities()
            : base("name=NorthwindEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Bolge> Bolges { get; set; }
        public virtual DbSet<Bolgeler> Bolgelers { get; set; }
        public virtual DbSet<Kategoriler> Kategorilers { get; set; }
        public virtual DbSet<Kisiler> Kisilers { get; set; }
        public virtual DbSet<MusteriDemographic> MusteriDemographics { get; set; }
        public virtual DbSet<Musteriler> Musterilers { get; set; }
        public virtual DbSet<Nakliyeciler> Nakliyecilers { get; set; }
        public virtual DbSet<Personeller> Personellers { get; set; }
        public virtual DbSet<Satis_Detaylari> Satis_Detaylaris { get; set; }
        public virtual DbSet<Satislar> Satislars { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tedarikciler> Tedarikcilers { get; set; }
        public virtual DbSet<Urunler> Urunlers { get; set; }
        public virtual DbSet<C1997_Yili_Urun_Satislari> C1997_Yili_Urun_Satislari { get; set; }
        public virtual DbSet<Alfabetik_Sirali_Urunler_Listesi> Alfabetik_Sirali_Urunler_Listesis { get; set; }
        public virtual DbSet<Ayrintili_Satis_Detaylari> Ayrintili_Satis_Detaylaris { get; set; }
        public virtual DbSet<Biten_Urunler_Listesi> Biten_Urunler_Listesis { get; set; }
        public virtual DbSet<Faturalar> Faturalars { get; set; }
        public virtual DbSet<Kategorilere_Gore_1997_Yili_Satislari> Kategorilere_Gore_1997_Yili_Satislari { get; set; }
        public virtual DbSet<Kategorilere_Gore_Satislar> Kategorilere_Gore_Satislars { get; set; }
        public virtual DbSet<Kategorilere_Gore_Urunler> Kategorilere_Gore_Urunlers { get; set; }
        public virtual DbSet<Ortalama_Maliyetin_Uzerindeki_Urunler> Ortalama_Maliyetin_Uzerindeki_Urunlers { get; set; }
        public virtual DbSet<Ozet_Ceyrek_Satislar> Ozet_Ceyrek_Satislars { get; set; }
        public virtual DbSet<Ozet_Yillik_Satislar> Ozet_Yillik_Satislars { get; set; }
        public virtual DbSet<PersonelRapor> PersonelRapors { get; set; }
        public virtual DbSet<Satis_Alt_Toplamlari> Satis_Alt_Toplamlaris { get; set; }
        public virtual DbSet<Satislar_Sorgusu> Satislar_Sorgusus { get; set; }
        public virtual DbSet<Satislarin_Toplam_Miktari> Satislarin_Toplam_Miktaris { get; set; }
        public virtual DbSet<Sehirlere_Gore_Musteri_ve_Tedarikciler> Sehirlere_Gore_Musteri_ve_Tedarikcilers { get; set; }
        public virtual DbSet<UrunRapor> UrunRapors { get; set; }
    
        [DbFunction("NorthwindEntities", "KategoriyeGöreUrunler")]
        public virtual IQueryable<KategoriyeGöreUrunler_Result> KategoriyeGöreUrunler(Nullable<int> kId)
        {
            var kIdParameter = kId.HasValue ?
                new ObjectParameter("kId", kId) :
                new ObjectParameter("kId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<KategoriyeGöreUrunler_Result>("[NorthwindEntities].[KategoriyeGöreUrunler](@kId)", kIdParameter);
        }
    
        public virtual ObjectResult<CustOrderHist_Result> CustOrderHist(string musteriID)
        {
            var musteriIDParameter = musteriID != null ?
                new ObjectParameter("MusteriID", musteriID) :
                new ObjectParameter("MusteriID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CustOrderHist_Result>("CustOrderHist", musteriIDParameter);
        }
    
        public virtual ObjectResult<CustSatislarDetail_Result> CustSatislarDetail(Nullable<int> satisID)
        {
            var satisIDParameter = satisID.HasValue ?
                new ObjectParameter("SatisID", satisID) :
                new ObjectParameter("SatisID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CustSatislarDetail_Result>("CustSatislarDetail", satisIDParameter);
        }
    
        public virtual ObjectResult<CustSatislarSatislar_Result> CustSatislarSatislar(string musteriID)
        {
            var musteriIDParameter = musteriID != null ?
                new ObjectParameter("MusteriID", musteriID) :
                new ObjectParameter("MusteriID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CustSatislarSatislar_Result>("CustSatislarSatislar", musteriIDParameter);
        }
    
        public virtual ObjectResult<Fiyati_En_Yuksek_On_Urun_Result> Fiyati_En_Yuksek_On_Urun()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Fiyati_En_Yuksek_On_Urun_Result>("Fiyati_En_Yuksek_On_Urun");
        }
    
        public virtual int KategoriGuncelle(Nullable<int> id, string adi, string tanimi)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var adiParameter = adi != null ?
                new ObjectParameter("adi", adi) :
                new ObjectParameter("adi", typeof(string));
    
            var tanimiParameter = tanimi != null ?
                new ObjectParameter("tanimi", tanimi) :
                new ObjectParameter("tanimi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("KategoriGuncelle", idParameter, adiParameter, tanimiParameter);
        }
    
        public virtual int KategoriSil(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("KategoriSil", idParameter);
        }
    
        public virtual int prc_Kategoriler_Delete(Nullable<int> kategoriID)
        {
            var kategoriIDParameter = kategoriID.HasValue ?
                new ObjectParameter("KategoriID", kategoriID) :
                new ObjectParameter("KategoriID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("prc_Kategoriler_Delete", kategoriIDParameter);
        }
    
        public virtual int prc_Kategoriler_Insert(Nullable<int> kategoriID, string kategoriAdi, string tanimi, byte[] resim)
        {
            var kategoriIDParameter = kategoriID.HasValue ?
                new ObjectParameter("KategoriID", kategoriID) :
                new ObjectParameter("KategoriID", typeof(int));
    
            var kategoriAdiParameter = kategoriAdi != null ?
                new ObjectParameter("KategoriAdi", kategoriAdi) :
                new ObjectParameter("KategoriAdi", typeof(string));
    
            var tanimiParameter = tanimi != null ?
                new ObjectParameter("Tanimi", tanimi) :
                new ObjectParameter("Tanimi", typeof(string));
    
            var resimParameter = resim != null ?
                new ObjectParameter("Resim", resim) :
                new ObjectParameter("Resim", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("prc_Kategoriler_Insert", kategoriIDParameter, kategoriAdiParameter, tanimiParameter, resimParameter);
        }
    
        public virtual ObjectResult<prc_Kategoriler_Select_Result> prc_Kategoriler_Select()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<prc_Kategoriler_Select_Result>("prc_Kategoriler_Select");
        }
    
        public virtual int prc_Kategoriler_Update(Nullable<int> kategoriID, string kategoriAdi, string tanimi, byte[] resim)
        {
            var kategoriIDParameter = kategoriID.HasValue ?
                new ObjectParameter("KategoriID", kategoriID) :
                new ObjectParameter("KategoriID", typeof(int));
    
            var kategoriAdiParameter = kategoriAdi != null ?
                new ObjectParameter("KategoriAdi", kategoriAdi) :
                new ObjectParameter("KategoriAdi", typeof(string));
    
            var tanimiParameter = tanimi != null ?
                new ObjectParameter("Tanimi", tanimi) :
                new ObjectParameter("Tanimi", typeof(string));
    
            var resimParameter = resim != null ?
                new ObjectParameter("Resim", resim) :
                new ObjectParameter("Resim", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("prc_Kategoriler_Update", kategoriIDParameter, kategoriAdiParameter, tanimiParameter, resimParameter);
        }
    
        public virtual int prc_ResimEkle(Nullable<int> pId, byte[] resim)
        {
            var pIdParameter = pId.HasValue ?
                new ObjectParameter("pId", pId) :
                new ObjectParameter("pId", typeof(int));
    
            var resimParameter = resim != null ?
                new ObjectParameter("resim", resim) :
                new ObjectParameter("resim", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("prc_ResimEkle", pIdParameter, resimParameter);
        }
    
        public virtual int prc_ResimGetir(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("prc_ResimGetir", idParameter);
        }
    
        public virtual ObjectResult<prc_Tedarikciler_Select_Result> prc_Tedarikciler_Select()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<prc_Tedarikciler_Select_Result>("prc_Tedarikciler_Select");
        }
    
        public virtual int prc_Urunler_Delete(Nullable<int> urunID)
        {
            var urunIDParameter = urunID.HasValue ?
                new ObjectParameter("UrunID", urunID) :
                new ObjectParameter("UrunID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("prc_Urunler_Delete", urunIDParameter);
        }
    
        public virtual int prc_Urunler_Insert(Nullable<int> urunID, string urunAdi, Nullable<decimal> birimFiyati, Nullable<short> hedefStokDuzeyi, Nullable<int> kategoriID, Nullable<int> tedarikciID, string birimdekiMiktar, Nullable<short> yeniSatis, Nullable<short> enAzYenidenSatisMikatari, byte[] resim, Nullable<bool> sonlandi)
        {
            var urunIDParameter = urunID.HasValue ?
                new ObjectParameter("UrunID", urunID) :
                new ObjectParameter("UrunID", typeof(int));
    
            var urunAdiParameter = urunAdi != null ?
                new ObjectParameter("UrunAdi", urunAdi) :
                new ObjectParameter("UrunAdi", typeof(string));
    
            var birimFiyatiParameter = birimFiyati.HasValue ?
                new ObjectParameter("BirimFiyati", birimFiyati) :
                new ObjectParameter("BirimFiyati", typeof(decimal));
    
            var hedefStokDuzeyiParameter = hedefStokDuzeyi.HasValue ?
                new ObjectParameter("HedefStokDuzeyi", hedefStokDuzeyi) :
                new ObjectParameter("HedefStokDuzeyi", typeof(short));
    
            var kategoriIDParameter = kategoriID.HasValue ?
                new ObjectParameter("KategoriID", kategoriID) :
                new ObjectParameter("KategoriID", typeof(int));
    
            var tedarikciIDParameter = tedarikciID.HasValue ?
                new ObjectParameter("TedarikciID", tedarikciID) :
                new ObjectParameter("TedarikciID", typeof(int));
    
            var birimdekiMiktarParameter = birimdekiMiktar != null ?
                new ObjectParameter("BirimdekiMiktar", birimdekiMiktar) :
                new ObjectParameter("BirimdekiMiktar", typeof(string));
    
            var yeniSatisParameter = yeniSatis.HasValue ?
                new ObjectParameter("YeniSatis", yeniSatis) :
                new ObjectParameter("YeniSatis", typeof(short));
    
            var enAzYenidenSatisMikatariParameter = enAzYenidenSatisMikatari.HasValue ?
                new ObjectParameter("EnAzYenidenSatisMikatari", enAzYenidenSatisMikatari) :
                new ObjectParameter("EnAzYenidenSatisMikatari", typeof(short));
    
            var resimParameter = resim != null ?
                new ObjectParameter("Resim", resim) :
                new ObjectParameter("Resim", typeof(byte[]));
    
            var sonlandiParameter = sonlandi.HasValue ?
                new ObjectParameter("Sonlandi", sonlandi) :
                new ObjectParameter("Sonlandi", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("prc_Urunler_Insert", urunIDParameter, urunAdiParameter, birimFiyatiParameter, hedefStokDuzeyiParameter, kategoriIDParameter, tedarikciIDParameter, birimdekiMiktarParameter, yeniSatisParameter, enAzYenidenSatisMikatariParameter, resimParameter, sonlandiParameter);
        }
    
        public virtual ObjectResult<prc_Urunler_Select_Result> prc_Urunler_Select()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<prc_Urunler_Select_Result>("prc_Urunler_Select");
        }
    
        public virtual int prc_Urunler_Update(Nullable<int> urunID, string urunAdi, Nullable<decimal> birimFiyati, Nullable<short> hedefStokDuzeyi, Nullable<int> kategoriID, Nullable<int> tedarikciID, string birimdekiMiktar, Nullable<short> yeniSatis, Nullable<short> enAzYenidenSatisMikatari, Nullable<bool> sonlandi)
        {
            var urunIDParameter = urunID.HasValue ?
                new ObjectParameter("UrunID", urunID) :
                new ObjectParameter("UrunID", typeof(int));
    
            var urunAdiParameter = urunAdi != null ?
                new ObjectParameter("UrunAdi", urunAdi) :
                new ObjectParameter("UrunAdi", typeof(string));
    
            var birimFiyatiParameter = birimFiyati.HasValue ?
                new ObjectParameter("BirimFiyati", birimFiyati) :
                new ObjectParameter("BirimFiyati", typeof(decimal));
    
            var hedefStokDuzeyiParameter = hedefStokDuzeyi.HasValue ?
                new ObjectParameter("HedefStokDuzeyi", hedefStokDuzeyi) :
                new ObjectParameter("HedefStokDuzeyi", typeof(short));
    
            var kategoriIDParameter = kategoriID.HasValue ?
                new ObjectParameter("KategoriID", kategoriID) :
                new ObjectParameter("KategoriID", typeof(int));
    
            var tedarikciIDParameter = tedarikciID.HasValue ?
                new ObjectParameter("TedarikciID", tedarikciID) :
                new ObjectParameter("TedarikciID", typeof(int));
    
            var birimdekiMiktarParameter = birimdekiMiktar != null ?
                new ObjectParameter("BirimdekiMiktar", birimdekiMiktar) :
                new ObjectParameter("BirimdekiMiktar", typeof(string));
    
            var yeniSatisParameter = yeniSatis.HasValue ?
                new ObjectParameter("YeniSatis", yeniSatis) :
                new ObjectParameter("YeniSatis", typeof(short));
    
            var enAzYenidenSatisMikatariParameter = enAzYenidenSatisMikatari.HasValue ?
                new ObjectParameter("EnAzYenidenSatisMikatari", enAzYenidenSatisMikatari) :
                new ObjectParameter("EnAzYenidenSatisMikatari", typeof(short));
    
            var sonlandiParameter = sonlandi.HasValue ?
                new ObjectParameter("Sonlandi", sonlandi) :
                new ObjectParameter("Sonlandi", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("prc_Urunler_Update", urunIDParameter, urunAdiParameter, birimFiyatiParameter, hedefStokDuzeyiParameter, kategoriIDParameter, tedarikciIDParameter, birimdekiMiktarParameter, yeniSatisParameter, enAzYenidenSatisMikatariParameter, sonlandiParameter);
        }
    
        public virtual ObjectResult<SalesByKategori_Result> SalesByKategori(string kategoriAdi, string ordYear)
        {
            var kategoriAdiParameter = kategoriAdi != null ?
                new ObjectParameter("KategoriAdi", kategoriAdi) :
                new ObjectParameter("KategoriAdi", typeof(string));
    
            var ordYearParameter = ordYear != null ?
                new ObjectParameter("OrdYear", ordYear) :
                new ObjectParameter("OrdYear", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SalesByKategori_Result>("SalesByKategori", kategoriAdiParameter, ordYearParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int StokArttir(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("StokArttir", idParameter);
        }
    
        public virtual ObjectResult<Ulkelere_Gore_Personel_Satislari_Result> Ulkelere_Gore_Personel_Satislari(Nullable<System.DateTime> beginning_Date, Nullable<System.DateTime> ending_Date)
        {
            var beginning_DateParameter = beginning_Date.HasValue ?
                new ObjectParameter("Beginning_Date", beginning_Date) :
                new ObjectParameter("Beginning_Date", typeof(System.DateTime));
    
            var ending_DateParameter = ending_Date.HasValue ?
                new ObjectParameter("Ending_Date", ending_Date) :
                new ObjectParameter("Ending_Date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Ulkelere_Gore_Personel_Satislari_Result>("Ulkelere_Gore_Personel_Satislari", beginning_DateParameter, ending_DateParameter);
        }
    
        public virtual int UrunSil(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UrunSil", idParameter);
        }
    
        public virtual ObjectResult<Yillik_Satislar_Result> Yillik_Satislar(Nullable<System.DateTime> beginning_Date, Nullable<System.DateTime> ending_Date)
        {
            var beginning_DateParameter = beginning_Date.HasValue ?
                new ObjectParameter("Beginning_Date", beginning_Date) :
                new ObjectParameter("Beginning_Date", typeof(System.DateTime));
    
            var ending_DateParameter = ending_Date.HasValue ?
                new ObjectParameter("Ending_Date", ending_Date) :
                new ObjectParameter("Ending_Date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Yillik_Satislar_Result>("Yillik_Satislar", beginning_DateParameter, ending_DateParameter);
        }
    }
}
