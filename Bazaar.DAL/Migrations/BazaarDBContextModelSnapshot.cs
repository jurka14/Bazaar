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
                            Id = new Guid("6505480b-ec94-48ef-88e5-c85f19027411"),
                            Description = "Je velmi zlata, zbavte ma jej, prosim",
                            IsOffer = true,
                            IsPremium = false,
                            IsValid = true,
                            Price = 50,
                            Title = "Predam macku",
                            UserId = new Guid("fe5f5529-8962-4b7d-9c59-59d1234d51ab")
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
                            Id = new Guid("617db75e-465f-4117-992f-8e41b9939ff9"),
                            AdId = new Guid("6505480b-ec94-48ef-88e5-c85f19027411"),
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

                    b.HasKey("AdId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Reaction");

                    b.HasData(
                        new
                        {
                            AdId = new Guid("6505480b-ec94-48ef-88e5-c85f19027411"),
                            UserId = new Guid("c81bf26a-4ddf-4440-91c9-3d19f7c0fe07"),
                            Accepted = true,
                            Id = new Guid("00000000-0000-0000-0000-000000000000"),
                            Message = "Mam zaujem o vasu prekrasnu macku",
                            Rejected = false
                        });
                });

            modelBuilder.Entity("Bazaar.DAL.Models.Review", b =>
                {
                    b.Property<Guid>("ReviewerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ReviewedId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

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
                            ReviewerId = new Guid("c81bf26a-4ddf-4440-91c9-3d19f7c0fe07"),
                            ReviewedId = new Guid("fe5f5529-8962-4b7d-9c59-59d1234d51ab"),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descritption = "Krasna macka, 10/10 spokojnost",
                            Id = new Guid("707a7639-e30e-41e2-9151-150ab5e30a50"),
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
                            Id = new Guid("a5eae206-0d44-4cc8-a68a-1de60d7e1bbd"),
                            TagName = "Animals"
                        },
                        new
                        {
                            Id = new Guid("d0e774dc-24b2-4fa1-9b3c-5f65a92624e1"),
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
                            Id = new Guid("fe5f5529-8962-4b7d-9c59-59d1234d51ab"),
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
                            Id = new Guid("c81bf26a-4ddf-4440-91c9-3d19f7c0fe07"),
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

                    b.Navigation("ReviewedIn");

                    b.Navigation("ReviewerIn");
                });
#pragma warning restore 612, 618
        }
    }
}
