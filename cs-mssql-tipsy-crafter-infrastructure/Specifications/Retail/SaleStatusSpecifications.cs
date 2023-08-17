namespace AmritaDb.Tipsy.Infrastructure.Specifications.Retail;

using Domain.Retail;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class SaleStatusSpecifications : IEntityTypeConfiguration<SaleStatus>
{
    public void Configure(EntityTypeBuilder<SaleStatus> builder)
    {
        builder.ToTable("sale_status", "retail", tableBuilder =>
            {
                tableBuilder.IsTemporal()
                    .UseHistoryTable("sale_status_history", "retail");
                tableBuilder.IsTemporal()
                    .HasPeriodStart("valid_from");
                tableBuilder.IsTemporal()
                    .HasPeriodEnd("valid_to");
            }
        );

        builder.HasKey(saleStatus => saleStatus.Id);
        builder.Property(saleStatus => saleStatus.Id)
            .ValueGeneratedNever()
            .HasColumnName("id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);

        builder.Property(saleStatus => saleStatus.Name)
            .HasColumnName("name")
            .HasColumnType("varchar(40)")
            .HasMaxLength(40);

        builder.Property(saleStatus => saleStatus.Description)
            .HasColumnName("description")
            .HasColumnType("varchar(200)")
            .HasMaxLength(200);
        
        builder.HasMany(status => status.Receipts)
            .WithOne(receipt => receipt.Status)
            .HasForeignKey(receipt => receipt.StatusId)
            .HasPrincipalKey(status => status.Id)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasData(new SaleStatus { Id = "01H7PKYDSN6HR02HNNJZQ2SEVF", Name = "In Scan", Description = "In Scan" },
            new SaleStatus { Id = "01H7PKYES5MB6TSXVNWGHY05M8", Name = "Paid", Description = "Paid" },
            new SaleStatus
            {
                Id = "01H7PKYFRXQHKA0MEH3WWNB3GG", Name = "Ready for shipment", Description = "Ready for shipment"
            }, new SaleStatus { Id = "01H7PKYGR6C0YJC0RA9YYZ6JMG", Name = "Shipped", Description = "Shipped" },
            new SaleStatus { Id = "01H7PKYHQGXTAXYW6WMXB2QCR1", Name = "Delivered", Description = "Delivered" },
            new SaleStatus { Id = "01H7PKYJQ2A3PQ5QJ33DWB0ZFX", Name = "Cancelled", Description = "Cancelled" });
    }
}