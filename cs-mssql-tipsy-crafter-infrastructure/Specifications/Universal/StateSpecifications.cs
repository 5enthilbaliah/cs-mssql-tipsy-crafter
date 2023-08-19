namespace AmritaDb.Tipsy.Infrastructure.Specifications.Universal;

using Domain.Universal;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class StateSpecifications : IEntityTypeConfiguration<State>
{
    public void Configure(EntityTypeBuilder<State> builder)
    {
        builder.ToTable("state", "universal", tableBuilder =>
            {
                tableBuilder.IsTemporal()
                    .UseHistoryTable("state_history", "universal");
                tableBuilder.IsTemporal()
                    .HasPeriodStart("valid_from");
                tableBuilder.IsTemporal()
                    .HasPeriodEnd("valid_to");
            }
        );
        
        builder.HasKey(state => state.Id);
        builder.Property(state => state.Id)
            .ValueGeneratedNever()
            .HasColumnName("id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
        
        builder.Property(state => state.CountryId)
            .ValueGeneratedNever()
            .HasColumnName("country_id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);
        
        builder.Property(state => state.Code)
            .ValueGeneratedNever()
            .HasColumnName("code")
            .HasColumnType("char(5)")
            .HasMaxLength(5);
        
        builder.Property(state => state.Name)
            .HasColumnName("name")
            .HasColumnType("varchar(80)")
            .HasMaxLength(80);
        
        builder.Property(state => state.ModifiedBy)
            .HasColumnName("modified_by")
            .HasColumnType("varchar(200)")
            .HasMaxLength(200)
            .HasDefaultValue("SYSTEM");
    }
}