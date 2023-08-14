namespace AmritaDb.Tipsy.Infrastructure.Specifications.Purchase;

using Domain.Purchase;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class OrderStatusSpecifications : IEntityTypeConfiguration<OrderStatus>
{
    public void Configure(EntityTypeBuilder<OrderStatus> builder)
    {
        builder.ToTable("order_status", "purchase", tableBuilder =>
            {
                tableBuilder.IsTemporal()
                    .UseHistoryTable("order_status_history", "purchase");
                tableBuilder.IsTemporal()
                    .HasPeriodStart("valid_from");
                tableBuilder.IsTemporal()
                    .HasPeriodEnd("valid_to");
            }
        );

        builder.HasKey(orderStatus => orderStatus.Id);
        builder.Property(orderStatus => orderStatus.Id)
            .ValueGeneratedNever()
            .HasColumnName("id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);

        builder.Property(orderStatus => orderStatus.Name)
            .HasColumnName("name")
            .HasColumnType("varchar(40)")
            .HasMaxLength(40);

        builder.Property(orderStatus => orderStatus.Description)
            .HasColumnName("description")
            .HasColumnType("varchar(200)")
            .HasMaxLength(200);

        builder.HasData(new OrderStatus { Id = "01H7PKMMPRCGB7D65EYPKVAYMH", Name = "New", Description = "New" },
            new OrderStatus
            {
                Id = "01H7PKMNPMC0F7FD77DHK13T0V", Name = "Pending Approval", Description = "Pending Approval"
            }, new OrderStatus { Id = "01H7PKMPP7608Q953DWESMTB14", Name = "Approved", Description = "Approved" },
            new OrderStatus { Id = "01H7PKMQNYMDYZBD9ANEWFHHHV", Name = "Rejected", Description = "Rejected" },
            new OrderStatus { Id = "01H7PKMRNJA9VKTX6B684F7WXK", Name = "Paid", Description = "Paid" },
            new OrderStatus { Id = "01H7PKMSMY139E73SAJ1VASE2X", Name = "Cancelled", Description = "Cancelled" },
            new OrderStatus { Id = "01H7PKMTMKVK40YGYDE7AHBDAP", Name = "In Transit", Description = "In Transit" },
            new OrderStatus { Id = "01H7PKMVM9XNS6Y2V76DBCVG8G", Name = "Received", Description = "Received" },
            new OrderStatus
            {
                Id = "01H7PKMWKKP76KPDYZW5N5K6KZ", Name = "Partially fulfilled", Description = "Partially fulfilled"
            }, new OrderStatus { Id = "01H7PKMXK8XT413F2P2HPSPNP5", Name = "Completed", Description = "Completed" },
            new OrderStatus { Id = "01H7PKYCSPBKNQXNKPSY2B6BJG", Name = "Returned", Description = "Returned" });
    }
}