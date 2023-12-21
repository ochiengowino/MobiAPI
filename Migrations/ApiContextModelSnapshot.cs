﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MobiAPI.Context;

#nullable disable

namespace MobiAPI.Migrations
{
    [DbContext(typeof(ApiContext))]
    partial class ApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MobiAPI.Models.NavTransactions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Application_Date")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Approved_Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Captured_By")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Global_Dimension_1_Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Global_Dimension_2_Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Interest")
                        .HasColumnType("int");

                    b.Property<string>("Loan_No")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Loan_Product_Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Loan_Product_Type_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Member_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Member_No")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Requested_Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Staff_No")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TransactonsNav");
                });

            modelBuilder.Entity("MobiAPI.Models.Transactions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AcctNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("BookedBalance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ClearedBalance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustMemoLine1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EventType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExchangeRate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Narration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Narration2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Narration3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentRef")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TransactionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CustomerTransactions");
                });
#pragma warning restore 612, 618
        }
    }
}
