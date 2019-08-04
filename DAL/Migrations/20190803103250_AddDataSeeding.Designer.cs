﻿// <auto-generated />
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20190803103250_AddDataSeeding")]
    partial class AddDataSeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DAL.Entities.Company", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 1L
                        },
                        new
                        {
                            Id = 2L
                        },
                        new
                        {
                            Id = 3L
                        });
                });

            modelBuilder.Entity("DAL.Entities.Customer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1L
                        },
                        new
                        {
                            Id = 2L
                        },
                        new
                        {
                            Id = 3L
                        });
                });

            modelBuilder.Entity("DAL.Entities.Deal", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CustomerId");

                    b.Property<int>("ProductAmount");

                    b.Property<long>("ProductId");

                    b.Property<long>("SellerId");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.HasIndex("SellerId");

                    b.ToTable("Deals");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CustomerId = 1L,
                            ProductAmount = 1,
                            ProductId = 1L,
                            SellerId = 1L
                        },
                        new
                        {
                            Id = 2L,
                            CustomerId = 2L,
                            ProductAmount = 2,
                            ProductId = 2L,
                            SellerId = 2L
                        },
                        new
                        {
                            Id = 3L,
                            CustomerId = 3L,
                            ProductAmount = 3,
                            ProductId = 3L,
                            SellerId = 3L
                        });
                });

            modelBuilder.Entity("DAL.Entities.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1L
                        },
                        new
                        {
                            Id = 2L
                        },
                        new
                        {
                            Id = 3L
                        });
                });

            modelBuilder.Entity("DAL.Entities.Seller", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CompanyId");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Sellers");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CompanyId = 1L
                        },
                        new
                        {
                            Id = 2L,
                            CompanyId = 2L
                        },
                        new
                        {
                            Id = 3L,
                            CompanyId = 3L
                        });
                });

            modelBuilder.Entity("DAL.Entities.Deal", b =>
                {
                    b.HasOne("DAL.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Entities.Product", "Product")
                        .WithMany("SellerCustomers")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Entities.Seller", "Seller")
                        .WithMany()
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Entities.Seller", b =>
                {
                    b.HasOne("DAL.Entities.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
