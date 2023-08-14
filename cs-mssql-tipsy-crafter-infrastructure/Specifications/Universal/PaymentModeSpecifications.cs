namespace AmritaDb.Tipsy.Infrastructure.Specifications.Universal;

using Domain.Universal;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class PaymentModeSpecifications : IEntityTypeConfiguration<PaymentMode>
{
    public void Configure(EntityTypeBuilder<PaymentMode> builder)
    {
        builder.ToTable("payment_mode", "universal", tableBuilder =>
            {
                tableBuilder.IsTemporal()
                    .UseHistoryTable("payment_mode_history", "universal");
                tableBuilder.IsTemporal()
                    .HasPeriodStart("valid_from");
                tableBuilder.IsTemporal()
                    .HasPeriodEnd("valid_to");
            }
        );

        builder.HasKey(paymentMode => paymentMode.Id);
        builder.Property(paymentMode => paymentMode.Id)
            .ValueGeneratedNever()
            .HasColumnName("id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);

        builder.Property(paymentMode => paymentMode.Name)
            .HasColumnName("name")
            .HasColumnType("varchar(40)")
            .HasMaxLength(40);

        builder.Property(paymentMode => paymentMode.Description)
            .HasColumnName("description")
            .HasColumnType("varchar(200)")
            .HasMaxLength(200);

        builder.HasData(new PaymentMode { Id = "01H7PCVP1HGHM93SX4HSW8EM2B", Name = "Cash", Description = "Cash" },
            new PaymentMode { Id = "01H7PCVQ1ERMXJJND16HKKHTKQ", Name = "Cheque", Description = "Cheque / Check" },
            new PaymentMode
            {
                Id = "01H7PCVR0R9723KKDRKGSRPRYS", Name = "Wire Transfer", Description = "Wire Transfer"
            },
            new PaymentMode { Id = "01H7PCVS01J4ZANSQHEKV658H1", Name = "Credit Card", Description = "Credit Card" });
    }
}