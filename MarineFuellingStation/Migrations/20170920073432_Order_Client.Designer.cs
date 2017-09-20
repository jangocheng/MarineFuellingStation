﻿// <auto-generated />
using MFS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace MFS.Migrations
{
    [DbContext(typeof(EFContext))]
    [Migration("20170920073432_Order_Client")]
    partial class Order_Client
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MFS.Models.Assay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AssayType");

                    b.Property<string>("Assayer");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<bool>("IsUse");

                    b.Property<DateTime>("LastUpdatedAt");

                    b.Property<string>("LastUpdatedBy");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<decimal>("Percentage10");

                    b.Property<decimal>("Percentage50");

                    b.Property<decimal>("Percentage90");

                    b.Property<int?>("PurchaseId");

                    b.Property<int>("SmellType");

                    b.Property<int?>("StoreId");

                    b.Property<decimal>("Temperature");

                    b.Property<decimal>("初硫");

                    b.Property<string>("十六烷值");

                    b.Property<decimal>("回流");

                    b.Property<decimal>("干点");

                    b.Property<decimal>("标密");

                    b.Property<string>("混水反应");

                    b.Property<decimal>("视密");

                    b.Property<string>("闭口闪点");

                    b.HasKey("Id");

                    b.HasIndex("PurchaseId");

                    b.HasIndex("StoreId");

                    b.ToTable("Assays");
                });

            modelBuilder.Entity("MFS.Models.BoatClean", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("BillingCompany");

                    b.Property<int>("BillingCount");

                    b.Property<decimal>("BillingPrice");

                    b.Property<string>("CarNo");

                    b.Property<string>("Company");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("EndTime");

                    b.Property<bool>("IsInvoice");

                    b.Property<DateTime>("LastUpdatedAt");

                    b.Property<string>("LastUpdatedBy");

                    b.Property<decimal>("Money");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Phone");

                    b.Property<string>("ResponseId");

                    b.Property<DateTime>("StartTime");

                    b.Property<int>("State");

                    b.Property<decimal>("Tonnage");

                    b.Property<int>("Voyage");

                    b.HasKey("Id");

                    b.ToTable("BoatCleans");
                });

            modelBuilder.Entity("MFS.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<decimal>("Balances");

                    b.Property<string>("CarNo");

                    b.Property<int>("ClientType");

                    b.Property<int?>("CompanyId");

                    b.Property<string>("Contact");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<int?>("DefaultProductId");

                    b.Property<string>("FollowSalesman");

                    b.Property<string>("IdCard");

                    b.Property<DateTime>("LastUpdatedAt");

                    b.Property<string>("LastUpdatedBy");

                    b.Property<decimal>("MaxOnAccount");

                    b.Property<string>("Mobile");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Phone");

                    b.Property<int>("PlaceType");

                    b.Property<decimal>("TotalAmount");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("DefaultProductId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("MFS.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<decimal>("Balances");

                    b.Property<string>("Bank");

                    b.Property<string>("BusinessAccount");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("InvoiceTitle");

                    b.Property<string>("Keyword");

                    b.Property<DateTime>("LastUpdatedAt");

                    b.Property<string>("LastUpdatedBy");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Phone");

                    b.Property<string>("TaxFileNumber");

                    b.Property<int>("TicketType");

                    b.Property<decimal>("TotalAmount");

                    b.HasKey("Id");

                    b.ToTable("Companys");
                });

            modelBuilder.Entity("MFS.Models.InAndOutLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("LastUpdatedAt");

                    b.Property<string>("LastUpdatedBy");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Operators");

                    b.Property<int>("StoreId");

                    b.Property<int>("Type");

                    b.Property<string>("Unit");

                    b.Property<decimal>("Value");

                    b.HasKey("Id");

                    b.HasIndex("StoreId");

                    b.ToTable("InAndOutLogs");
                });

            modelBuilder.Entity("MFS.Models.MoveStore", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<int>("Elapsed");

                    b.Property<DateTime?>("EndTime");

                    b.Property<decimal>("InDensity");

                    b.Property<decimal>("InFact");

                    b.Property<decimal>("InPlan");

                    b.Property<int>("InStoreId");

                    b.Property<int>("InStoreTypeId");

                    b.Property<decimal>("InTemperature");

                    b.Property<DateTime>("LastUpdatedAt");

                    b.Property<string>("LastUpdatedBy");

                    b.Property<string>("Manufacturer");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<decimal>("OutDensity");

                    b.Property<decimal>("OutFact");

                    b.Property<decimal>("OutPlan");

                    b.Property<int>("OutStoreId");

                    b.Property<int>("OutStoreTypeId");

                    b.Property<decimal>("OutTemperature");

                    b.Property<DateTime>("StartTime");

                    b.Property<int>("State");

                    b.HasKey("Id");

                    b.ToTable("MoveStores");
                });

            modelBuilder.Entity("MFS.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BillingCompany");

                    b.Property<int>("BillingCount");

                    b.Property<decimal>("BillingPrice");

                    b.Property<string>("CarNo");

                    b.Property<int?>("ClientId");

                    b.Property<int>("Count");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<decimal>("Density");

                    b.Property<decimal>("DiffOil");

                    b.Property<decimal>("DiffWeight");

                    b.Property<decimal>("EmptyCarWeight");

                    b.Property<string>("EmptyCarWeightPic");

                    b.Property<DateTime?>("EndOilDateTime");

                    b.Property<decimal>("Instrument1");

                    b.Property<decimal>("Instrument2");

                    b.Property<decimal>("Instrument3");

                    b.Property<bool>("IsInvoice");

                    b.Property<bool>("IsTrans");

                    b.Property<DateTime>("LastUpdatedAt");

                    b.Property<string>("LastUpdatedBy");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<decimal>("OilCarWeight");

                    b.Property<string>("OilCarWeightPic");

                    b.Property<decimal>("OilCount");

                    b.Property<decimal>("OilTemperature");

                    b.Property<int>("OrderType");

                    b.Property<int>("PayState");

                    b.Property<decimal>("Price");

                    b.Property<int>("ProductId");

                    b.Property<decimal>("SalesCommission");

                    b.Property<int?>("SalesPlanId");

                    b.Property<DateTime?>("StartOilDateTime");

                    b.Property<int>("State");

                    b.Property<int?>("StoreId");

                    b.Property<int>("TicketType");

                    b.Property<int?>("TransportOrderId");

                    b.Property<string>("Unit");

                    b.Property<string>("Worker");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("ProductId");

                    b.HasIndex("SalesPlanId");

                    b.HasIndex("StoreId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("MFS.Models.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("LastUpdatedAt");

                    b.Property<string>("LastUpdatedBy");

                    b.Property<decimal>("Money");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int?>("OrderId");

                    b.Property<int>("PayTypeId");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("MFS.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<bool>("IsUse");

                    b.Property<decimal>("LastPrice");

                    b.Property<DateTime>("LastUpdatedAt");

                    b.Property<string>("LastUpdatedBy");

                    b.Property<decimal>("MinPrice");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("ProductTypeId");

                    b.HasKey("Id");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("MFS.Models.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("LastUpdatedAt");

                    b.Property<string>("LastUpdatedBy");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("ProductTypes");
                });

            modelBuilder.Entity("MFS.Models.Purchase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("ArrivalTime");

                    b.Property<int?>("AssayId");

                    b.Property<string>("CarNo");

                    b.Property<int>("Count");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("Driver1");

                    b.Property<string>("Driver2");

                    b.Property<string>("IdCard1");

                    b.Property<string>("IdCard2");

                    b.Property<DateTime>("LastUpdatedAt");

                    b.Property<string>("LastUpdatedBy");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Origin");

                    b.Property<string>("Phone1");

                    b.Property<string>("Phone2");

                    b.Property<decimal>("Price");

                    b.Property<int>("ProductId");

                    b.Property<float>("Scale");

                    b.Property<string>("ScalePic");

                    b.Property<float>("ScaleWithCar");

                    b.Property<string>("ScaleWithCarPic");

                    b.Property<DateTime?>("StartTime");

                    b.Property<int>("State");

                    b.Property<string>("TrailerNo");

                    b.HasKey("Id");

                    b.HasIndex("AssayId")
                        .IsUnique()
                        .HasFilter("[AssayId] IS NOT NULL");

                    b.HasIndex("ProductId");

                    b.ToTable("Purchases");
                });

            modelBuilder.Entity("MFS.Models.SalesPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("AuditTime");

                    b.Property<string>("Auditor");

                    b.Property<string>("BillingCompany");

                    b.Property<int>("BillingCount");

                    b.Property<decimal>("BillingPrice");

                    b.Property<string>("CarNo");

                    b.Property<int>("Count");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<bool>("IsInvoice");

                    b.Property<DateTime>("LastUpdatedAt");

                    b.Property<string>("LastUpdatedBy");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<DateTime>("OilDate");

                    b.Property<string>("OilName");

                    b.Property<decimal>("Price");

                    b.Property<int>("ProductId");

                    b.Property<decimal>("Remainder");

                    b.Property<int>("SalesPlanType");

                    b.Property<int>("State");

                    b.Property<string>("Unit");

                    b.HasKey("Id");

                    b.ToTable("SalesPlans");
                });

            modelBuilder.Entity("MFS.Models.Store", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("AvgPrice");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<bool>("IsUse");

                    b.Property<DateTime>("LastSurveyAt");

                    b.Property<DateTime>("LastUpdatedAt");

                    b.Property<string>("LastUpdatedBy");

                    b.Property<decimal>("LastValue");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("StoreClass");

                    b.Property<int>("StoreTypeId");

                    b.Property<decimal>("Value");

                    b.Property<decimal>("Volume");

                    b.HasKey("Id");

                    b.HasIndex("StoreTypeId");

                    b.ToTable("Stores");
                });

            modelBuilder.Entity("MFS.Models.StoreType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("LastUpdatedAt");

                    b.Property<string>("LastUpdatedBy");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("StoreTypes");
                });

            modelBuilder.Entity("MFS.Models.Survey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<decimal>("Density");

                    b.Property<decimal>("Height");

                    b.Property<DateTime>("LastUpdatedAt");

                    b.Property<string>("LastUpdatedBy");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("StoreId");

                    b.Property<decimal>("Temperature");

                    b.HasKey("Id");

                    b.HasIndex("StoreId");

                    b.ToTable("Surveys");
                });

            modelBuilder.Entity("MFS.Models.Assay", b =>
                {
                    b.HasOne("MFS.Models.Purchase", "Purchase")
                        .WithMany()
                        .HasForeignKey("PurchaseId");

                    b.HasOne("MFS.Models.Store", "Store")
                        .WithMany()
                        .HasForeignKey("StoreId");
                });

            modelBuilder.Entity("MFS.Models.Client", b =>
                {
                    b.HasOne("MFS.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.HasOne("MFS.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("DefaultProductId");
                });

            modelBuilder.Entity("MFS.Models.InAndOutLog", b =>
                {
                    b.HasOne("MFS.Models.Store", "Store")
                        .WithMany()
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MFS.Models.Order", b =>
                {
                    b.HasOne("MFS.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId");

                    b.HasOne("MFS.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MFS.Models.SalesPlan", "SalesPlan")
                        .WithMany()
                        .HasForeignKey("SalesPlanId");

                    b.HasOne("MFS.Models.Store", "Store")
                        .WithMany()
                        .HasForeignKey("StoreId");
                });

            modelBuilder.Entity("MFS.Models.Payment", b =>
                {
                    b.HasOne("MFS.Models.Order", "Order")
                        .WithMany("Payments")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("MFS.Models.Product", b =>
                {
                    b.HasOne("MFS.Models.ProductType", "ProductType")
                        .WithMany("Products")
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MFS.Models.Purchase", b =>
                {
                    b.HasOne("MFS.Models.Assay", "Assay")
                        .WithOne()
                        .HasForeignKey("MFS.Models.Purchase", "AssayId");

                    b.HasOne("MFS.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MFS.Models.Store", b =>
                {
                    b.HasOne("MFS.Models.StoreType", "StoreType")
                        .WithMany("Stores")
                        .HasForeignKey("StoreTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MFS.Models.Survey", b =>
                {
                    b.HasOne("MFS.Models.Store", "Store")
                        .WithMany()
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
