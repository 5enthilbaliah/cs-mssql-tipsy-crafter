namespace AmritaDb.Tipsy.Infrastructure.Specifications.Purchase;

using Domain.Purchase;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class SupplierContactSpecifications : IEntityTypeConfiguration<SupplierContact>
{
    public void Configure(EntityTypeBuilder<SupplierContact> builder)
    {
        builder.ToTable("supplier_contact", "purchase", tableBuilder =>
            {
                tableBuilder.IsTemporal()
                    .UseHistoryTable("supplier_contact_history", "purchase");
                tableBuilder.IsTemporal()
                    .HasPeriodStart("valid_from");
                tableBuilder.IsTemporal()
                    .HasPeriodEnd("valid_to");
            }
        );
        
        builder.HasKey(contact => contact.Id);
        builder.Property(contact => contact.Id)
            .ValueGeneratedNever()
            .HasColumnName("id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
        
        builder.Property(contact => contact.Name)
            .HasColumnName("name")
            .HasColumnType("varchar(40)")
            .HasMaxLength(40);
        
        builder.Property(contact => contact.Detail)
            .HasColumnName("detail")
            .HasColumnType("varchar(200)")
            .HasMaxLength(200);

        builder.Property(contact => contact.IsPrimary)
            .HasColumnName("is_primary")
            .HasColumnType("bit")
            .HasDefaultValue(0);
        
        builder.Property(contact => contact.SupplierId)
            .HasColumnName("supplier_id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
        
        builder.Property(contact => contact.ContactTypeId)
            .HasColumnName("contact_type_id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
        
        builder.Property(contact => contact.ModifiedBy)
            .HasColumnName("modified_by")
            .HasColumnType("varchar(200)")
            .HasMaxLength(200)
            .HasDefaultValue("SYSTEM");
    }
}