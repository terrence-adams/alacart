﻿// <auto-generated />
using System;
using ALaCart.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ALaCart.Data.Migrations
{
    [DbContext(typeof(ALaCartDbContext))]
    partial class ALaCartDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("CustomerID");

                    b.Property<int?>("SiteID");

                    b.HasKey("ID");

                    b.HasIndex("SiteID");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("ALaCart.Models.Customer", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<int>("CustomerAddressID");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<string>("EmailAddress")
                        .HasMaxLength(30);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<int?>("SiteID");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("CustomerAddressID");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("SiteID");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("ALaCart.Models.Menu", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RestaurantIdOfMenu");

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

                    b.Property<int?>("OrderID");

                    b.Property<decimal>("Price");

                    b.HasKey("ID");

                    b.HasIndex("MenuID");

                    b.HasIndex("OrderID");

                    b.ToTable("MenuItems");
                });

            modelBuilder.Entity("ALaCart.Models.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CartID");

                    b.Property<string>("CustomerID")
                        .IsRequired();

                    b.Property<int?>("RestaurantID");

                    b.Property<int>("SiteID");

                    b.HasKey("ID");

                    b.HasIndex("CartID");

                    b.HasIndex("RestaurantID");

                    b.HasIndex("SiteID");

                    b.ToTable("Order");
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

                    b.Property<string>("RestaurantID");

                    b.Property<int?>("SiteAddressID");

                    b.Property<string>("SiteName")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("SiteAddressID");

                    b.ToTable("Sites");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
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
                        .HasForeignKey("CustomerAddressID")
                        .OnDelete(DeleteBehavior.Cascade);

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

                    b.HasOne("ALaCart.Models.Order")
                        .WithMany("Items")
                        .HasForeignKey("OrderID");
                });

            modelBuilder.Entity("ALaCart.Models.Order", b =>
                {
                    b.HasOne("ALaCart.Models.Cart")
                        .WithMany("CustomerOrders")
                        .HasForeignKey("CartID");

                    b.HasOne("ALaCart.Models.Restaurant")
                        .WithMany("RestaurantOrders")
                        .HasForeignKey("RestaurantID");

                    b.HasOne("ALaCart.Models.Site", "Site")
                        .WithMany()
                        .HasForeignKey("SiteID")
                        .OnDelete(DeleteBehavior.Cascade);
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ALaCart.Models.Customer")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ALaCart.Models.Customer")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ALaCart.Models.Customer")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ALaCart.Models.Customer")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
