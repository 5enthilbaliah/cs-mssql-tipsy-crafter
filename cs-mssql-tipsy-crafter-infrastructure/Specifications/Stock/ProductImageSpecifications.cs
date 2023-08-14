namespace AmritaDb.Tipsy.Infrastructure.Specifications.Stock;

using Domain.Stock;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ProductImageSpecifications : IEntityTypeConfiguration<ProductImage>
{
    public void Configure(EntityTypeBuilder<ProductImage> builder)
    {
        builder.ToTable("product_image", "stock", tableBuilder =>
            {
                tableBuilder.IsTemporal()
                    .UseHistoryTable("product_image_history", "stock");
                tableBuilder.IsTemporal()
                    .HasPeriodStart("valid_from");
                tableBuilder.IsTemporal()
                    .HasPeriodEnd("valid_to");
            }
        );
        
        builder.HasKey(productImage => productImage.Id);
        builder.Property(productImage => productImage.Id)
            .ValueGeneratedNever()
            .HasColumnName("id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
        
        builder.Property(productImage => productImage.ImageUrl)
            .HasColumnName("image_url")
            .HasColumnType("varchar(512)")
            .HasMaxLength(512);

        builder.Property(productImage => productImage.Title)
            .HasColumnName("title")
            .HasColumnType("varchar(40)")
            .HasMaxLength(40);
        
        builder.Property(productImage => productImage.ProductId)
            .HasColumnName("product_id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
    }
}