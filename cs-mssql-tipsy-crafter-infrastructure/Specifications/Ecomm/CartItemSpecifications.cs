// ReSharper disable once IdentifierTypo
namespace AmritaDb.Tipsy.Infrastructure.Specifications.Ecomm;

using Domain.Ecomm;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class CartItemSpecifications : IEntityTypeConfiguration<CartItem>
{
    public void Configure(EntityTypeBuilder<CartItem> builder)
    {
        // ReSharper disable once StringLiteralTypo
        builder.ToTable("cart_item", "ecomm");
        
        builder.HasKey(cartItem => cartItem.Id);
        builder.Property(cartItem => cartItem.Id)
            .ValueGeneratedNever()
            .HasColumnName("id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
        
        builder.Property(cartItem => cartItem.CartId)
            .HasColumnName("cart_id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
        
        builder.Property(cartItem => cartItem.ProductId)
            .HasColumnName("product_id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
        
        builder.Property(cartItem => cartItem.Quantity)
            .HasColumnType("int")
            .HasColumnName("qty")
            .HasDefaultValue(0);
        
        builder.Property(cartItem => cartItem.Msrp)
            .HasColumnType("money")
            .HasColumnName("msrp")
            .HasDefaultValue(0);
    }
}