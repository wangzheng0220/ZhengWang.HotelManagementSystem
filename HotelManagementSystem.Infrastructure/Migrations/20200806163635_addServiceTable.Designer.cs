﻿// <auto-generated />
using System;
using HotelManagementSystem.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HotelManagementSystem.Infrastructure.Migrations
{
    [DbContext(typeof(HotelManagementSystemDbContext))]
    [Migration("20200806163635_addServiceTable")]
    partial class addServiceTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HotelManagementSystem.Core.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<decimal>("Advance")
                        .HasColumnType("decimal(18,4)");

                    b.Property<int>("Bookingdays")
                        .HasColumnType("int");

                    b.Property<DateTime>("Checkin")
                        .HasColumnType("datetime2");

                    b.Property<string>("Cname")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<int>("Roomno")
                        .HasColumnType("int");

                    b.Property<int>("TotalPersons")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("HotelManagementSystem.Core.Entities.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Rtcode")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Room");
                });

            modelBuilder.Entity("HotelManagementSystem.Core.Entities.RoomType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RTDESC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Rent")
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("Id");

                    b.ToTable("RoomType");
                });
#pragma warning restore 612, 618
        }
    }
}