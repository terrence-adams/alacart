﻿// <auto-generated />
using System;
using ALaCart.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ALaCart.Data.Migrations
{
    [DbContext(typeof(ALaCartDbContext))]
    [Migration("20190513063727_DbContext-Added")]
    partial class DbContextAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ALaCart.Models.Address", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address1")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Address2");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("State")
                        .IsRequired();

                    b.Property<string>("Zipcode")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("ID");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("ALaCart.Models.Cart", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("SiteID");

                    b.HasKey("ID");

                    b.HasIndex("SiteID");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("ALaCart.Models.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomerAddressID");

                    b.Property<int?>("CustomerCartID");

                    b.Property<string>("EmailAddress")
                        .HasMaxLength(30);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<int?>("SiteID");

                    b.HasKey("ID");

                    b.HasIndex("CustomerAddressID");

                    b.HasIndex("CustomerCartID");

                    b.HasIndex("SiteID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("ALaCart.Models.Menu", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RestaurantIdOfMenu");

                    b.Property<int?>("RestaurantOfMenuID");

                    b.HasKey("ID");

                    b.HasIndex("RestaurantOfMenuID");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("ALaCart.Models.MenuItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MenuID");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<decimal>("Price");

                    b.HasKey("ID");

                    b.HasIndex("MenuID");

                    b.ToTable("MenuItems");
                });

            modelBuilder.Entity("ALaCart.Models.Restaurant", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("RestaurantMenuID");

                    b.Property<int?>("SiteID");

                    b.HasKey("ID");

                    b.HasIndex("SiteID");

                    b.ToTable("Restaurants");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Description = "Soul food",
                            Name = "Old Hubbards",
                            RestaurantMenuID = 0
                        },
                        new
                        {
                            ID = 2,
                            Description = "Classic burgers and shakes.",
                            Name = "Billy Ray's Burgers",
                            RestaurantMenuID = 0
                        },
                        new
                        {
                            ID = 3,
                            Description = "Traditional Thai food with a twist",
                            Name = "Thai-phun",
                            RestaurantMenuID = 0
                        },
                        new
                        {
                            ID = 4,
                            Description = " Your mama's chicken, served to go.",
                            Name = " Chicken Matters",
                            RestaurantMenuID = 0
                        },
                        new
                        {
                            ID = 5,
                            Description = " Delicious Vegan and Veggie options",
                            Name = " Vegans 4 Life",
                            RestaurantMenuID = 0
                        });
                });

            modelBuilder.Entity("ALaCart.Models.Site", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RestaurantID");

                    b.Property<int?>("SiteAddressID");

                    b.Property<string>("SiteName")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("SiteAddressID");

                    b.ToTable("Sites");
                });

            modelBuilder.Entity("ALaCart.Models.Cart", b =>
                {
                    b.HasOne("ALaCart.Models.Site")
                        .WithMany("Carts")
                        .HasForeignKey("SiteID");
                });

            modelBuilder.Entity("ALaCart.Models.Customer", b =>
                {
                    b.HasOne("ALaCart.Models.Address", "CustomerAddress")
                        .WithMany()
                        .HasForeignKey("CustomerAddressID");

                    b.HasOne("ALaCart.Models.Cart", "CustomerCart")
                        .WithMany()
                        .HasForeignKey("CustomerCartID");

                    b.HasOne("ALaCart.Models.Site")
                        .WithMany("Customers")
                        .HasForeignKey("SiteID");
                });

            modelBuilder.Entity("ALaCart.Models.Menu", b =>
                {
                    b.HasOne("ALaCart.Models.Restaurant", "RestaurantOfMenu")
                        .WithMany("RestaurantMenus")
                        .HasForeignKey("RestaurantOfMenuID");
                });

            modelBuilder.Entity("ALaCart.Models.MenuItem", b =>
                {
                    b.HasOne("ALaCart.Models.Menu")
                        .WithMany("MenuItems")
                        .HasForeignKey("MenuID");
                });

            modelBuilder.Entity("ALaCart.Models.Restaurant", b =>
                {
                    b.HasOne("ALaCart.Models.Site")
                        .WithMany("Restaurants")
                        .HasForeignKey("SiteID");
                });

            modelBuilder.Entity("ALaCart.Models.Site", b =>
                {
                    b.HasOne("ALaCart.Models.Address", "SiteAddress")
                        .WithMany()
                        .HasForeignKey("SiteAddressID");
                });
#pragma warning restore 612, 618
        }
    }
}