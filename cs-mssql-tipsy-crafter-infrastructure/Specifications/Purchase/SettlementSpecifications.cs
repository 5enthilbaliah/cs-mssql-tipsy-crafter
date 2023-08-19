namespace AmritaDb.Tipsy.Infrastructure.Specifications.Purchase;

using Domain.Purchase;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class SettlementSpecifications : IEntityTypeConfiguration<Settlement>
{
    public void Configure(EntityTypeBuilder<Settlement> builder)
    {
        builder.ToTable("settlement", "purchase", tableBuilder =>
            {
                tableBuilder.IsTemporal()
                    .UseHistoryTable("settlement_history", "purchase");
                tableBuilder.IsTemporal()
                    .HasPeriodStart("valid_from");
                tableBuilder.IsTemporal()
                    .HasPeriodEnd("valid_to");
            }
        );
        
        builder.HasKey(settlement => settlement.Id);
        builder.Property(settlement => settlement.Id)
            .ValueGeneratedNever()
            .HasColumnName("id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
        
        builder.Property(settlement => settlement.OrderId)
            .HasColumnName("order_id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
            
        builder.Property(settlement => settlement.PaymentModeId)
            .HasColumnName("payment_mode_id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
        
        builder.Property(settlement => settlement.PaidCurrency)
            .HasColumnType("char(3)")
            .HasColumnName("paid_currency")
            .HasMaxLength(3)
            .HasDefaultValue("USD");

        builder.Property(settlement => settlement.Paid)
            .HasColumnType("money")
            .HasColumnName("paid_amount")
            .HasDefaultValue(0);
        
        builder.Property(settlement => settlement.Memo)
            .HasColumnName("memo")
            .HasColumnType("varchar(500)")
            .HasMaxLength(500);
        
        builder.Property(settlement => settlement.ModifiedBy)
            .HasColumnName("modified_by")
            .HasColumnType("varchar(200)")
            .HasMaxLength(200)
            .HasDefaultValue("SYSTEM");
    }
}