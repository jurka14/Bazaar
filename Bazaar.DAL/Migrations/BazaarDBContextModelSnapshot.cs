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

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Ad");

                    b.HasData(
                        new
                        {
                            Id = new Guid("72f4b73e-eee4-4ee3-a4f0-39b86fb5b2f1"),
                            Description = "Je velmi zlata, zbavte ma jej, prosim",
                            IsOffer = true,
                            IsPremium = false,
                            IsValid = true,
                            Price = 50,
                            Title = "Predam macku",
                            UserId = new Guid("200c6e54-315a-411c-82b0-e07eb1c9e882")
                        });
                });

            modelBuilder.Entity("Bazaar.DAL.Models.AdTag", b =>
                {
                    b.Property<Guid>("AdId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TagId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AdId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("AdTag");

                    b.HasData(
                        new
                        {
                            AdId = new Guid("72f4b73e-eee4-4ee3-a4f0-39b86fb5b2f1"),
                            TagId = new Guid("49308eff-3c59-483a-95e5-105c454dd97f")
                        },
                        new
                        {
                            AdId = new Guid("72f4b73e-eee4-4ee3-a4f0-39b86fb5b2f1"),
                            TagId = new Guid("3c86f388-50a3-4ae8-9c5d-93b07e1b003a")
                        });
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
                            Id = new Guid("b14f093f-0711-4dd6-a0f8-4f8b0772d5a2"),
                            AdId = new Guid("72f4b73e-eee4-4ee3-a4f0-39b86fb5b2f1"),
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

                    b.HasKey("AdId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Reaction");

                    b.HasData(
                        new
                        {
                            AdId = new Guid("72f4b73e-eee4-4ee3-a4f0-39b86fb5b2f1"),
                            UserId = new Guid("fd810cdf-49bc-4a3e-8d0e-145f2e6379ff"),
                            Accepted = true,
                            Id = new Guid("00000000-0000-0000-0000-000000000000"),
                            Message = "Mam zaujem o vasu prekrasnu macku"
                        });
                });

            modelBuilder.Entity("Bazaar.DAL.Models.Review", b =>
                {
                    b.Property<Guid>("ReviewerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ReviewedId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descritption")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.HasKey("ReviewerId", "ReviewedId");

                    b.HasIndex("ReviewedId");

                    b.ToTable("Review");

                    b.HasData(
                        new
                        {
                            ReviewerId = new Guid("fd810cdf-49bc-4a3e-8d0e-145f2e6379ff"),
                            ReviewedId = new Guid("200c6e54-315a-411c-82b0-e07eb1c9e882"),
                            Descritption = "Krasna macka, 10/10 spokojnost",
                            Id = new Guid("a17c8189-f949-40be-87b7-15e4df1c4eeb"),
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
                            Id = new Guid("49308eff-3c59-483a-95e5-105c454dd97f"),
                            TagName = "Animals"
                        },
                        new
                        {
                            Id = new Guid("3c86f388-50a3-4ae8-9c5d-93b07e1b003a"),
                            TagName = "Sell"
                        });
                });

            modelBuilder.Entity("Bazaar.DAL.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("LastName")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = new Guid("200c6e54-315a-411c-82b0-e07eb1c9e882"),
                            Email = "jozko@gmailol.com",
                            FirstName = "Jozko",
                            LastName = "Mrkvicka",
                            Level = 0,
                            PasswordHash = "tajneheslo",
                            PhoneNumber = "0000000",
                            UserName = "TestUser"
                        },
                        new
                        {
                            Id = new Guid("fd810cdf-49bc-4a3e-8d0e-145f2e6379ff"),
                            Email = "ferko@gmailol.com",
                            FirstName = "Ferko",
                            LastName = "Priezviskovy",
                            Level = 0,
                            PasswordHash = "supertajneheslo",
                            PhoneNumber = "2020040444",
                            UserName = "Feri"
                        });
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
                        .WithMany("AdTag")
                        .HasForeignKey("AdId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Bazaar.DAL.Models.Tag", "Tag")
                        .WithMany("AdTag")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Restrict)
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
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Ad");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Bazaar.DAL.Models.Review", b =>
                {
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

                    b.Navigation("Reviewed");

                    b.Navigation("Reviewer");
                });

            modelBuilder.Entity("Bazaar.DAL.Models.Ad", b =>
                {
                    b.Navigation("AdTag");

                    b.Navigation("Images");

                    b.Navigation("Reactions");
                });

            modelBuilder.Entity("Bazaar.DAL.Models.Tag", b =>
                {
                    b.Navigation("AdTag");
                });

            modelBuilder.Entity("Bazaar.DAL.Models.User", b =>
                {
                    b.Navigation("Ads");

                    b.Navigation("ReviewedIn");

                    b.Navigation("ReviewerIn");
                });
#pragma warning restore 612, 618
        }
    }
}
