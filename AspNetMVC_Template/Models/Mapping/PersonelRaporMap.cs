using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AspNetMVC_Template.Models.Mapping
{
    public class PersonelRaporMap : EntityTypeConfiguration<PersonelRapor>
    {
        public PersonelRaporMap()
        {
            // Primary Key
            this.HasKey(t => t.UrunAdi);

            // Properties
            this.Property(t => t.Adi)
                .HasMaxLength(10);

            this.Property(t => t.UrunAdi)
                .IsRequired()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("PersonelRapor");
            this.Property(t => t.Adi).HasColumnName("Adi");
            this.Property(t => t.UrunAdi).HasColumnName("UrunAdi");
            this.Property(t => t.ToplamTutar).HasColumnName("ToplamTutar");
        }
    }
}
