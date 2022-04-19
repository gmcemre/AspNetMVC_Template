using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AspNetMVC_Template.Models.Mapping
{
    public class Satis_DetaylariMap : EntityTypeConfiguration<Satis_Detaylari>
    {
        public Satis_DetaylariMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SatisID, t.UrunID });

            // Properties
            this.Property(t => t.SatisID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UrunID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Satis Detaylari");
            this.Property(t => t.SatisID).HasColumnName("SatisID");
            this.Property(t => t.UrunID).HasColumnName("UrunID");
            this.Property(t => t.BirimFiyati).HasColumnName("BirimFiyati");
            this.Property(t => t.Miktar).HasColumnName("Miktar");
            this.Property(t => t.İndirim).HasColumnName("İndirim");

            // Relationships
            this.HasRequired(t => t.Satislar)
                .WithMany(t => t.Satis_Detaylari)
                .HasForeignKey(d => d.SatisID);
            this.HasRequired(t => t.Urunler)
                .WithMany(t => t.Satis_Detaylari)
                .HasForeignKey(d => d.UrunID);

        }
    }
}
