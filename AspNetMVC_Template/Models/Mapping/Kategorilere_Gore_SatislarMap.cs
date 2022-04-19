using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AspNetMVC_Template.Models.Mapping
{
    public class Kategorilere_Gore_SatislarMap : EntityTypeConfiguration<Kategorilere_Gore_Satislar>
    {
        public Kategorilere_Gore_SatislarMap()
        {
            // Primary Key
            this.HasKey(t => new { t.KategoriID, t.KategoriAdi, t.UrunAdi });

            // Properties
            this.Property(t => t.KategoriID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.KategoriAdi)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.UrunAdi)
                .IsRequired()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("Kategorilere Gore Satislar");
            this.Property(t => t.KategoriID).HasColumnName("KategoriID");
            this.Property(t => t.KategoriAdi).HasColumnName("KategoriAdi");
            this.Property(t => t.UrunAdi).HasColumnName("UrunAdi");
            this.Property(t => t.Urunlerales).HasColumnName("Urunlerales");
        }
    }
}
