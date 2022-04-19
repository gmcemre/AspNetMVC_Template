using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using AspNetMVC_Template.Models.Mapping;

namespace AspNetMVC_Template.Models
{
    public partial class NorthwindContext : DbContext
    {
        static NorthwindContext()
        {
            Database.SetInitializer<NorthwindContext>(null);
        }

        public NorthwindContext()
            : base("Name=NorthwindContext")
        {
        }

        public DbSet<aspnet_Applications> aspnet_Applications { get; set; }
        public DbSet<aspnet_Membership> aspnet_Membership { get; set; }
        public DbSet<aspnet_Paths> aspnet_Paths { get; set; }
        public DbSet<aspnet_PersonalizationAllUsers> aspnet_PersonalizationAllUsers { get; set; }
        public DbSet<aspnet_PersonalizationPerUser> aspnet_PersonalizationPerUser { get; set; }
        public DbSet<aspnet_Profile> aspnet_Profile { get; set; }
        public DbSet<aspnet_Roles> aspnet_Roles { get; set; }
        public DbSet<aspnet_SchemaVersions> aspnet_SchemaVersions { get; set; }
        public DbSet<aspnet_Users> aspnet_Users { get; set; }
        public DbSet<aspnet_WebEvent_Events> aspnet_WebEvent_Events { get; set; }
        public DbSet<Bolge> Bolges { get; set; }
        public DbSet<Bolgeler> Bolgelers { get; set; }
        public DbSet<Kategoriler> Kategorilers { get; set; }
        public DbSet<Kisiler> Kisilers { get; set; }
        public DbSet<MusteriDemographic> MusteriDemographics { get; set; }
        public DbSet<Musteriler> Musterilers { get; set; }
        public DbSet<Nakliyeciler> Nakliyecilers { get; set; }
        public DbSet<Personeller> Personellers { get; set; }
        public DbSet<Satis_Detaylari> Satis_Detaylaris { get; set; }
        public DbSet<Satislar> Satislars { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Tedarikciler> Tedarikcilers { get; set; }
        public DbSet<Urunler> Urunlers { get; set; }
        public DbSet<C1997_Yili_Urun_Satislari> C1997_Yili_Urun_Satislari { get; set; }
        public DbSet<Alfabetik_Sirali_Urunler_Listesi> Alfabetik_Sirali_Urunler_Listesis { get; set; }
        public DbSet<Ayrintili_Satis_Detaylari> Ayrintili_Satis_Detaylaris { get; set; }
        public DbSet<Biten_Urunler_Listesi> Biten_Urunler_Listesis { get; set; }
        public DbSet<Faturalar> Faturalars { get; set; }
        public DbSet<Kategorilere_Gore_1997_Yili_Satislari> Kategorilere_Gore_1997_Yili_Satislari { get; set; }
        public DbSet<Kategorilere_Gore_Satislar> Kategorilere_Gore_Satislars { get; set; }
        public DbSet<Kategorilere_Gore_Urunler> Kategorilere_Gore_Urunlers { get; set; }
        public DbSet<Ortalama_Maliyetin_Uzerindeki_Urunler> Ortalama_Maliyetin_Uzerindeki_Urunlers { get; set; }
        public DbSet<Ozet_Ceyrek_Satislar> Ozet_Ceyrek_Satislars { get; set; }
        public DbSet<Ozet_Yillik_Satislar> Ozet_Yillik_Satislars { get; set; }
        public DbSet<PersonelRapor> PersonelRapors { get; set; }
        public DbSet<Satis_Alt_Toplamlari> Satis_Alt_Toplamlaris { get; set; }
        public DbSet<Satislar_Sorgusu> Satislar_Sorgusus { get; set; }
        public DbSet<Satislarin_Toplam_Miktari> Satislarin_Toplam_Miktaris { get; set; }
        public DbSet<Sehirlere_Gore_Musteri_ve_Tedarikciler> Sehirlere_Gore_Musteri_ve_Tedarikcilers { get; set; }
        public DbSet<UrunRapor> UrunRapors { get; set; }
        public DbSet<vw_aspnet_Applications> vw_aspnet_Applications { get; set; }
        public DbSet<vw_aspnet_MembershipUsers> vw_aspnet_MembershipUsers { get; set; }
        public DbSet<vw_aspnet_Profiles> vw_aspnet_Profiles { get; set; }
        public DbSet<vw_aspnet_Roles> vw_aspnet_Roles { get; set; }
        public DbSet<vw_aspnet_Users> vw_aspnet_Users { get; set; }
        public DbSet<vw_aspnet_UsersInRoles> vw_aspnet_UsersInRoles { get; set; }
        public DbSet<vw_aspnet_WebPartState_Paths> vw_aspnet_WebPartState_Paths { get; set; }
        public DbSet<vw_aspnet_WebPartState_Shared> vw_aspnet_WebPartState_Shared { get; set; }
        public DbSet<vw_aspnet_WebPartState_User> vw_aspnet_WebPartState_User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new aspnet_ApplicationsMap());
            modelBuilder.Configurations.Add(new aspnet_MembershipMap());
            modelBuilder.Configurations.Add(new aspnet_PathsMap());
            modelBuilder.Configurations.Add(new aspnet_PersonalizationAllUsersMap());
            modelBuilder.Configurations.Add(new aspnet_PersonalizationPerUserMap());
            modelBuilder.Configurations.Add(new aspnet_ProfileMap());
            modelBuilder.Configurations.Add(new aspnet_RolesMap());
            modelBuilder.Configurations.Add(new aspnet_SchemaVersionsMap());
            modelBuilder.Configurations.Add(new aspnet_UsersMap());
            modelBuilder.Configurations.Add(new aspnet_WebEvent_EventsMap());
            modelBuilder.Configurations.Add(new BolgeMap());
            modelBuilder.Configurations.Add(new BolgelerMap());
            modelBuilder.Configurations.Add(new KategorilerMap());
            modelBuilder.Configurations.Add(new KisilerMap());
            modelBuilder.Configurations.Add(new MusteriDemographicMap());
            modelBuilder.Configurations.Add(new MusterilerMap());
            modelBuilder.Configurations.Add(new NakliyecilerMap());
            modelBuilder.Configurations.Add(new PersonellerMap());
            modelBuilder.Configurations.Add(new Satis_DetaylariMap());
            modelBuilder.Configurations.Add(new SatislarMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new TedarikcilerMap());
            modelBuilder.Configurations.Add(new UrunlerMap());
            modelBuilder.Configurations.Add(new C1997_Yili_Urun_SatislariMap());
            modelBuilder.Configurations.Add(new Alfabetik_Sirali_Urunler_ListesiMap());
            modelBuilder.Configurations.Add(new Ayrintili_Satis_DetaylariMap());
            modelBuilder.Configurations.Add(new Biten_Urunler_ListesiMap());
            modelBuilder.Configurations.Add(new FaturalarMap());
            modelBuilder.Configurations.Add(new Kategorilere_Gore_1997_Yili_SatislariMap());
            modelBuilder.Configurations.Add(new Kategorilere_Gore_SatislarMap());
            modelBuilder.Configurations.Add(new Kategorilere_Gore_UrunlerMap());
            modelBuilder.Configurations.Add(new Ortalama_Maliyetin_Uzerindeki_UrunlerMap());
            modelBuilder.Configurations.Add(new Ozet_Ceyrek_SatislarMap());
            modelBuilder.Configurations.Add(new Ozet_Yillik_SatislarMap());
            modelBuilder.Configurations.Add(new PersonelRaporMap());
            modelBuilder.Configurations.Add(new Satis_Alt_ToplamlariMap());
            modelBuilder.Configurations.Add(new Satislar_SorgusuMap());
            modelBuilder.Configurations.Add(new Satislarin_Toplam_MiktariMap());
            modelBuilder.Configurations.Add(new Sehirlere_Gore_Musteri_ve_TedarikcilerMap());
            modelBuilder.Configurations.Add(new UrunRaporMap());
            modelBuilder.Configurations.Add(new vw_aspnet_ApplicationsMap());
            modelBuilder.Configurations.Add(new vw_aspnet_MembershipUsersMap());
            modelBuilder.Configurations.Add(new vw_aspnet_ProfilesMap());
            modelBuilder.Configurations.Add(new vw_aspnet_RolesMap());
            modelBuilder.Configurations.Add(new vw_aspnet_UsersMap());
            modelBuilder.Configurations.Add(new vw_aspnet_UsersInRolesMap());
            modelBuilder.Configurations.Add(new vw_aspnet_WebPartState_PathsMap());
            modelBuilder.Configurations.Add(new vw_aspnet_WebPartState_SharedMap());
            modelBuilder.Configurations.Add(new vw_aspnet_WebPartState_UserMap());
        }
    }
}
