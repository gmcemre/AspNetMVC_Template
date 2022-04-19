using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AspNetMVC_Template.Models.Mapping
{
    public class Ayrintili_Satis_DetaylariMap : EntityTypeConfiguration<Ayrintili_Satis_Detaylari>
    {
        public Ayrintili_Satis_DetaylariMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SatisID, t.UrunID, t.UrunAdi, t.BirimFiyati, t.Miktar, t.İndirim });

            // Properties
            this.Property(t => t.SatisID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UrunID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UrunAdi)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.BirimFiyati)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Miktar)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Ayrintili Satis Detaylari");
            this.Property(t => t.SatisID).HasColumnName("SatisID");
            this.Property(t => t.UrunID).HasColumnName("UrunID");
            this.Property(t => t.UrunAdi).HasColumnName("UrunAdi");
            this.Property(t => t.BirimFiyati).HasColumnName("BirimFiyati");
            this.Property(t => t.Miktar).HasColumnName("Miktar");
            this.Property(t => t.İndirim).HasColumnName("İndirim");
            this.Property(t => t.ExtendedPrice).HasColumnName("ExtendedPrice");
        }
    }
}
