namespace AmritaDb.Tipsy.Infrastructure.Specifications.Purchase;

using Domain.Purchase;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class OrderSpecifications : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.ToTable("order", "purchase", tableBuilder =>
            {
                tableBuilder.IsTemporal()
                    .UseHistoryTable("order_history", "purchase");
                tableBuilder.IsTemporal()
                    .HasPeriodStart("valid_from");
                tableBuilder.IsTemporal()
                    .HasPeriodEnd("valid_to");
            }
        );
        
        builder.HasKey(order => order.Id);
        builder.Property(order => order.Id)
            .ValueGeneratedNever()
            .HasColumnName("id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
        
        builder.Property(order => order.ExternalId)
            .HasColumnName("external_id")
            .HasColumnType("nvarchar(500)")
            .HasMaxLength(500);
        
        builder.Property(order => order.SupplierId)
            .HasColumnName("supplier_id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
        
        builder.Property(order => order.StoreId)
            .HasColumnName("store_id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);

        builder.Property(order => order.Date)
            .HasColumnName("date")
            .HasColumnType("datetime2(7)");
        
        builder.Property(order => order.StatusId)
            .HasColumnName("status_id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);

        builder.Property(order => order.SubTotalCurrency)
            .HasColumnType("char(3)")
            .HasColumnName("sub_total_currency")
            .HasMaxLength(3)
            .HasDefaultValue("USD");

        builder.Property(order => order.SubTotal)
            .HasColumnType("money")
            .HasColumnName("sub_total_amount")
            .HasDefaultValue(0);
        
        builder.Property(order => order.ItemDiscountCurrency)
            .HasColumnType("char(3)")
            .HasColumnName("item_discount_currency")
            .HasMaxLength(3)
            .HasDefaultValue("USD");
            
        builder.Property(order => order.ItemDiscount)
            .HasColumnType("money")
            .HasColumnName("item_discount_amount")
            .HasDefaultValue(0);
        
        builder.Property(order => order.TaxCurrency)
            .HasColumnType("char(3)")
            .HasColumnName("tax_currency")
            .HasMaxLength(3)
            .HasDefaultValue("USD");
            
        builder.Property(order => order.Tax)
            .HasColumnType("money")
            .HasColumnName("tax_amount")
            .HasDefaultValue(0);
        
        builder.Property(order => order.ShippingCurrency)
            .HasColumnType("char(3)")
            .HasColumnName("shipping_currency")
            .HasMaxLength(3)
            .HasDefaultValue("USD");
            
        builder.Property(order => order.Shipping)
            .HasColumnType("money")
            .HasColumnName("shipping_amount")
            .HasDefaultValue(0);
        
        builder.Property(order => order.TotalCurrency)
            .HasColumnType("char(3)")
            .HasColumnName("total_currency")
            .HasMaxLength(3)
            .HasDefaultValue("USD");
            
        builder.Property(order => order.Total)
            .HasColumnType("money")
            .HasColumnName("total_amount")
            .HasDefaultValue(0);
        
        builder.Property(order => order.DiscountCurrency)
            .HasColumnType("char(3)")
            .HasColumnName("discount_currency")
            .HasMaxLength(3)
            .HasDefaultValue("USD");
            
        builder.Property(order => order.Discount)
            .HasColumnType("money")
            .HasColumnName("discount_amount")
            .HasDefaultValue(0);
        
        builder.Property(order => order.GrandTotalCurrency)
            .HasColumnType("char(3)")
            .HasColumnName("grand_total_currency")
            .HasMaxLength(3)
            .HasDefaultValue("USD");
            
        builder.Property(order => order.GrandTotal)
            .HasColumnType("money")
            .HasColumnName("grand_total_amount")
            .HasDefaultValue(0);
        
        builder.Property(order => order.StoreGrandTotal)
            .HasColumnType("money")
            .HasColumnName("store_grand_total_amount")
            .HasDefaultValue(0);
        
        builder.Property(order => order.ExpectedDate)
            .HasColumnName("expected_date")
            .HasColumnType("datetime2(7)");
        
        builder.Property(order => order.PromoCode)
            .HasColumnName("promo_code")
            .HasColumnType("varchar(200)")
            .HasMaxLength(200);
        
        builder.Property(order => order.ModifiedBy)
            .HasColumnName("modified_by")
            .HasColumnType("varchar(200)")
            .HasMaxLength(200)
            .HasDefaultValue("SYSTEM");
    }
}