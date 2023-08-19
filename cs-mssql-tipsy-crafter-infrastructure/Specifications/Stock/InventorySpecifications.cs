namespace AmritaDb.Tipsy.Infrastructure.Specifications.Stock;

using Domain.Stock;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class InventorySpecifications : IEntityTypeConfiguration<Inventory>
{
    public void Configure(EntityTypeBuilder<Inventory> builder)
    {
        builder.ToTable("inventory", "stock", tableBuilder =>
            {
                tableBuilder.IsTemporal()
                    .UseHistoryTable("inventory_history", "stock");
                tableBuilder.IsTemporal()
                    .HasPeriodStart("valid_from");
                tableBuilder.IsTemporal()
                    .HasPeriodEnd("valid_to");
            }
        );
        
        builder.HasKey(inventory => inventory.Id);
        builder.Property(inventory => inventory.Id)
            .ValueGeneratedNever()
            .HasColumnName("id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
        
        builder.Property(inventory => inventory.ProductId)
            .HasColumnName("product_id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
        
        builder.Property(inventory => inventory.StoreId)
            .HasColumnName("store_id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
        
        builder.Property(order => order.Msrp)
            .HasColumnType("money")
            .HasColumnName("msrp")
            .HasDefaultValue(0);
        
        builder.Property(order => order.Price)
            .HasColumnType("money")
            .HasColumnName("price")
            .HasDefaultValue(0);
        
        builder.Property(order => order.Discount)
            .HasColumnType("money")
            .HasColumnName("discount")
            .HasDefaultValue(0);
        
        builder.Property(order => order.QuantityAvailable)
            .HasColumnType("int")
            .HasColumnName("qty_available")
            .HasDefaultValue(0);
        
        builder.Property(order => order.MinimumStockLevel)
            .HasColumnType("int")
            .HasColumnName("min_stock_level")
            .HasDefaultValue(0);
        
        builder.Property(order => order.MaximumStockLevel)
            .HasColumnType("int")
            .HasColumnName("max_stock_level")
            .HasDefaultValue(0);
        
        builder.Property(order => order.ReorderPoint)
            .HasColumnType("int")
            .HasColumnName("reorder_point")
            .HasDefaultValue(0);
        
        builder.Property(order => order.QuantityOnDisplay)
            .HasColumnType("int")
            .HasColumnName("qty_on_display")
            .HasDefaultValue(0);
        
        builder.Property(inventory => inventory.AisleLocation)
            .HasColumnName("aisle_location")
            .HasColumnType("varchar(50)")
            .HasMaxLength(50);

        builder.Property(inventory => inventory.LatestRestockDate)
            .HasColumnName("latest_restock_date")
            .HasColumnType("datetime2(7)");
        
        builder.Property(inventory => inventory.ModifiedBy)
            .HasColumnName("modified_by")
            .HasColumnType("varchar(200)")
            .HasMaxLength(200)
            .HasDefaultValue("SYSTEM");
        
        builder.HasMany(inventory => inventory.ReceiptLines)
            .WithOne(receiptLine => receiptLine.Inventory)
            .HasForeignKey(receiptLine => receiptLine.InventoryId)
            .HasPrincipalKey(inventory => inventory.Id)
            .OnDelete(DeleteBehavior.Restrict);
    }
}