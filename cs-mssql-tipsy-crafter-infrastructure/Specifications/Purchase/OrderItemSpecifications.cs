namespace AmritaDb.Tipsy.Infrastructure.Specifications.Purchase;

using Domain.Purchase;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class OrderItemSpecifications : IEntityTypeConfiguration<OrderItem>
{
    public void Configure(EntityTypeBuilder<OrderItem> builder)
    {
        builder.ToTable("order_item", "purchase", tableBuilder =>
            {
                tableBuilder.IsTemporal()
                    .UseHistoryTable("order_item_history", "purchase");
                tableBuilder.IsTemporal()
                    .HasPeriodStart("valid_from");
                tableBuilder.IsTemporal()
                    .HasPeriodEnd("valid_to");
            }
        );
        
        builder.HasKey(orderItem => orderItem.Id);
        builder.Property(orderItem => orderItem.Id)
            .ValueGeneratedNever()
            .HasColumnName("id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
        
        builder.Property(orderItem => orderItem.OrderId)
            .HasColumnName("order_id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
        
        builder.Property(orderItem => orderItem.ProductId)
            .HasColumnName("product_id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
        
        builder.Property(orderItem => orderItem.DeliveryId)
            .HasColumnName("delivery_id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);

        builder.Property(orderItem => orderItem.NoOfUnits)
            .HasColumnName("no_of_units")
            .HasColumnType("int");
        
        builder.Property(orderItem => orderItem.DiscountCurrency)
            .HasColumnType("char(3)")
            .HasColumnName("discount_currency")
            .HasMaxLength(3)
            .HasDefaultValue("USD");
            
        builder.Property(orderItem => orderItem.Discount)
            .HasColumnType("money")
            .HasColumnName("discount_amount")
            .HasDefaultValue(0);
        
        builder.Property(orderItem => orderItem.CostCurrency)
            .HasColumnType("char(3)")
            .HasColumnName("cost_currency")
            .HasMaxLength(3)
            .HasDefaultValue("USD");
            
        builder.Property(orderItem => orderItem.Cost)
            .HasColumnType("money")
            .HasColumnName("cost_amount")
            .HasDefaultValue(0);
        
        builder.Property(orderItem => orderItem.TotalCurrency)
            .HasColumnType("char(3)")
            .HasColumnName("total_currency")
            .HasMaxLength(3)
            .HasDefaultValue("USD");
        
        builder.Property(orderItem => orderItem.StoreTotal)
            .HasColumnType("money")
            .HasColumnName("store_total_amount")
            .HasDefaultValue(0);
            
        builder.Property(orderItem => orderItem.Total)
            .HasColumnType("money")
            .HasColumnName("total_amount")
            .HasDefaultValue(0);
    }
}