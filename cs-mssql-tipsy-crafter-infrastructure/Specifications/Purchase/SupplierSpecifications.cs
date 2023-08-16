namespace AmritaDb.Tipsy.Infrastructure.Specifications.Purchase;

using Domain.Purchase;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class SupplierSpecifications : IEntityTypeConfiguration<Supplier>
{
    public void Configure(EntityTypeBuilder<Supplier> builder)
    {
        builder.ToTable("supplier", "purchase", tableBuilder =>
            {
                tableBuilder.IsTemporal()
                    .UseHistoryTable("supplier_history", "purchase");
                tableBuilder.IsTemporal()
                    .HasPeriodStart("valid_from");
                tableBuilder.IsTemporal()
                    .HasPeriodEnd("valid_to");
            }
        );
        
        builder.HasKey(supplier => supplier.Id);
        builder.Property(supplier => supplier.Id)
            .ValueGeneratedNever()
            .HasColumnName("id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
        
        builder.Property(supplier => supplier.Name)
            .HasColumnName("name")
            .HasColumnType("varchar(40)")
            .HasMaxLength(40);
        
        builder.Property(supplier => supplier.Description)
            .HasColumnName("description")
            .HasColumnType("varchar(2000)")
            .HasMaxLength(2000);
        
        builder.Property(supplier => supplier.WebsiteUrl)
            .HasColumnName("website_url")
            .HasColumnType("varchar(512)")
            .HasMaxLength(512);
        
        builder.Property(supplier => supplier.Address1)
            .HasColumnName("address_1")
            .HasColumnType("varchar(120)")
            .HasMaxLength(120);
        
        builder.Property(supplier => supplier.Address2)
            .HasColumnName("address_2")
            .HasColumnType("varchar(120)")
            .HasMaxLength(120);
        
        builder.Property(supplier => supplier.City)
            .HasColumnName("city")
            .HasColumnType("varchar(100)")
            .HasMaxLength(100);
        
        builder.Property(supplier => supplier.State)
            .HasColumnName("state")
            .HasColumnType("char(3)")
            .HasMaxLength(3);
        
        builder.Property(supplier => supplier.Country)
            .HasColumnName("country")
            .HasColumnType("char(2)")
            .HasMaxLength(2);
        
        builder.Property(supplier => supplier.ZipCode)
            .HasColumnName("zip_code")
            .HasColumnType("varchar(16)")
            .HasMaxLength(16);

        builder.Property(supplier => supplier.Latitude)
            .HasColumnName("latitude")
            .HasColumnType("decimal(8,6)");
        
        builder.Property(supplier => supplier.Longitude)
            .HasColumnName("longitude")
            .HasColumnType("decimal(9,6)");
        
        builder.Property(supplier => supplier.PreferredCurrency)
            .HasColumnName("preferred_currency")
            .HasColumnType("char(3)")
            .HasMaxLength(3)
            .HasDefaultValue("USD");
        
        builder.HasMany(supplier => supplier.Contacts)
            .WithOne(contact => contact.Supplier)
            .HasForeignKey(contact => contact.SupplierId)
            .HasPrincipalKey(supplier => supplier.Id)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasMany(supplier => supplier.Orders)
            .WithOne(order => order.Supplier)
            .HasForeignKey(order => order.SupplierId)
            .HasPrincipalKey(supplier => supplier.Id)
            .OnDelete(DeleteBehavior.Restrict);
    }
}