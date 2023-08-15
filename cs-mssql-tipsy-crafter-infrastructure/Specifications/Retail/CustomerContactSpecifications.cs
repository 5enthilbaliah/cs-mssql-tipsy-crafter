namespace AmritaDb.Tipsy.Infrastructure.Specifications.Retail;

using Domain.Retail;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class CustomerContactSpecifications : IEntityTypeConfiguration<CustomerContact>
{
    public void Configure(EntityTypeBuilder<CustomerContact> builder)
    {
        builder.ToTable("customer_contact", "retail", tableBuilder =>
            {
                tableBuilder.IsTemporal()
                    .UseHistoryTable("customer_contact_history", "retail");
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
        
        builder.Property(contact => contact.CustomerId)
            .HasColumnName("customer_id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
        
        builder.Property(contact => contact.ContactTypeId)
            .HasColumnName("contact_type_id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
    }
}