﻿// <auto-generated />
using System;
using AmritaDb.Tipsy.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AmritaDb.Tipsy.Infrastructure.Migrations
{
    [DbContext(typeof(AmritaTipsyDbContext))]
    partial class AmritaTipsyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AmritaDb.Tipsy.Domain.Universal.ContactType", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(26)
                        .HasColumnType("varchar(26)")
                        .HasColumnName("id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("name");

                    b.Property<DateTime>("valid_from")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasColumnName("valid_from");

                    b.Property<DateTime>("valid_to")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasColumnName("valid_to");

                    b.HasKey("Id");

                    b.ToTable("contact_type", "universal");

                    b.ToTable(tb => tb.IsTemporal(ttb =>
                            {
                                ttb.UseHistoryTable("contact_type_history", "universal");
                                ttb
                                    .HasPeriodStart("valid_from")
                                    .HasColumnName("valid_from");
                                ttb
                                    .HasPeriodEnd("valid_to")
                                    .HasColumnName("valid_to");
                            }));
                });

            modelBuilder.Entity("AmritaDb.Tipsy.Domain.Universal.Country", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(26)
                        .HasColumnType("varchar(26)")
                        .HasColumnName("id");

                    b.Property<string>("Iso3Code")
                        .HasMaxLength(3)
                        .HasColumnType("char(3)")
                        .HasColumnName("iso3");

                    b.Property<string>("IsoCode")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("char(2)")
                        .HasColumnName("iso");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)")
                        .HasColumnName("name");

                    b.Property<short?>("NumericCode")
                        .HasColumnType("smallint")
                        .HasColumnName("num_code");

                    b.Property<short>("PhoneCode")
                        .HasColumnType("smallint")
                        .HasColumnName("phone_code");

                    b.Property<DateTime>("valid_from")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasColumnName("valid_from");

                    b.Property<DateTime>("valid_to")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasColumnName("valid_to");

                    b.HasKey("Id");

                    b.ToTable("country", "universal");

                    b.ToTable(tb => tb.IsTemporal(ttb =>
                            {
                                ttb.UseHistoryTable("country_history", "universal");
                                ttb
                                    .HasPeriodStart("valid_from")
                                    .HasColumnName("valid_from");
                                ttb
                                    .HasPeriodEnd("valid_to")
                                    .HasColumnName("valid_to");
                            }));
                });
#pragma warning restore 612, 618
        }
    }
}
