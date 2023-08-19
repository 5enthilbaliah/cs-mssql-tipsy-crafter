namespace AmritaDb.Tipsy.Infrastructure.Specifications.Retail;

using Domain.Retail;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class PaymentSpecifications : IEntityTypeConfiguration<Payment>
{
    public void Configure(EntityTypeBuilder<Payment> builder)
    {
        builder.ToTable("payment", "retail", tableBuilder =>
            {
                tableBuilder.IsTemporal()
                    .UseHistoryTable("payment_history", "retail");
                tableBuilder.IsTemporal()
                    .HasPeriodStart("valid_from");
                tableBuilder.IsTemporal()
                    .HasPeriodEnd("valid_to");
            }
        );
        
        builder.HasKey(payment => payment.Id);
        builder.Property(payment => payment.Id)
            .ValueGeneratedNever()
            .HasColumnName("id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
        
        builder.Property(payment => payment.ReceiptId)
            .HasColumnName("receipt_id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
            
        builder.Property(payment => payment.PaymentModeId)
            .HasColumnName("payment_mode_id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);

        builder.Property(payment => payment.Amount)
            .HasColumnType("money")
            .HasColumnName("amount")
            .HasDefaultValue(0);
        
        builder.Property(payment => payment.Memo)
            .HasColumnName("memo")
            .HasColumnType("varchar(500)")
            .HasMaxLength(500);
        
        builder.Property(payment => payment.ModifiedBy)
            .HasColumnName("modified_by")
            .HasColumnType("varchar(200)")
            .HasMaxLength(200)
            .HasDefaultValue("SYSTEM");
    }
}