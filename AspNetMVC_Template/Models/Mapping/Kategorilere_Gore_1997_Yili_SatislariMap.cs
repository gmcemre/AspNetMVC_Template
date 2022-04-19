using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AspNetMVC_Template.Models.Mapping
{
    public class Kategorilere_Gore_1997_Yili_SatislariMap : EntityTypeConfiguration<Kategorilere_Gore_1997_Yili_Satislari>
    {
        public Kategorilere_Gore_1997_Yili_SatislariMap()
        {
            // Primary Key
            this.HasKey(t => t.KategoriAdi);

            // Properties
            this.Property(t => t.KategoriAdi)
                .IsRequired()
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("Kategorilere Gore 1997 Yili Satislari");
            this.Property(t => t.KategoriAdi).HasColumnName("KategoriAdi");
            this.Property(t => t.KategoriSales).HasColumnName("KategoriSales");
        }
    }
}
