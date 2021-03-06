using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AspNetMVC_Template.Models.Mapping
{
    public class KategorilerMap : EntityTypeConfiguration<Kategoriler>
    {
        public KategorilerMap()
        {
            // Primary Key
            this.HasKey(t => t.KategoriID);

            // Properties
            this.Property(t => t.KategoriAdi)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.Tanimi)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Kategoriler");
            this.Property(t => t.KategoriID).HasColumnName("KategoriID");
            this.Property(t => t.KategoriAdi).HasColumnName("KategoriAdi");
            this.Property(t => t.Tanimi).HasColumnName("Tanimi");
            this.Property(t => t.Resim).HasColumnName("Resim");
        }
    }
}
