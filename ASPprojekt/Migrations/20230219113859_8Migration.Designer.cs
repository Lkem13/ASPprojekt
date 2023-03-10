// <auto-generated />
using System;
using ASPprojekt.Areas.Identity.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASPprojekt.Migrations
{
    [DbContext(typeof(ASPDbContext))]
    [Migration("20230219113859_8Migration")]
    partial class _8Migration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ASPprojekt.Areas.Identity.Data.ASPprojektUser", b =>
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

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LocationModel")
                        .HasColumnType("int");

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

                    b.Property<string>("Pesel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<int?>("PositionModel")
                        .HasColumnType("int");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("LocationModel");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("PositionModel");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0220eabd-4f71-433d-8774-b9b9ce612791",
                            Email = "admin@admin.admin",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ADMIN.ADMIN",
                            NormalizedUserName = "ADMIN@ADMIN.ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEHhuwZBaTXqpnAv5JhueCsDBwTcY9CsI13n7N7AVIK5HwYRe34Dvsa2qg78PfgD4Ww==",
                            Pesel = "00000000000",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "91ff8f78-486c-493c-acd1-c1fdb92964b8",
                            TwoFactorEnabled = false,
                            UserName = "admin@admin.admin"
                        },
                        new
                        {
                            Id = "8e445865-a24d-4543-a6c6-9443d048cdb8",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0cf0b320-e54d-469d-93ad-282be6487e2b",
                            Email = "user@user.user",
                            EmailConfirmed = true,
                            FirstName = "User",
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "USER@USER.USER",
                            NormalizedUserName = "USER@USER.USER",
                            PasswordHash = "AQAAAAEAACcQAAAAEPPYeeLpZjmYRkPYCmApp/6ej73ZtW33c1V8oUG+SJusoARcpRNLKg4Xy0PfAKI/Cw==",
                            Pesel = "11111111111",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "020799c9-fa82-482f-8a43-b95ca09ebe54",
                            TwoFactorEnabled = false,
                            UserName = "user@user.user"
                        },
                        new
                        {
                            Id = "8e445865-a24d-4543-a6c6-9443d048cdb7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1c4766d9-b8db-4fd6-97a1-7a27410e648a",
                            Email = "user2@user.user",
                            EmailConfirmed = true,
                            FirstName = "User2",
                            LastName = "User2",
                            LockoutEnabled = false,
                            NormalizedEmail = "USER2@USER.USER",
                            NormalizedUserName = "USER2@USER.USER",
                            PasswordHash = "AQAAAAEAACcQAAAAEJV0SE0RCrOOxwZy3LlpY4DGebez20UCQMlzNZatOr+ronmhvT3R1Y/oIIu8AuYGKw==",
                            Pesel = "11111111112",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d782ddb4-3498-4c3f-8479-ac28295fca1c",
                            TwoFactorEnabled = false,
                            UserName = "user2@user.user"
                        },
                        new
                        {
                            Id = "8e445865-a24d-4543-a6c6-9443d048cdb6",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "668f8372-0c7a-4721-bf5f-b2fba5fa0642",
                            Email = "user23user.user",
                            EmailConfirmed = true,
                            FirstName = "User3",
                            LastName = "User3",
                            LockoutEnabled = false,
                            NormalizedEmail = "USER3@USER.USER",
                            NormalizedUserName = "USER3@USER.USER",
                            PasswordHash = "AQAAAAEAACcQAAAAEPh7kxlR9obw+bMc7XAfS+xAHUKQYa4jV66qo0wJwO0s76HeiNws2SJ5aoxLMf+DKw==",
                            Pesel = "11111111113",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "db5b750d-a9b1-40d7-9dca-81e17b3a02fe",
                            TwoFactorEnabled = false,
                            UserName = "user3@user.user"
                        });
                });

            modelBuilder.Entity("ASPprojekt.Areas.Identity.Data.LocationModel", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LocationId"), 1L, 1);

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Town")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            LocationId = 1,
                            Street = "Karmelicka",
                            Town = "Krakow"
                        },
                        new
                        {
                            LocationId = 2,
                            Street = "Brzozowa",
                            Town = "Warszawa"
                        });
                });

            modelBuilder.Entity("ASPprojekt.Areas.Identity.Data.PlanModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ASPprojektUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("ShiftDay")
                        .HasColumnType("datetime2");

                    b.Property<int>("ShiftEnd")
                        .HasColumnType("int");

                    b.Property<int>("ShiftStart")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ASPprojektUserId");

                    b.ToTable("PlanModels");
                });

            modelBuilder.Entity("ASPprojekt.Areas.Identity.Data.PositionModel", b =>
                {
                    b.Property<int>("PositionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PositionId"), 1L, 1);

                    b.Property<string>("PositionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PositionId");

                    b.ToTable("Positions");

                    b.HasData(
                        new
                        {
                            PositionId = 1,
                            PositionName = "Brak"
                        },
                        new
                        {
                            PositionId = 2,
                            PositionName = "Front Desk"
                        },
                        new
                        {
                            PositionId = 3,
                            PositionName = "Chef"
                        },
                        new
                        {
                            PositionId = 4,
                            PositionName = "Cook"
                        },
                        new
                        {
                            PositionId = 5,
                            PositionName = "Hotel Manager"
                        },
                        new
                        {
                            PositionId = 6,
                            PositionName = "Maid"
                        },
                        new
                        {
                            PositionId = 7,
                            PositionName = "Barista"
                        },
                        new
                        {
                            PositionId = 8,
                            PositionName = "Waiter"
                        });
                });

            modelBuilder.Entity("ASPprojekt.Areas.Identity.Data.StatusModel", b =>
                {
                    b.Property<int>("StatusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StatusID"), 1L, 1);

                    b.Property<string>("statusType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StatusID");

                    b.ToTable("StatusModel");
                });

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

                    b.HasData(
                        new
                        {
                            Id = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                            ConcurrencyStamp = "ba07699e-4cdf-4fb3-8f80-239beb618069",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2c5e174e-3b0e-446f-86af-483d56fd7211",
                            ConcurrencyStamp = "58713ba7-4c6a-4941-9756-99a89e1c0a01",
                            Name = "User",
                            NormalizedName = "USER"
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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

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
                            UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                            RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210"
                        },
                        new
                        {
                            UserId = "8e445865-a24d-4543-a6c6-9443d048cdb8",
                            RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7211"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ASPprojekt.Areas.Identity.Data.ASPprojektUser", b =>
                {
                    b.HasOne("ASPprojekt.Areas.Identity.Data.LocationModel", "Location")
                        .WithMany()
                        .HasForeignKey("LocationModel");

                    b.HasOne("ASPprojekt.Areas.Identity.Data.PositionModel", "Position")
                        .WithMany("Users")
                        .HasForeignKey("PositionModel");

                    b.Navigation("Location");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("ASPprojekt.Areas.Identity.Data.PlanModel", b =>
                {
                    b.HasOne("ASPprojekt.Areas.Identity.Data.ASPprojektUser", "ASPprojektUser")
                        .WithMany()
                        .HasForeignKey("ASPprojektUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ASPprojektUser");
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
                    b.HasOne("ASPprojekt.Areas.Identity.Data.ASPprojektUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ASPprojekt.Areas.Identity.Data.ASPprojektUser", null)
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

                    b.HasOne("ASPprojekt.Areas.Identity.Data.ASPprojektUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ASPprojekt.Areas.Identity.Data.ASPprojektUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ASPprojekt.Areas.Identity.Data.PositionModel", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
