namespace AmritaDb.Tipsy.Infrastructure.Specifications.Universal;

using Domain.Universal;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ShipperSpecifications : IEntityTypeConfiguration<Shipper>
{
    public void Configure(EntityTypeBuilder<Shipper> builder)
    {
        builder.ToTable("shipper", "universal", tableBuilder =>
            {
                tableBuilder.IsTemporal()
                    .UseHistoryTable("shipper_history", "universal");
                tableBuilder.IsTemporal()
                    .HasPeriodStart("valid_from");
                tableBuilder.IsTemporal()
                    .HasPeriodEnd("valid_to");
            }
        );

        builder.HasKey(shipper => shipper.Id);
        builder.Property(shipper => shipper.Id)
            .ValueGeneratedNever()
            .HasColumnName("id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);

        builder.Property(shipper => shipper.Name)
            .HasColumnName("name")
            .HasColumnType("varchar(40)")
            .HasMaxLength(40);

        builder.Property(shipper => shipper.Description)
            .HasColumnName("description")
            .HasColumnType("varchar(200)")
            .HasMaxLength(200);

        builder.HasData(
            new Shipper
            {
                Id = "01H7Y9WKT6KVNRRP0H8SF139DK", Name = "USPS", Description = "Unites States Postal Services"
            }, new Shipper { Id = "01H7Y9WMT5PCJ8TQ6QDTPDAT4D", Name = "FedEx", Description = "FDX Corporation" },
            new Shipper { Id = "01H7Y9WNSKG2KF6WKJ98CY015P", Name = "UPS", Description = "United Parcel Service" },
            new Shipper { Id = "01H7Y9WPSBYTQ1SHVFF82H2553", Name = "DHL", Description = "Deutsche Post AG" });
    }
}