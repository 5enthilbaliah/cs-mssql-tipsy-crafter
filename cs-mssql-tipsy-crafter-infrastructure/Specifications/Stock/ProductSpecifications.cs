namespace AmritaDb.Tipsy.Infrastructure.Specifications.Stock;

using Domain.Stock;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ProductSpecifications : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("product", "stock", tableBuilder =>
            {
                tableBuilder.IsTemporal()
                    .UseHistoryTable("product_history", "stock");
                tableBuilder.IsTemporal()
                    .HasPeriodStart("valid_from");
                tableBuilder.IsTemporal()
                    .HasPeriodEnd("valid_to");
            }
        );
        
        builder.HasKey(product => product.Id);
        builder.Property(product => product.Id)
            .ValueGeneratedNever()
            .HasColumnName("id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
        
        builder.Property(product => product.Name)
            .HasColumnName("name")
            .HasColumnType("varchar(80)")
            .HasMaxLength(80);
        
        builder.Property(product => product.Description)
            .HasColumnName("description")
            .HasColumnType("varchar(2000)")
            .HasMaxLength(2000);
        
        builder.Property(product => product.Upc)
            .HasColumnName("upc")
            .HasColumnType("varchar(12)")
            .HasMaxLength(12);
        
        builder.Property(product => product.Sku)
            .HasColumnName("sku")
            .HasColumnType("varchar(12)")
            .HasMaxLength(12);
        
        builder.Property(product => product.ProductTypeId)
            .HasColumnName("product_type_id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
    }
}