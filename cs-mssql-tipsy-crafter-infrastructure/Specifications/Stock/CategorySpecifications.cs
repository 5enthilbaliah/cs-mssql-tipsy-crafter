namespace AmritaDb.Tipsy.Infrastructure.Specifications.Stock;

using Domain.Stock;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class CategorySpecifications  : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("category", "stock", tableBuilder =>
            {
                tableBuilder.IsTemporal()
                    .UseHistoryTable("category_history", "stock");
                tableBuilder.IsTemporal()
                    .HasPeriodStart("valid_from");
                tableBuilder.IsTemporal()
                    .HasPeriodEnd("valid_to");
            }
        );
        
        builder.HasKey(category => category.Id);
        builder.Property(category => category.Id)
            .ValueGeneratedNever()
            .HasColumnName("id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
        
        builder.Property(category => category.Name)
            .HasColumnName("name")
            .HasColumnType("varchar(80)")
            .HasMaxLength(80);
        
        builder.Property(category => category.Description)
            .HasColumnName("description")
            .HasColumnType("varchar(2000)")
            .HasMaxLength(2000);
        
        builder.Property(category => category.Slug)
            .HasColumnName("slug")
            .HasColumnType("varchar(80)")
            .HasMaxLength(80);
        
        builder.Property(category => category.ParentId)
            .HasColumnName("parent_id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
        
        builder.Property(category => category.ModifiedBy)
            .HasColumnName("modified_by")
            .HasColumnType("varchar(200)")
            .HasMaxLength(200)
            .HasDefaultValue("SYSTEM");
        
        builder.HasMany(category => category.Children)
            .WithOne(child => child.ParentCategory)
            .HasForeignKey(child => child.ParentId)
            .HasPrincipalKey(category => category.Id)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasMany(category => category.ProductTypes)
            .WithOne(productType => productType.Category)
            .HasForeignKey(productType => productType.CategoryId)
            .HasPrincipalKey(category => category.Id)
            .OnDelete(DeleteBehavior.Restrict);
    }
}