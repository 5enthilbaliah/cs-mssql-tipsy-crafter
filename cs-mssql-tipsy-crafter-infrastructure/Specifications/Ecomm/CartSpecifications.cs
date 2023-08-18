namespace AmritaDb.Tipsy.Infrastructure.Specifications.Ecomm;

using Domain.Ecomm;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class CartSpecifications : IEntityTypeConfiguration<Cart>
{
    public void Configure(EntityTypeBuilder<Cart> builder)
    {
        // ReSharper disable once StringLiteralTypo
        builder.ToTable("cart", "ecomm");
        
        builder.HasKey(cart => cart.Id);
        builder.Property(cart => cart.Id)
            .ValueGeneratedNever()
            .HasColumnName("id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
        
        builder.Property(cart => cart.CustomerId)
            .HasColumnName("customer_id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
        
        builder.HasMany(cart => cart.Items)
            .WithOne(cartItem => cartItem.Cart)
            .HasForeignKey(cartItem => cartItem.CartId)
            .HasPrincipalKey(cart => cart.Id)
            .OnDelete(DeleteBehavior.Restrict);
    }
}