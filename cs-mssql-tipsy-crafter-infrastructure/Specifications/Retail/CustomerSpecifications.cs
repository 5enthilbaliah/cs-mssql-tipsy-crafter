namespace AmritaDb.Tipsy.Infrastructure.Specifications.Retail;

using Domain.Retail;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class CustomerSpecifications : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.ToTable("customer", "retail", tableBuilder =>
            {
                tableBuilder.IsTemporal()
                    .UseHistoryTable("customer_history", "retail");
                tableBuilder.IsTemporal()
                    .HasPeriodStart("valid_from");
                tableBuilder.IsTemporal()
                    .HasPeriodEnd("valid_to");
            }
        );
        
        builder.HasKey(customer => customer.Id);
        builder.Property(customer => customer.Id)
            .ValueGeneratedNever()
            .HasColumnName("id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
        
        builder.Property(customer => customer.Name)
            .HasColumnName("name")
            .HasColumnType("varchar(40)")
            .HasMaxLength(40);
        
        builder.Property(customer => customer.Description)
            .HasColumnName("description")
            .HasColumnType("varchar(2000)")
            .HasMaxLength(2000);

        builder.Property(customer => customer.Address1)
            .HasColumnName("address_1")
            .HasColumnType("varchar(120)")
            .HasMaxLength(120);
        
        builder.Property(customer => customer.Address2)
            .HasColumnName("address_2")
            .HasColumnType("varchar(120)")
            .HasMaxLength(120);
        
        builder.Property(customer => customer.City)
            .HasColumnName("city")
            .HasColumnType("varchar(100)")
            .HasMaxLength(100);
        
        builder.Property(customer => customer.State)
            .HasColumnName("state")
            .HasColumnType("char(3)")
            .HasMaxLength(3);
        
        builder.Property(customer => customer.Country)
            .HasColumnName("country")
            .HasColumnType("char(2)")
            .HasMaxLength(2);
        
        builder.Property(customer => customer.ZipCode)
            .HasColumnName("zip_code")
            .HasColumnType("varchar(16)")
            .HasMaxLength(16);

        builder.HasMany(customer => customer.Contacts)
            .WithOne(contact => contact.Customer)
            .HasForeignKey(contact => contact.CustomerId)
            .HasPrincipalKey(customer => customer.Id)
            .OnDelete(DeleteBehavior.Restrict);
    }
}