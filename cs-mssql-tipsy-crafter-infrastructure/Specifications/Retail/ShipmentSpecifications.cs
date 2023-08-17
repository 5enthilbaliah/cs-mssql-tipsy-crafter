namespace AmritaDb.Tipsy.Infrastructure.Specifications.Retail;

using Domain.Retail;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ShipmentSpecifications : IEntityTypeConfiguration<Shipment>
{
    public void Configure(EntityTypeBuilder<Shipment> builder)
    {
        builder.ToTable("shipment", "retail", tableBuilder =>
            {
                tableBuilder.IsTemporal()
                    .UseHistoryTable("shipment_history", "retail");
                tableBuilder.IsTemporal()
                    .HasPeriodStart("valid_from");
                tableBuilder.IsTemporal()
                    .HasPeriodEnd("valid_to");
            }
        );
        
        builder.HasKey(shipment => shipment.Id);
        builder.Property(shipment => shipment.Id)
            .ValueGeneratedNever()
            .HasColumnName("id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);

        builder.Property(shipment => shipment.TrackingId)
            .HasColumnName("tracking_id")
            .HasColumnType("nvarchar(500)")
            .HasMaxLength(500);
        
        builder.Property(shipment => shipment.ReceiptId)
            .HasColumnName("receipt_id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
        
        builder.Property(shipment => shipment.ShipperId)
            .HasColumnName("shipper_id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
        
        builder.Property(shipment => shipment.IsDelivered)
            .HasColumnName("is_delivered")
            .HasColumnType("bit")
            .HasDefaultValue(0);
        
        builder.Property(shipment => shipment.Date)
            .HasColumnName("date")
            .HasColumnType("datetime2(7)");
    }
}