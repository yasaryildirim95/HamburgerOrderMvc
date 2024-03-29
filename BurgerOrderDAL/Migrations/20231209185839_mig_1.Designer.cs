﻿// <auto-generated />
using System;
using BurgerOrderDAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BurgerOrderDAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231209185839_mig_1")]
    partial class mig_1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BurgerOrderEntity.Concrete.AppRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("DataStatusEnum")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "79901907-1862-463c-8513-184d6322e984",
                            ConcurrencyStamp = "9dc30439-6b0b-4e52-b2cd-35bb146342c7",
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataStatusEnum = 0,
                            Name = "User"
                        },
                        new
                        {
                            Id = "7b5184c4-13c4-4ec7-be5b-184d7b99e70a",
                            ConcurrencyStamp = "51215c3b-32c5-421d-bd86-43ca454c44b4",
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataStatusEnum = 0,
                            Name = "Admin"
                        });
                });

            modelBuilder.Entity("BurgerOrderEntity.Concrete.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("DataStatusEnum")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("SurName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

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

                    b.HasData(
                        new
                        {
                            Id = "461c9a2d-3d57-49e1-a7b6-10e698229b1a",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a6136d56-572c-402f-b63d-256373196227",
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataStatusEnum = 0,
                            Email = "admin@hotmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Name = "Admin",
                            PasswordHash = "AQAAAAEAACcQAAAAEFUfQPU95XrAkhC/g/PfjMcU9S8xTJbqSI33JRtoB7g1Pv62VgsWKSVUlt+/8SPNPQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a6a23966-d1b8-4a3f-9b91-3ee39636b5a2",
                            SurName = "Admin",
                            TwoFactorEnabled = false,
                            UserName = "Admin"
                        });
                });

            modelBuilder.Entity("BurgerOrderEntity.Concrete.Extra", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("DataStatusEnum")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Extra");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Created = new DateTime(2023, 12, 9, 21, 58, 39, 421, DateTimeKind.Local).AddTicks(8387),
                            DataStatusEnum = 0,
                            Name = "Ranch Sos",
                            Price = 10
                        },
                        new
                        {
                            Id = "2",
                            Created = new DateTime(2023, 12, 9, 21, 58, 39, 421, DateTimeKind.Local).AddTicks(8473),
                            DataStatusEnum = 0,
                            Name = "Barbekü Sos",
                            Price = 10
                        },
                        new
                        {
                            Id = "3",
                            Created = new DateTime(2023, 12, 9, 21, 58, 39, 421, DateTimeKind.Local).AddTicks(8493),
                            DataStatusEnum = 0,
                            Name = "Ballı Hardal Sos",
                            Price = 10
                        });
                });

            modelBuilder.Entity("BurgerOrderEntity.Concrete.Menu", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("DataStatusEnum")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Domates")
                        .HasColumnType("bit");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Ketcap")
                        .HasColumnType("bit");

                    b.Property<bool>("Marul")
                        .HasColumnType("bit");

                    b.Property<bool>("Mayonez")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PriceForMedium")
                        .HasColumnType("int");

                    b.Property<bool>("Sogan")
                        .HasColumnType("bit");

                    b.Property<bool>("Tursu")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Menus");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Created = new DateTime(2023, 12, 9, 21, 58, 39, 420, DateTimeKind.Local).AddTicks(4282),
                            DataStatusEnum = 0,
                            Description = "Izgara ateeşinde muazzam whohoper köftesi patates ve içecekle servis edilir.",
                            Domates = true,
                            ImageURL = "https://cdn.yemek.com/mnresize/940/940/uploads/2022/05/hamburger-yemekcom.jpg",
                            Ketcap = false,
                            Marul = true,
                            Mayonez = false,
                            Name = "Whooper",
                            PriceForMedium = 100,
                            Sogan = false,
                            Tursu = false
                        },
                        new
                        {
                            Id = "2",
                            Created = new DateTime(2023, 12, 9, 21, 58, 39, 420, DateTimeKind.Local).AddTicks(4345),
                            DataStatusEnum = 0,
                            Description = "Izgara ateeşinde olmayan Kötü Hamburhger",
                            Domates = true,
                            ImageURL = "https://cdn.yemek.com/mnresize/940/940/uploads/2022/05/hamburger-yemekcom.jpg",
                            Ketcap = false,
                            Marul = false,
                            Mayonez = false,
                            Name = "BigKing",
                            PriceForMedium = 120,
                            Sogan = false,
                            Tursu = true
                        },
                        new
                        {
                            Id = "3",
                            Created = new DateTime(2023, 12, 9, 21, 58, 39, 420, DateTimeKind.Local).AddTicks(4363),
                            DataStatusEnum = 0,
                            Description = "Mikrodalgada tavuk burger",
                            Domates = true,
                            ImageURL = "https://cdn.yemek.com/mnresize/940/940/uploads/2022/05/hamburger-yemekcom.jpg",
                            Ketcap = false,
                            Marul = false,
                            Mayonez = false,
                            Name = "ChikenRoyal",
                            PriceForMedium = 60,
                            Sogan = true,
                            Tursu = false
                        });
                });

            modelBuilder.Entity("BurgerOrderEntity.Concrete.Order", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("AppUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("DataStatusEnum")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Domates")
                        .HasColumnType("bit");

                    b.Property<bool>("Ketcap")
                        .HasColumnType("bit");

                    b.Property<bool>("Marul")
                        .HasColumnType("bit");

                    b.Property<bool>("Mayonez")
                        .HasColumnType("bit");

                    b.Property<string>("MenuId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductSizeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Sogan")
                        .HasColumnType("bit");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Tursu")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("MenuId");

                    b.HasIndex("ProductSizeId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BurgerOrderEntity.Concrete.ProductSize", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("DataStatusEnum")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PriceMultiplier")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ProductSize");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Created = new DateTime(2023, 12, 9, 21, 58, 39, 420, DateTimeKind.Local).AddTicks(4392),
                            DataStatusEnum = 0,
                            Name = "Small",
                            PriceMultiplier = 0.9m
                        },
                        new
                        {
                            Id = "2",
                            Created = new DateTime(2023, 12, 9, 21, 58, 39, 420, DateTimeKind.Local).AddTicks(4410),
                            DataStatusEnum = 0,
                            Name = "Medium",
                            PriceMultiplier = 1m
                        },
                        new
                        {
                            Id = "3",
                            Created = new DateTime(2023, 12, 9, 21, 58, 39, 420, DateTimeKind.Local).AddTicks(4424),
                            DataStatusEnum = 0,
                            Name = "Large",
                            PriceMultiplier = 1.2m
                        },
                        new
                        {
                            Id = "4",
                            Created = new DateTime(2023, 12, 9, 21, 58, 39, 420, DateTimeKind.Local).AddTicks(4436),
                            DataStatusEnum = 0,
                            Name = "Mega",
                            PriceMultiplier = 1.5m
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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

                    b.HasData(
                        new
                        {
                            UserId = "461c9a2d-3d57-49e1-a7b6-10e698229b1a",
                            RoleId = "7b5184c4-13c4-4ec7-be5b-184d7b99e70a"
                        });
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

            modelBuilder.Entity("BurgerOrderEntity.Concrete.Order", b =>
                {
                    b.HasOne("BurgerOrderEntity.Concrete.AppUser", "AppUser")
                        .WithMany("Orders")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BurgerOrderEntity.Concrete.Menu", "Menu")
                        .WithMany("Orders")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BurgerOrderEntity.Concrete.ProductSize", "ProductSize")
                        .WithMany()
                        .HasForeignKey("ProductSizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");

                    b.Navigation("Menu");

                    b.Navigation("ProductSize");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("BurgerOrderEntity.Concrete.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("BurgerOrderEntity.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BurgerOrderEntity.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("BurgerOrderEntity.Concrete.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BurgerOrderEntity.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BurgerOrderEntity.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BurgerOrderEntity.Concrete.AppUser", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("BurgerOrderEntity.Concrete.Menu", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
