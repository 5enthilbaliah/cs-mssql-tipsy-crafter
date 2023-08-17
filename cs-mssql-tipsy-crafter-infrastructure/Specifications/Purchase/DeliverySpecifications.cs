﻿namespace AmritaDb.Tipsy.Infrastructure.Specifications.Purchase;

using Domain.Purchase;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class DeliverySpecifications : IEntityTypeConfiguration<Delivery>
{
    public void Configure(EntityTypeBuilder<Delivery> builder)
    {
        builder.ToTable("delivery", "purchase", tableBuilder =>
            {
                tableBuilder.IsTemporal()
                    .UseHistoryTable("delivery_history", "purchase");
                tableBuilder.IsTemporal()
                    .HasPeriodStart("valid_from");
                tableBuilder.IsTemporal()
                    .HasPeriodEnd("valid_to");
            }
        );
        
        builder.HasKey(delivery => delivery.Id);
        builder.Property(delivery => delivery.Id)
            .ValueGeneratedNever()
            .HasColumnName("id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
        
        builder.Property(delivery => delivery.ExternalId)
            .HasColumnName("external_id")
            .HasColumnType("nvarchar(500)")
            .HasMaxLength(500);
        
        builder.Property(delivery => delivery.TrackingId)
            .HasColumnName("tracking_id")
            .HasColumnType("nvarchar(500)")
            .HasMaxLength(500);
        
        builder.Property(delivery => delivery.OrderId)
            .HasColumnName("order_id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
        
        builder.Property(delivery => delivery.ShipperId)
            .HasColumnName("shipper_id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
        
        builder.Property(delivery => delivery.IsDelivered)
            .HasColumnName("is_delivered")
            .HasColumnType("bit")
            .HasDefaultValue(0);
        
        builder.Property(delivery => delivery.Date)
            .HasColumnName("date")
            .HasColumnType("datetime2(7)");
    }
}