namespace AmritaDb.Tipsy.Infrastructure.Specifications.Retail;

using Domain.Retail;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ReceiptSpecifications : IEntityTypeConfiguration<Receipt>
{
    public void Configure(EntityTypeBuilder<Receipt> builder)
    {
        builder.ToTable("receipt", "retail", tableBuilder =>
            {
                tableBuilder.IsTemporal()
                    .UseHistoryTable("receipt_history", "retail");
                tableBuilder.IsTemporal()
                    .HasPeriodStart("valid_from");
                tableBuilder.IsTemporal()
                    .HasPeriodEnd("valid_to");
            }
        );
        
        builder.HasKey(receipt => receipt.Id);
        builder.Property(receipt => receipt.Id)
            .ValueGeneratedNever()
            .HasColumnName("id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
        
        builder.Property(receipt => receipt.CustomerId)
            .HasColumnName("customer_id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
        
        builder.Property(receipt => receipt.StoreId)
            .HasColumnName("store_id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
        
        builder.Property(receipt => receipt.Date)
            .HasColumnName("date")
            .HasColumnType("datetime2(7)");
        
        builder.Property(receipt => receipt.StatusId)
            .HasColumnName("status_id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
        
        builder.Property(receipt => receipt.SubTotal)
            .HasColumnType("money")
            .HasColumnName("sub_total_amount")
            .HasDefaultValue(0);
        
        builder.Property(receipt => receipt.Tax)
            .HasColumnType("money")
            .HasColumnName("tax_amount")
            .HasDefaultValue(0);
        
        builder.Property(receipt => receipt.Shipping)
            .HasColumnType("money")
            .HasColumnName("shipping_amount")
            .HasDefaultValue(0);
        
        builder.Property(receipt => receipt.Total)
            .HasColumnType("money")
            .HasColumnName("total_amount")
            .HasDefaultValue(0);
        
        builder.Property(receipt => receipt.ItemDiscount)
            .HasColumnType("money")
            .HasColumnName("item_discount_amount")
            .HasDefaultValue(0);
        
        builder.Property(receipt => receipt.Discount)
            .HasColumnType("money")
            .HasColumnName("discount_amount")
            .HasDefaultValue(0);
        
        builder.Property(receipt => receipt.GrandTotal)
            .HasColumnType("money")
            .HasColumnName("grand_total_amount")
            .HasDefaultValue(0);

        builder.Property(receipt => receipt.PromoCode)
            .HasColumnName("promo_code")
            .HasColumnType("varchar(200)")
            .HasMaxLength(200);
        
        builder.Property(receipt => receipt.ModifiedBy)
            .HasColumnName("modified_by")
            .HasColumnType("varchar(200)")
            .HasMaxLength(200)
            .HasDefaultValue("SYSTEM");
        
        builder.HasMany(receipt => receipt.Payments)
            .WithOne(payment => payment.Receipt)
            .HasForeignKey(payment => payment.ReceiptId)
            .HasPrincipalKey(receipt => receipt.Id)
            .OnDelete(DeleteBehavior.Restrict);
    }
}