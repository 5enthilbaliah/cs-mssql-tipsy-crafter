namespace AmritaDb.Tipsy.Infrastructure.Specifications.Universal;

using Domain.Universal;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ContactTypeSpecifications : IEntityTypeConfiguration<ContactType>
{
    public void Configure(EntityTypeBuilder<ContactType> builder)
    {
        builder.ToTable("contact_type", "universal", tableBuilder =>
            {
                tableBuilder.IsTemporal()
                    .UseHistoryTable("contact_type_history", "universal");
                tableBuilder.IsTemporal()
                    .HasPeriodStart("valid_from");
                tableBuilder.IsTemporal()
                    .HasPeriodEnd("valid_to");
            }
        );

        builder.HasKey(contactType => contactType.Id);
        builder.Property(contactType => contactType.Id)
            .ValueGeneratedNever()
            .HasColumnName("id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);

        builder.Property(contactType => contactType.Name)
            .HasColumnName("name")
            .HasColumnType("varchar(40)")
            .HasMaxLength(40);

        builder.Property(contactType => contactType.Description)
            .HasColumnName("description")
            .HasColumnType("varchar(200)")
            .HasMaxLength(200);
        
        builder.HasMany(contactType => contactType.StoreContacts)
            .WithOne(contact => contact.ContactType)
            .HasForeignKey(contact => contact.ContactTypeId)
            .HasPrincipalKey(contactType => contactType.Id)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasMany(contactType => contactType.SupplierContacts)
            .WithOne(contact => contact.ContactType)
            .HasForeignKey(contact => contact.ContactTypeId)
            .HasPrincipalKey(contactType => contactType.Id)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasData(
            new ContactType { Id = "01H7PBQ3MBB6ZX1Y39TV6KPM5T", Name = "Phone", Description = "Phone Number" },
            new ContactType { Id = "01H7PBQ3MQ33DF64P8FDZJ6CCG", Name = "Email", Description = "Email Address" },
            new ContactType { Id = "01H7PBQ3MQRT5Q538QR2VCQZZT", Name = "Fax", Description = "Fax Number" });
    }
}