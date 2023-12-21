﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MobiAPI.Context;

#nullable disable

namespace MobiAPI.Migrations.Nav
{
    [DbContext(typeof(NavContext))]
    partial class NavContextModelSnapshot : ModelSnapshot
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

                    b.ToTable("NavTransactions");
                });
#pragma warning restore 612, 618
        }
    }
}