namespace AmritaDb.Tipsy.Infrastructure.Specifications.Retail;

using Domain.Retail;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class StoreSpecifications : IEntityTypeConfiguration<Store>
{
    public void Configure(EntityTypeBuilder<Store> builder)
    {
        builder.ToTable("store", "retail", tableBuilder =>
            {
                tableBuilder.IsTemporal()
                    .UseHistoryTable("store_history", "retail");
                tableBuilder.IsTemporal()
                    .HasPeriodStart("valid_from");
                tableBuilder.IsTemporal()
                    .HasPeriodEnd("valid_to");
            }
        );
        
        builder.HasKey(store => store.Id);
        builder.Property(store => store.Id)
            .ValueGeneratedNever()
            .HasColumnName("id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
        
        builder.Property(store => store.Name)
            .HasColumnName("name")
            .HasColumnType("varchar(40)")
            .HasMaxLength(40);
        
        builder.Property(store => store.Description)
            .HasColumnName("description")
            .HasColumnType("varchar(2000)")
            .HasMaxLength(2000);
        
        builder.Property(store => store.WebsiteUrl)
            .HasColumnName("website_url")
            .HasColumnType("varchar(512)")
            .HasMaxLength(512);
        
        builder.Property(store => store.Address1)
            .HasColumnName("address_1")
            .HasColumnType("varchar(120)")
            .HasMaxLength(120);
        
        builder.Property(store => store.Address2)
            .HasColumnName("address_2")
            .HasColumnType("varchar(120)")
            .HasMaxLength(120);
        
        builder.Property(store => store.City)
            .HasColumnName("city")
            .HasColumnType("varchar(100)")
            .HasMaxLength(100);
        
        builder.Property(store => store.State)
            .HasColumnName("state")
            .HasColumnType("char(3)")
            .HasMaxLength(3);
        
        builder.Property(store => store.Country)
            .HasColumnName("country")
            .HasColumnType("char(2)")
            .HasMaxLength(2);
        
        builder.Property(store => store.ZipCode)
            .HasColumnName("zip_code")
            .HasColumnType("varchar(16)")
            .HasMaxLength(16);
        
        builder.Property(store => store.IsWarehouse)
            .HasColumnName("is_warehouse")
            .HasColumnType("bit")
            .HasDefaultValue(0);
        
        builder.Property(store => store.Latitude)
            .HasColumnName("latitude")
            .HasColumnType("decimal(8,6)");
        
        builder.Property(store => store.Longitude)
            .HasColumnName("longitude")
            .HasColumnType("decimal(9,6)");
        
        builder.Property(store => store.PreferredCurrency)
            .HasColumnName("preferred_currency")
            .HasColumnType("char(3)")
            .HasMaxLength(3)
            .HasDefaultValue("USD");
        
        builder.HasMany(store => store.Contacts)
            .WithOne(contact => contact.Store)
            .HasForeignKey(contact => contact.StoreId)
            .HasPrincipalKey(store => store.Id)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasMany(store => store.Orders)
            .WithOne(order => order.Store)
            .HasForeignKey(order => order.StoreId)
            .HasPrincipalKey(store => store.Id)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasMany(store => store.Inventories)
            .WithOne(inventory => inventory.Store)
            .HasForeignKey(inventory => inventory.StoreId)
            .HasPrincipalKey(store => store.Id)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasMany(store => store.Receipts)
            .WithOne(receipt => receipt.Store)
            .HasForeignKey(receipt => receipt.StoreId)
            .HasPrincipalKey(store => store.Id)
            .OnDelete(DeleteBehavior.Restrict);
    }
}