using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AspNetMVC_Template.Models.Mapping
{
    public class NakliyecilerMap : EntityTypeConfiguration<Nakliyeciler>
    {
        public NakliyecilerMap()
        {
            // Primary Key
            this.HasKey(t => t.NakliyeciID);

            // Properties
            this.Property(t => t.SirketAdi)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.Telefon)
                .HasMaxLength(24);

            // Table & Column Mappings
            this.ToTable("Nakliyeciler");
            this.Property(t => t.NakliyeciID).HasColumnName("NakliyeciID");
            this.Property(t => t.SirketAdi).HasColumnName("SirketAdi");
            this.Property(t => t.Telefon).HasColumnName("Telefon");
        }
    }
}
