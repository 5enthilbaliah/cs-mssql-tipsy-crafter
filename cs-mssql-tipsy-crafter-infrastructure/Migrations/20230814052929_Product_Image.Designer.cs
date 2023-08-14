﻿// <auto-generated />
using System;
using AmritaDb.Tipsy.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AmritaDb.Tipsy.Infrastructure.Migrations
{
    [DbContext(typeof(AmritaTipsyDbContext))]
    [Migration("20230814052929_Product_Image")]
    partial class Product_Image
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AmritaDb.Tipsy.Domain.Purchase.OrderStatus", b =>
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

                    b.ToTable("order_status", "purchase");

                    b.ToTable(tb => tb.IsTemporal(ttb =>
                            {
                                ttb.UseHistoryTable("order_status_history", "purchase");
                                ttb
                                    .HasPeriodStart("valid_from")
                                    .HasColumnName("valid_from");
                                ttb
                                    .HasPeriodEnd("valid_to")
                                    .HasColumnName("valid_to");
                            }));

                    b.HasData(
                        new
                        {
                            Id = "01H7PKMMPRCGB7D65EYPKVAYMH",
                            Description = "New",
                            Name = "New"
                        },
                        new
                        {
                            Id = "01H7PKMNPMC0F7FD77DHK13T0V",
                            Description = "Pending Approval",
                            Name = "Pending Approval"
                        },
                        new
                        {
                            Id = "01H7PKMPP7608Q953DWESMTB14",
                            Description = "Approved",
                            Name = "Approved"
                        },
                        new
                        {
                            Id = "01H7PKMQNYMDYZBD9ANEWFHHHV",
                            Description = "Rejected",
                            Name = "Rejected"
                        },
                        new
                        {
                            Id = "01H7PKMRNJA9VKTX6B684F7WXK",
                            Description = "Paid",
                            Name = "Paid"
                        },
                        new
                        {
                            Id = "01H7PKMSMY139E73SAJ1VASE2X",
                            Description = "Cancelled",
                            Name = "Cancelled"
                        },
                        new
                        {
                            Id = "01H7PKMTMKVK40YGYDE7AHBDAP",
                            Description = "In Transit",
                            Name = "In Transit"
                        },
                        new
                        {
                            Id = "01H7PKMVM9XNS6Y2V76DBCVG8G",
                            Description = "Received",
                            Name = "Received"
                        },
                        new
                        {
                            Id = "01H7PKMWKKP76KPDYZW5N5K6KZ",
                            Description = "Partially fulfilled",
                            Name = "Partially fulfilled"
                        },
                        new
                        {
                            Id = "01H7PKMXK8XT413F2P2HPSPNP5",
                            Description = "Completed",
                            Name = "Completed"
                        },
                        new
                        {
                            Id = "01H7PKYCSPBKNQXNKPSY2B6BJG",
                            Description = "Returned",
                            Name = "Returned"
                        });
                });

            modelBuilder.Entity("AmritaDb.Tipsy.Domain.Retail.SaleStatus", b =>
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

                    b.ToTable("sale_status", "retail");

                    b.ToTable(tb => tb.IsTemporal(ttb =>
                            {
                                ttb.UseHistoryTable("sale_status_history", "retail");
                                ttb
                                    .HasPeriodStart("valid_from")
                                    .HasColumnName("valid_from");
                                ttb
                                    .HasPeriodEnd("valid_to")
                                    .HasColumnName("valid_to");
                            }));

                    b.HasData(
                        new
                        {
                            Id = "01H7PKYDSN6HR02HNNJZQ2SEVF",
                            Description = "In Scan",
                            Name = "In Scan"
                        },
                        new
                        {
                            Id = "01H7PKYES5MB6TSXVNWGHY05M8",
                            Description = "Paid",
                            Name = "Paid"
                        },
                        new
                        {
                            Id = "01H7PKYFRXQHKA0MEH3WWNB3GG",
                            Description = "Ready for shipment",
                            Name = "Ready for shipment"
                        },
                        new
                        {
                            Id = "01H7PKYGR6C0YJC0RA9YYZ6JMG",
                            Description = "Shipped",
                            Name = "Shipped"
                        },
                        new
                        {
                            Id = "01H7PKYHQGXTAXYW6WMXB2QCR1",
                            Description = "Delivered",
                            Name = "Delivered"
                        },
                        new
                        {
                            Id = "01H7PKYJQ2A3PQ5QJ33DWB0ZFX",
                            Description = "Cancelled",
                            Name = "Cancelled"
                        });
                });

            modelBuilder.Entity("AmritaDb.Tipsy.Domain.Stock.Category", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(26)
                        .HasColumnType("varchar(26)")
                        .HasColumnName("id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("varchar(2000)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)")
                        .HasColumnName("name");

                    b.Property<string>("ParentId")
                        .HasMaxLength(26)
                        .HasColumnType("varchar(26)")
                        .HasColumnName("parent_id");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)")
                        .HasColumnName("slug");

                    b.Property<DateTime>("valid_from")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasColumnName("valid_from");

                    b.Property<DateTime>("valid_to")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasColumnName("valid_to");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("category", "stock");

                    b.ToTable(tb => tb.IsTemporal(ttb =>
                            {
                                ttb.UseHistoryTable("category_history", "stock");
                                ttb
                                    .HasPeriodStart("valid_from")
                                    .HasColumnName("valid_from");
                                ttb
                                    .HasPeriodEnd("valid_to")
                                    .HasColumnName("valid_to");
                            }));
                });

            modelBuilder.Entity("AmritaDb.Tipsy.Domain.Stock.Product", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(26)
                        .HasColumnType("varchar(26)")
                        .HasColumnName("id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("varchar(2000)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)")
                        .HasColumnName("name");

                    b.Property<string>("ProductTypeId")
                        .IsRequired()
                        .HasMaxLength(26)
                        .HasColumnType("varchar(26)")
                        .HasColumnName("product_type_id");

                    b.Property<string>("Sku")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("varchar(12)")
                        .HasColumnName("sku");

                    b.Property<string>("Upc")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("varchar(12)")
                        .HasColumnName("upc");

                    b.Property<DateTime>("valid_from")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasColumnName("valid_from");

                    b.Property<DateTime>("valid_to")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasColumnName("valid_to");

                    b.HasKey("Id");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("product", "stock");

                    b.ToTable(tb => tb.IsTemporal(ttb =>
                            {
                                ttb.UseHistoryTable("product_history", "stock");
                                ttb
                                    .HasPeriodStart("valid_from")
                                    .HasColumnName("valid_from");
                                ttb
                                    .HasPeriodEnd("valid_to")
                                    .HasColumnName("valid_to");
                            }));
                });

            modelBuilder.Entity("AmritaDb.Tipsy.Domain.Stock.ProductImage", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(26)
                        .HasColumnType("varchar(26)")
                        .HasColumnName("id");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("varchar(512)")
                        .HasColumnName("image_url");

                    b.Property<string>("ProductId")
                        .IsRequired()
                        .HasMaxLength(26)
                        .HasColumnType("varchar(26)")
                        .HasColumnName("product_id");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("title");

                    b.Property<DateTime>("valid_from")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasColumnName("valid_from");

                    b.Property<DateTime>("valid_to")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasColumnName("valid_to");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("product_image", "stock");

                    b.ToTable(tb => tb.IsTemporal(ttb =>
                            {
                                ttb.UseHistoryTable("product_image_history", "stock");
                                ttb
                                    .HasPeriodStart("valid_from")
                                    .HasColumnName("valid_from");
                                ttb
                                    .HasPeriodEnd("valid_to")
                                    .HasColumnName("valid_to");
                            }));
                });

            modelBuilder.Entity("AmritaDb.Tipsy.Domain.Stock.ProductType", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(26)
                        .HasColumnType("varchar(26)")
                        .HasColumnName("id");

                    b.Property<string>("CategoryId")
                        .IsRequired()
                        .HasMaxLength(26)
                        .HasColumnType("varchar(26)")
                        .HasColumnName("category_id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("varchar(2000)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)")
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

                    b.HasIndex("CategoryId");

                    b.ToTable("product_type", "stock");

                    b.ToTable(tb => tb.IsTemporal(ttb =>
                            {
                                ttb.UseHistoryTable("product_type_history", "stock");
                                ttb
                                    .HasPeriodStart("valid_from")
                                    .HasColumnName("valid_from");
                                ttb
                                    .HasPeriodEnd("valid_to")
                                    .HasColumnName("valid_to");
                            }));
                });

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

                    b.HasData(
                        new
                        {
                            Id = "01H7PBQ3MBB6ZX1Y39TV6KPM5T",
                            Description = "Phone Number",
                            Name = "Phone"
                        },
                        new
                        {
                            Id = "01H7PBQ3MQ33DF64P8FDZJ6CCG",
                            Description = "Email Address",
                            Name = "Email"
                        },
                        new
                        {
                            Id = "01H7PBQ3MQRT5Q538QR2VCQZZT",
                            Description = "Fax Number",
                            Name = "Fax"
                        });
                });

            modelBuilder.Entity("AmritaDb.Tipsy.Domain.Universal.Country", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(26)
                        .HasColumnType("varchar(26)")
                        .HasColumnName("id");

                    b.Property<string>("CurrencyCode")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("char(3)")
                        .HasColumnName("currency_code");

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

                    b.HasData(
                        new
                        {
                            Id = "01H7PBQ3MQX3EBSHD7QPVZJ0H9",
                            CurrencyCode = "USD",
                            Iso3Code = "USA",
                            IsoCode = "US",
                            Name = "United States of America",
                            NumericCode = (short)840,
                            PhoneCode = (short)1
                        },
                        new
                        {
                            Id = "01H7PBQ3MR64WY2NKZH42K6YNX",
                            CurrencyCode = "GBP",
                            Iso3Code = "GBR",
                            IsoCode = "GB",
                            Name = "United Kingdom",
                            NumericCode = (short)826,
                            PhoneCode = (short)44
                        },
                        new
                        {
                            Id = "01H7PBQ3MRE96CH0CHH0T5VESH",
                            CurrencyCode = "EUR",
                            Iso3Code = "FRA",
                            IsoCode = "FR",
                            Name = "France",
                            NumericCode = (short)250,
                            PhoneCode = (short)33
                        },
                        new
                        {
                            Id = "01H7PBQ3MRF96R5ES7EYPWDTYX",
                            CurrencyCode = "MXN",
                            Iso3Code = "MEX",
                            IsoCode = "MX",
                            Name = "Mexico",
                            NumericCode = (short)484,
                            PhoneCode = (short)52
                        });
                });

            modelBuilder.Entity("AmritaDb.Tipsy.Domain.Universal.PaymentMode", b =>
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

                    b.ToTable("payment_mode", "universal");

                    b.ToTable(tb => tb.IsTemporal(ttb =>
                            {
                                ttb.UseHistoryTable("payment_mode_history", "universal");
                                ttb
                                    .HasPeriodStart("valid_from")
                                    .HasColumnName("valid_from");
                                ttb
                                    .HasPeriodEnd("valid_to")
                                    .HasColumnName("valid_to");
                            }));

                    b.HasData(
                        new
                        {
                            Id = "01H7PCVP1HGHM93SX4HSW8EM2B",
                            Description = "Cash",
                            Name = "Cash"
                        },
                        new
                        {
                            Id = "01H7PCVQ1ERMXJJND16HKKHTKQ",
                            Description = "Cheque / Check",
                            Name = "Cheque"
                        },
                        new
                        {
                            Id = "01H7PCVR0R9723KKDRKGSRPRYS",
                            Description = "Wire Transfer",
                            Name = "Wire Transfer"
                        },
                        new
                        {
                            Id = "01H7PCVS01J4ZANSQHEKV658H1",
                            Description = "Credit Card",
                            Name = "Credit Card"
                        });
                });

            modelBuilder.Entity("AmritaDb.Tipsy.Domain.Universal.State", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(26)
                        .HasColumnType("varchar(26)")
                        .HasColumnName("id");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("char(5)")
                        .HasColumnName("code");

                    b.Property<string>("CountryId")
                        .IsRequired()
                        .HasMaxLength(26)
                        .HasColumnType("varchar(26)")
                        .HasColumnName("country_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)")
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

                    b.HasIndex("CountryId");

                    b.ToTable("state", "universal");

                    b.ToTable(tb => tb.IsTemporal(ttb =>
                            {
                                ttb.UseHistoryTable("state_history", "universal");
                                ttb
                                    .HasPeriodStart("valid_from")
                                    .HasColumnName("valid_from");
                                ttb
                                    .HasPeriodEnd("valid_to")
                                    .HasColumnName("valid_to");
                            }));
                });

            modelBuilder.Entity("AmritaDb.Tipsy.Domain.Stock.Category", b =>
                {
                    b.HasOne("AmritaDb.Tipsy.Domain.Stock.Category", "ParentCategory")
                        .WithMany("Children")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("ParentCategory");
                });

            modelBuilder.Entity("AmritaDb.Tipsy.Domain.Stock.Product", b =>
                {
                    b.HasOne("AmritaDb.Tipsy.Domain.Stock.ProductType", "ProductType")
                        .WithMany("Products")
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("AmritaDb.Tipsy.Domain.Stock.ProductImage", b =>
                {
                    b.HasOne("AmritaDb.Tipsy.Domain.Stock.Product", "Product")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("AmritaDb.Tipsy.Domain.Stock.ProductType", b =>
                {
                    b.HasOne("AmritaDb.Tipsy.Domain.Stock.Category", "Category")
                        .WithMany("ProductTypes")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("AmritaDb.Tipsy.Domain.Universal.State", b =>
                {
                    b.HasOne("AmritaDb.Tipsy.Domain.Universal.Country", "Country")
                        .WithMany("States")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("AmritaDb.Tipsy.Domain.Stock.Category", b =>
                {
                    b.Navigation("Children");

                    b.Navigation("ProductTypes");
                });

            modelBuilder.Entity("AmritaDb.Tipsy.Domain.Stock.Product", b =>
                {
                    b.Navigation("ProductImages");
                });

            modelBuilder.Entity("AmritaDb.Tipsy.Domain.Stock.ProductType", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("AmritaDb.Tipsy.Domain.Universal.Country", b =>
                {
                    b.Navigation("States");
                });
#pragma warning restore 612, 618
        }
    }
}
