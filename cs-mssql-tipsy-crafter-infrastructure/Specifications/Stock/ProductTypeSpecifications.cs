namespace AmritaDb.Tipsy.Infrastructure.Specifications.Stock;

using Domain.Stock;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ProductTypeSpecifications : IEntityTypeConfiguration<ProductType>
{
    public void Configure(EntityTypeBuilder<ProductType> builder)
    {
        builder.ToTable("product_type", "stock", tableBuilder =>
            {
                tableBuilder.IsTemporal()
                    .UseHistoryTable("product_type_history", "stock");
                tableBuilder.IsTemporal()
                    .HasPeriodStart("valid_from");
                tableBuilder.IsTemporal()
                    .HasPeriodEnd("valid_to");
            }
        );
        
        builder.HasKey(productType => productType.Id);
        builder.Property(productType => productType.Id)
            .ValueGeneratedNever()
            .HasColumnName("id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
        
        builder.Property(productType => productType.Name)
            .HasColumnName("name")
            .HasColumnType("varchar(80)")
            .HasMaxLength(80);
        
        builder.Property(productType => productType.Description)
            .HasColumnName("description")
            .HasColumnType("varchar(2000)")
            .HasMaxLength(2000);
        
        builder.Property(productType => productType.CategoryId)
            .HasColumnName("category_id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
    }
}