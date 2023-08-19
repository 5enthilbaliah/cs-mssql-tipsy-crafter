namespace AmritaDb.Tipsy.Infrastructure.Specifications.Retail;

using Domain.Retail;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ReceiptLineSpecifications : IEntityTypeConfiguration<ReceiptLine>
{
    public void Configure(EntityTypeBuilder<ReceiptLine> builder)
    {
        builder.ToTable("receipt_line", "retail", tableBuilder =>
            {
                tableBuilder.IsTemporal()
                    .UseHistoryTable("receipt_line_history", "retail");
                tableBuilder.IsTemporal()
                    .HasPeriodStart("valid_from");
                tableBuilder.IsTemporal()
                    .HasPeriodEnd("valid_to");
            }
        );
        
        builder.HasKey(receiptLine => receiptLine.Id);
        builder.Property(receiptLine => receiptLine.Id)
            .ValueGeneratedNever()
            .HasColumnName("id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
        
        builder.Property(receiptLine => receiptLine.InventoryId)
            .HasColumnName("inventory_id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
        
        builder.Property(receiptLine => receiptLine.ReceiptId)
            .HasColumnName("receipt_id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
        
        builder.Property(receiptLine => receiptLine.ShipmentId)
            .HasColumnName("shipment_id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
        
        builder.Property(receiptLine => receiptLine.Discount)
            .HasColumnType("money")
            .HasColumnName("discount")
            .HasDefaultValue(0);
        
        builder.Property(receiptLine => receiptLine.Msrp)
            .HasColumnType("money")
            .HasColumnName("msrp")
            .HasDefaultValue(0);
        
        builder.Property(receiptLine => receiptLine.Total)
            .HasColumnType("money")
            .HasColumnName("total")
            .HasDefaultValue(0);
        
        builder.Property(receiptLine => receiptLine.Quantity)
            .HasColumnType("int")
            .HasColumnName("qty")
            .HasDefaultValue(0);
        
        builder.Property(receiptLine => receiptLine.ModifiedBy)
            .HasColumnName("modified_by")
            .HasColumnType("varchar(200)")
            .HasMaxLength(200)
            .HasDefaultValue("SYSTEM");
    }
}