﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuickBuy.Repository.Context;

namespace QuickBuy.Repository.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20200106003914_create-db")]
    partial class createdb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("QuickBuy.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(19,4)");

                    b.Property<int?>("RequestItemId");

                    b.HasKey("Id");

                    b.HasIndex("RequestItemId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("QuickBuy.Domain.Entities.Request", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<DateTime>("DeliveryDate");

                    b.Property<int>("NumberHouse");

                    b.Property<int>("PaymentId");

                    b.Property<DateTime>("RequestDate");

                    b.Property<string>("State")
                        .HasMaxLength(100);

                    b.Property<int>("UserId");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.HasIndex("PaymentId");

                    b.HasIndex("UserId");

                    b.ToTable("Request");
                });

            modelBuilder.Entity("QuickBuy.Domain.Entities.RequestItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Amount");

                    b.Property<int>("ProductId");

                    b.Property<int?>("RequestId");

                    b.HasKey("Id");

                    b.HasIndex("RequestId");

                    b.ToTable("RequestItem");
                });

            modelBuilder.Entity("QuickBuy.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("QuickBuy.Domain.ObjectValues.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Payment");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Forma de Pagamento Boleto",
                            Name = "BankSlip"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Forma de Pagamento Cartão de Crédito",
                            Name = "CreditCard"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Forma de Pagamento Deposito",
                            Name = "Deposit"
                        });
                });

            modelBuilder.Entity("QuickBuy.Domain.Entities.Product", b =>
                {
                    b.HasOne("QuickBuy.Domain.Entities.RequestItem")
                        .WithMany("Products")
                        .HasForeignKey("RequestItemId");
                });

            modelBuilder.Entity("QuickBuy.Domain.Entities.Request", b =>
                {
                    b.HasOne("QuickBuy.Domain.ObjectValues.Payment", "Payment")
                        .WithMany()
                        .HasForeignKey("PaymentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("QuickBuy.Domain.Entities.User", "User")
                        .WithMany("Requests")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("QuickBuy.Domain.Entities.RequestItem", b =>
                {
                    b.HasOne("QuickBuy.Domain.Entities.Request")
                        .WithMany("RequestItems")
                        .HasForeignKey("RequestId");
                });
#pragma warning restore 612, 618
        }
    }
}
