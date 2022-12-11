﻿// <auto-generated />
using System;
using Bazaar.DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bazaar.DAL.Migrations
{
    [DbContext(typeof(BazaarDBContext))]
    partial class BazaarDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Bazaar.DAL.Models.Ad", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsOffer")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPremium")
                        .HasColumnType("bit");

                    b.Property<bool>("IsValid")
                        .HasColumnType("bit");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid?>("UserId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Ad");

                    b.HasData(
                        new
                        {
                            Id = new Guid("69c041b0-a5b7-4842-ac77-be0e245d1cd1"),
                            Description = "Je velmi zlata, zbavte ma jej, prosim",
                            IsOffer = true,
                            IsPremium = false,
                            IsValid = true,
                            Price = 50,
                            Title = "Predam macku",
                            UserId = new Guid("b45ccbe5-e3ae-4d08-bf76-330419c25959")
                        });
                });

            modelBuilder.Entity("Bazaar.DAL.Models.AdTag", b =>
                {
                    b.Property<Guid>("TagId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AdId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("TagId", "AdId");

                    b.HasIndex("AdId");

                    b.ToTable("AdTag");
                });

            modelBuilder.Entity("Bazaar.DAL.Models.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AdId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AdId");

                    b.ToTable("Image");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d120bc1d-fe97-4161-bcc2-4539f0c92f5a"),
                            AdId = new Guid("69c041b0-a5b7-4842-ac77-be0e245d1cd1"),
                            Title = "Milovana macka",
                            Url = "\\obrazokmacky.jpg"
                        });
                });

            modelBuilder.Entity("Bazaar.DAL.Models.Reaction", b =>
                {
                    b.Property<Guid>("AdId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Accepted")
                        .HasColumnType("bit");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Rejected")
                        .HasColumnType("bit");

                    b.Property<bool>("Reviewed")
                        .HasColumnType("bit");

                    b.HasKey("AdId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Reaction");

                    b.HasData(
                        new
                        {
                            AdId = new Guid("69c041b0-a5b7-4842-ac77-be0e245d1cd1"),
                            UserId = new Guid("ec64bd2c-79ca-4624-b077-599aa418ecac"),
                            Accepted = true,
                            Id = new Guid("00000000-0000-0000-0000-000000000000"),
                            Message = "Mam zaujem o vasu prekrasnu macku",
                            Rejected = false,
                            Reviewed = false
                        });
                });

            modelBuilder.Entity("Bazaar.DAL.Models.Review", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AdId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descritption")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ReviewedId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ReviewerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AdId");

                    b.HasIndex("ReviewedId");

                    b.HasIndex("ReviewerId");

                    b.ToTable("Review");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e42f5477-9bea-4936-bfd8-3a3cc4d2361d"),
                            AdId = new Guid("69c041b0-a5b7-4842-ac77-be0e245d1cd1"),
                            Descritption = "Krasna macka, 10/10 spokojnost",
                            ReviewedId = new Guid("b45ccbe5-e3ae-4d08-bf76-330419c25959"),
                            ReviewerId = new Guid("ec64bd2c-79ca-4624-b077-599aa418ecac"),
                            Score = 5
                        });
                });

            modelBuilder.Entity("Bazaar.DAL.Models.Tag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TagName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("Id");

                    b.ToTable("Tag");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8056ebb5-9fd6-433c-b28d-5533e14b6a3f"),
                            TagName = "Animals"
                        },
                        new
                        {
                            Id = new Guid("f8de57a3-befa-48ee-ad1f-51b719261801"),
                            TagName = "Sell"
                        });
                });

            modelBuilder.Entity("Bazaar.DAL.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Banned")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<bool>("HasPremium")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b45ccbe5-e3ae-4d08-bf76-330419c25959"),
                            Banned = false,
                            Email = "jozko@gmailol.com",
                            FirstName = "Jozko",
                            HasPremium = false,
                            LastName = "Mrkvicka",
                            Level = 0,
                            PhoneNumber = "0000000",
                            UserName = "TestUser"
                        },
                        new
                        {
                            Id = new Guid("ec64bd2c-79ca-4624-b077-599aa418ecac"),
                            Banned = false,
                            Email = "ferko@gmailol.com",
                            FirstName = "Ferko",
                            HasPremium = false,
                            LastName = "Priezviskovy",
                            Level = 0,
                            PhoneNumber = "2020040444",
                            UserName = "Feri"
                        });
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

            modelBuilder.Entity("Bazaar.DAL.Models.Ad", b =>
                {
                    b.HasOne("Bazaar.DAL.Models.User", "Creator")
                        .WithMany("Ads")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("Bazaar.DAL.Models.AdTag", b =>
                {
                    b.HasOne("Bazaar.DAL.Models.Ad", "Ad")
                        .WithMany("AdTags")
                        .HasForeignKey("AdId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Bazaar.DAL.Models.Tag", "Tag")
                        .WithMany("AdTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ad");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("Bazaar.DAL.Models.Image", b =>
                {
                    b.HasOne("Bazaar.DAL.Models.Ad", "Ad")
                        .WithMany("Images")
                        .HasForeignKey("AdId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Ad");
                });

            modelBuilder.Entity("Bazaar.DAL.Models.Reaction", b =>
                {
                    b.HasOne("Bazaar.DAL.Models.Ad", "Ad")
                        .WithMany("Reactions")
                        .HasForeignKey("AdId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Bazaar.DAL.Models.User", "User")
                        .WithMany("Reactions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Ad");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Bazaar.DAL.Models.Review", b =>
                {
                    b.HasOne("Bazaar.DAL.Models.Ad", "Ad")
                        .WithMany()
                        .HasForeignKey("AdId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Bazaar.DAL.Models.User", "Reviewed")
                        .WithMany("ReviewedIn")
                        .HasForeignKey("ReviewedId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Bazaar.DAL.Models.User", "Reviewer")
                        .WithMany("ReviewerIn")
                        .HasForeignKey("ReviewerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Ad");

                    b.Navigation("Reviewed");

                    b.Navigation("Reviewer");
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

            modelBuilder.Entity("Bazaar.DAL.Models.Ad", b =>
                {
                    b.Navigation("AdTags");

                    b.Navigation("Images");

                    b.Navigation("Reactions");
                });

            modelBuilder.Entity("Bazaar.DAL.Models.Tag", b =>
                {
                    b.Navigation("AdTags");
                });

            modelBuilder.Entity("Bazaar.DAL.Models.User", b =>
                {
                    b.Navigation("Ads");

                    b.Navigation("Reactions");

                    b.Navigation("ReviewedIn");

                    b.Navigation("ReviewerIn");
                });
#pragma warning restore 612, 618
        }
    }
}
