﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SalesReporter.DataLayer;

namespace SalesReporter.DataLayer.Migrations
{
    [DbContext(typeof(SalesReporterContext))]
    [Migration("20210809234030_UpdateSuppliers")]
    partial class UpdateSuppliers
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SalesReporter.Models.Category", b =>
                {
                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("SalesReporter.Models.Customer", b =>
                {
                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("SalesReporter.Models.Order", b =>
                {
                    b.Property<string>("OrderId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("OrderFulfilled")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipperId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ShipperId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("SalesReporter.Models.OrderDetail", b =>
                {
                    b.Property<string>("OrderDetailId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("OrderId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("SalesReporter.Models.Product", b =>
                {
                    b.Property<string>("ProductId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplierId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("SalesReporter.Models.Shipper", b =>
                {
                    b.Property<string>("ShipperId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShipperId");

                    b.ToTable("Shippers");
                });

            modelBuilder.Entity("SalesReporter.Models.Supplier", b =>
                {
                    b.Property<string>("SupplierId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SupplierId");

                    b.ToTable("Suppliers");

                    b.HasData(
                        new
                        {
                            SupplierId = "4502bdb5-e121-4d79-a66a-1766880c882b",
                            City = "Topaz",
                            CompanyName = "Sloganaut",
                            Country = "Western Sahara",
                            Phone = "(812) 596-3786",
                            PostalCode = "35856",
                            State = "North Carolina"
                        },
                        new
                        {
                            SupplierId = "30eb03f2-1a33-43b0-b300-0d35918977e9",
                            City = "Fairlee",
                            CompanyName = "Confrenzy",
                            Country = "Liberia",
                            Phone = "(994) 417-3976",
                            PostalCode = "35859",
                            State = "Massachusetts"
                        },
                        new
                        {
                            SupplierId = "2613956c-7b0d-4ffe-a1a2-c7d007a2c34d",
                            City = "Waterview",
                            CompanyName = "Letpro",
                            Country = "Croatia (Hrvatska)",
                            Phone = "(879) 589-2032",
                            PostalCode = "35856",
                            State = "Kentucky"
                        },
                        new
                        {
                            SupplierId = "ce7f06b1-af75-4341-95b3-9b7c13cea42c",
                            City = "Bentonville",
                            CompanyName = "Portica",
                            Country = "Belgium",
                            Phone = "(878) 471-2173",
                            PostalCode = "35866",
                            State = "Colorado"
                        },
                        new
                        {
                            SupplierId = "11b51e93-f79e-43c5-a365-5ae6e3873e41",
                            City = "Crumpler",
                            CompanyName = "Comveyor",
                            Country = "Marshall Islands",
                            Phone = "(905) 514-2447",
                            PostalCode = "35056",
                            State = "Iowa"
                        },
                        new
                        {
                            SupplierId = "accae86b-e16a-4c64-a277-8e517660d415",
                            City = "Odessa",
                            CompanyName = "Intrawear",
                            Country = "Australia",
                            Phone = "(911) 498-3277",
                            PostalCode = "35856",
                            State = "Arkansas"
                        },
                        new
                        {
                            SupplierId = "c2bacd1f-4c88-453c-bc2c-21551396069a",
                            City = "Malo",
                            CompanyName = "Qualitex",
                            Country = "Latvia",
                            Phone = "(863) 502-2069",
                            PostalCode = "35858",
                            State = "New Hampshire"
                        },
                        new
                        {
                            SupplierId = "ef5c9a0f-d475-45f5-8eda-279019a4ff13",
                            City = "Nord",
                            CompanyName = "Frenex",
                            Country = "Cocos (Keeling Islands)",
                            Phone = "(969) 576-3650",
                            PostalCode = "35806",
                            State = "Puerto Rico"
                        },
                        new
                        {
                            SupplierId = "e67beab4-9126-437c-bf35-cc53eaae055c",
                            City = "Turah",
                            CompanyName = "Isosphere",
                            Country = "Zimbabwe",
                            Phone = "(913) 536-3166",
                            PostalCode = "35886",
                            State = "Marshall Islands"
                        },
                        new
                        {
                            SupplierId = "222e4f5f-fe2b-4e55-a50a-0671f5d9a2fa",
                            City = "Islandia",
                            CompanyName = "Futurity",
                            Country = "Malaysia",
                            Phone = "(951) 584-3833",
                            PostalCode = "35806",
                            State = "Georgia"
                        });
                });

            modelBuilder.Entity("SalesReporter.Models.Order", b =>
                {
                    b.HasOne("SalesReporter.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId");

                    b.HasOne("SalesReporter.Models.Shipper", "Shipper")
                        .WithMany("Order")
                        .HasForeignKey("ShipperId");

                    b.Navigation("Customer");

                    b.Navigation("Shipper");
                });

            modelBuilder.Entity("SalesReporter.Models.OrderDetail", b =>
                {
                    b.HasOne("SalesReporter.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId");

                    b.HasOne("SalesReporter.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("SalesReporter.Models.Product", b =>
                {
                    b.HasOne("SalesReporter.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");

                    b.HasOne("SalesReporter.Models.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierId");

                    b.Navigation("Category");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("SalesReporter.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("SalesReporter.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("SalesReporter.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("SalesReporter.Models.Shipper", b =>
                {
                    b.Navigation("Order");
                });

            modelBuilder.Entity("SalesReporter.Models.Supplier", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
