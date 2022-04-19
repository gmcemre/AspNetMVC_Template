using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AspNetMVC_Template.Models.Mapping
{
    public class Satis_Alt_ToplamlariMap : EntityTypeConfiguration<Satis_Alt_Toplamlari>
    {
        public Satis_Alt_ToplamlariMap()
        {
            // Primary Key
            this.HasKey(t => t.SatisID);

            // Properties
            this.Property(t => t.SatisID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Satis Alt Toplamlari");
            this.Property(t => t.SatisID).HasColumnName("SatisID");
            this.Property(t => t.Subtotal).HasColumnName("Subtotal");
        }
    }
}
