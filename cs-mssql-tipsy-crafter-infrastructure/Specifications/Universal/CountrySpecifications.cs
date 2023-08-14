namespace AmritaDb.Tipsy.Infrastructure.Specifications.Universal;

using Domain.Universal;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class CountrySpecifications : IEntityTypeConfiguration<Country>
{
    public void Configure(EntityTypeBuilder<Country> builder)
    {
        builder.ToTable("country", "universal", tableBuilder =>
            {
                tableBuilder.IsTemporal()
                    .UseHistoryTable("country_history", "universal");
                tableBuilder.IsTemporal()
                    .HasPeriodStart("valid_from");
                tableBuilder.IsTemporal()
                    .HasPeriodEnd("valid_to");
            }
        );

        builder.HasKey(country => country.Id);
        builder.Property(country => country.Id)
            .ValueGeneratedNever()
            .HasColumnName("id")
            .HasColumnType("varchar(26)")
            .HasMaxLength(26);

        builder.Property(country => country.Name)
            .HasColumnName("name")
            .HasColumnType("varchar(80)")
            .HasMaxLength(80);

        builder.Property(country => country.IsoCode)
            .HasColumnName("iso")
            .HasColumnType("char(2)")
            .HasMaxLength(2);

        builder.Property(country => country.Iso3Code)
            .HasColumnName("iso3")
            .HasColumnType("char(3)")
            .HasMaxLength(3);

        builder.Property(country => country.NumericCode)
            .HasColumnName("num_code")
            .HasColumnType("smallint");

        builder.Property(country => country.PhoneCode)
            .HasColumnName("phone_code")
            .HasColumnType("smallint");

        builder.Property(country => country.CurrencyCode)
            .HasColumnName("currency_code")
            .HasColumnType("char(3)")
            .HasMaxLength(3);

        builder.HasMany(country => country.States)
            .WithOne(state => state.Country)
            .HasForeignKey(state => state.CountryId)
            .HasPrincipalKey(country => country.Id)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasData(
            new Country
            {
                Id = "01H7PBQ3MQX3EBSHD7QPVZJ0H9",
                Name = "United States of America",
                CurrencyCode = "USD",
                Iso3Code = "USA",
                IsoCode = "US",
                NumericCode = 840,
                PhoneCode = 1
            },
            new Country
            {
                Id = "01H7PBQ3MR64WY2NKZH42K6YNX",
                Name = "United Kingdom",
                CurrencyCode = "GBP",
                Iso3Code = "GBR",
                IsoCode = "GB",
                NumericCode = 826,
                PhoneCode = 44
            },
            new Country
            {
                Id = "01H7PBQ3MRE96CH0CHH0T5VESH",
                Name = "France",
                CurrencyCode = "EUR",
                Iso3Code = "FRA",
                IsoCode = "FR",
                NumericCode = 250,
                PhoneCode = 33
            }, new Country
            {
                Id = "01H7PBQ3MRF96R5ES7EYPWDTYX",
                Name = "Mexico",
                CurrencyCode = "MXN",
                Iso3Code = "MEX",
                IsoCode = "MX",
                NumericCode = 484,
                PhoneCode = 52
            });
    }
}