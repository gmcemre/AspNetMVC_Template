using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AspNetMVC_Template.Models.Mapping
{
    public class FaturalarMap : EntityTypeConfiguration<Faturalar>
    {
        public FaturalarMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MusteriName, t.PersonelSatislari, t.SatisID, t.NakliyeciName, t.UrunID, t.UrunAdi, t.BirimFiyati, t.Miktar, t.İndirim });

            // Properties
            this.Property(t => t.SevkAdi)
                .HasMaxLength(40);

            this.Property(t => t.SevkAdresi)
                .HasMaxLength(60);

            this.Property(t => t.SevkSehri)
                .HasMaxLength(15);

            this.Property(t => t.SevkBolgesi)
                .HasMaxLength(15);

            this.Property(t => t.SevkPostaKodu)
                .HasMaxLength(10);

            this.Property(t => t.SevkUlkesi)
                .HasMaxLength(15);

            this.Property(t => t.MusteriID)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.MusteriName)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.Adres)
                .HasMaxLength(60);

            this.Property(t => t.Sehir)
                .HasMaxLength(15);

            this.Property(t => t.Bolge)
                .HasMaxLength(15);

            this.Property(t => t.PostaKodu)
                .HasMaxLength(10);

            this.Property(t => t.Ulke)
                .HasMaxLength(15);

            this.Property(t => t.PersonelSatislari)
                .IsRequired()
                .HasMaxLength(31);

            this.Property(t => t.SatisID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NakliyeciName)
                .IsRequired()
                .HasMaxLength(40);

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
            this.ToTable("Faturalar");
            this.Property(t => t.SevkAdi).HasColumnName("SevkAdi");
            this.Property(t => t.SevkAdresi).HasColumnName("SevkAdresi");
            this.Property(t => t.SevkSehri).HasColumnName("SevkSehri");
            this.Property(t => t.SevkBolgesi).HasColumnName("SevkBolgesi");
            this.Property(t => t.SevkPostaKodu).HasColumnName("SevkPostaKodu");
            this.Property(t => t.SevkUlkesi).HasColumnName("SevkUlkesi");
            this.Property(t => t.MusteriID).HasColumnName("MusteriID");
            this.Property(t => t.MusteriName).HasColumnName("MusteriName");
            this.Property(t => t.Adres).HasColumnName("Adres");
            this.Property(t => t.Sehir).HasColumnName("Sehir");
            this.Property(t => t.Bolge).HasColumnName("Bolge");
            this.Property(t => t.PostaKodu).HasColumnName("PostaKodu");
            this.Property(t => t.Ulke).HasColumnName("Ulke");
            this.Property(t => t.PersonelSatislari).HasColumnName("PersonelSatislari");
            this.Property(t => t.SatisID).HasColumnName("SatisID");
            this.Property(t => t.SatisTarihi).HasColumnName("SatisTarihi");
            this.Property(t => t.OdemeTarihi).HasColumnName("OdemeTarihi");
            this.Property(t => t.SevkTarihi).HasColumnName("SevkTarihi");
            this.Property(t => t.NakliyeciName).HasColumnName("NakliyeciName");
            this.Property(t => t.UrunID).HasColumnName("UrunID");
            this.Property(t => t.UrunAdi).HasColumnName("UrunAdi");
            this.Property(t => t.BirimFiyati).HasColumnName("BirimFiyati");
            this.Property(t => t.Miktar).HasColumnName("Miktar");
            this.Property(t => t.İndirim).HasColumnName("İndirim");
            this.Property(t => t.ExtendedPrice).HasColumnName("ExtendedPrice");
            this.Property(t => t.NakliyeUcreti).HasColumnName("NakliyeUcreti");
        }
    }
}
