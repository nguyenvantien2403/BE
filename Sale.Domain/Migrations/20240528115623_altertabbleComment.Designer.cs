﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sale.Domain;

#nullable disable

namespace Sale.Domain.Migrations
{
    [DbContext(typeof(SaleContext))]
    [Migration("20240528115623_altertabbleComment")]
    partial class altertabbleComment
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Sale.Domain.Entities.Branch", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BranchName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DeleteBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("DeleteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatedID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Branchs");
                });

            modelBuilder.Entity("Sale.Domain.Entities.Cart", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CartId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DeleteBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("DeleteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("PromotionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatedID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("count")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("Sale.Domain.Entities.Comments", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DeleteBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("DeleteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatedID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userPost")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Sale.Domain.Entities.FileImage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DeleteBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("DeleteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatedID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("extension")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("fileSize")
                        .HasColumnType("float");

                    b.Property<string>("mime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("Sale.Domain.Entities.NotifiCation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DeleteBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("DeleteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<Guid?>("SendUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatedID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("NotifiCations");
                });

            modelBuilder.Entity("Sale.Domain.Entities.Orders", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DeleteBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("DeleteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ShippingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatedID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("orderNotes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("totalPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Sale.Domain.Entities.Origin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DeleteBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("DeleteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("OriginName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatedID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Origins");
                });

            modelBuilder.Entity("Sale.Domain.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BranchId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DeleteBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("DeleteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<Guid?>("OriginId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("ProdcutPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductMaterial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductQuanlity")
                        .HasColumnType("int");

                    b.Property<int?>("ProductSold")
                        .HasColumnType("int");

                    b.Property<string>("ProductType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatedID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("comment")
                        .HasColumnType("int");

                    b.Property<int?>("rate")
                        .HasColumnType("int");

                    b.Property<int?>("views")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Sale.Domain.Entities.Promotion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DeleteBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("DeleteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<double>("Percent")
                        .HasColumnType("float");

                    b.Property<string>("PromotionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatedID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("isPublic")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Promotions");
                });

            modelBuilder.Entity("Sale.Domain.Entities.Rate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DeleteBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("DeleteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("RateQuanlity")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatedID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Rates");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sale.Domain.Entities.Cart", b =>
                {
                    b.HasOne("Sale.Domain.Entities.Orders", null)
                        .WithMany("Carts")
                        .HasForeignKey("CartId");
                });

            modelBuilder.Entity("Sale.Domain.Entities.FileImage", b =>
                {
                    b.HasOne("Sale.Domain.Entities.Product", "product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("product");
                });

            modelBuilder.Entity("Sale.Domain.Entities.Orders", b =>
                {
                    b.Navigation("Carts");
                });
#pragma warning restore 612, 618
        }
    }
}
