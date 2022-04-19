using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AspNetMVC_Template.Models.Mapping
{
    public class C1997_Yili_Urun_SatislariMap : EntityTypeConfiguration<C1997_Yili_Urun_Satislari>
    {
        public C1997_Yili_Urun_SatislariMap()
        {
            // Primary Key
            this.HasKey(t => new { t.KategoriAdi, t.UrunAdi });

            // Properties
            this.Property(t => t.KategoriAdi)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.UrunAdi)
                .IsRequired()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("1997 Yili Urun Satislari");
            this.Property(t => t.KategoriAdi).HasColumnName("KategoriAdi");
            this.Property(t => t.UrunAdi).HasColumnName("UrunAdi");
            this.Property(t => t.Urunlerales).HasColumnName("Urunlerales");
        }
    }
}
