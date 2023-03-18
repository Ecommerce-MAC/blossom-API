﻿// <auto-generated />
using System;
using Blosom_API2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlosomAPI2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Blossom_API.Models.Blossom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("ProductDescrip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Blossoms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "Vegan World",
                            DateCreated = new DateTime(2023, 3, 16, 21, 13, 2, 172, DateTimeKind.Local).AddTicks(7028),
                            DateUpdated = new DateTime(2023, 3, 16, 21, 13, 2, 172, DateTimeKind.Local).AddTicks(7082),
                            ImageUrl = "",
                            Name = "CC Organic Cream",
                            Price = 10.0,
                            ProductDescrip = "Product 100% natural",
                            Stock = 100
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Terpenic",
                            DateCreated = new DateTime(2023, 3, 16, 21, 13, 2, 172, DateTimeKind.Local).AddTicks(7087),
                            DateUpdated = new DateTime(2023, 3, 16, 21, 13, 2, 172, DateTimeKind.Local).AddTicks(7089),
                            ImageUrl = "",
                            Name = "Essential oil lavender",
                            Price = 30.0,
                            ProductDescrip = "Product 100% natural",
                            Stock = 80
                        });
                });
#pragma warning restore 612, 618
        }
    }
}