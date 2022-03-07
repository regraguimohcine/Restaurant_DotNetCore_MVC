﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Restaurant_DotnetCoreMvc.Models;

namespace Restaurant_DotnetCoreMvc.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Restaurant_DotnetCoreMvc.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Restaurant_DotnetCoreMvc.Models.Pie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsPieOfTheWeek")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Pies");
                });

            modelBuilder.Entity("Restaurant_DotnetCoreMvc.Models.ShopingCardItem", b =>
                {
                    b.Property<int>("ShopingCardItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Amount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PieId")
                        .HasColumnType("int");

                    b.Property<string>("ShopingCardId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShopingCardItemId");

                    b.HasIndex("PieId");

                    b.ToTable("ShopingCards");
                });

            modelBuilder.Entity("Restaurant_DotnetCoreMvc.Models.Pie", b =>
                {
                    b.HasOne("Restaurant_DotnetCoreMvc.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Restaurant_DotnetCoreMvc.Models.ShopingCardItem", b =>
                {
                    b.HasOne("Restaurant_DotnetCoreMvc.Models.Pie", "Pie")
                        .WithMany()
                        .HasForeignKey("PieId");

                    b.Navigation("Pie");
                });
#pragma warning restore 612, 618
        }
    }
}