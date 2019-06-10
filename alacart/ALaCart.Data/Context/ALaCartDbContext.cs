using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ALaCart.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace ALaCart.Data.Context
{
    public class ALaCartDbContext : IdentityDbContext<Customer>
    {
        public DbSet<Restaurant> Restaurants { get; set; }

        public DbSet<Site> Sites { get; set; }

        public DbSet<Menu> Menus { get; set; }

        public DbSet<MenuItem> MenuItems { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }






        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Server=(localdb)\mssqllocaldb;Database=alacart;Trusted_Connection=true;";
            optionsBuilder.UseSqlServer(connectionString);

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); //identity server
            modelBuilder.Entity<Restaurant>().HasData(
                new Restaurant { ID = 1, Name = "Old Hubbards", Description = "Soul food", SiteId = 1 },
                new Restaurant { ID = 2, Name = "Billy Ray's Burgers", Description = "Classic burgers and shakes.", SiteId = 1 },
                new Restaurant { ID = 3, Name = "Thai-phun", Description = "Traditional Thai food with a twist", SiteId = 1 },
                new Restaurant { ID = 4, Name = " Chicken Matters", Description = " Your mama's chicken, served to go.", SiteId = 1 },
                new Restaurant { ID = 5, Name = " Vegans 4 Life", Description = " Delicious Vegan and Veggie options", SiteId = 1 }
                );
            modelBuilder.Entity<Menu>()
                .HasOne(m => m.Restaurant)
                .WithMany(mu => mu.RestaurantMenus)
                .HasForeignKey(m => m.RestaurantId);



            modelBuilder.Entity<MenuItem>()
                .HasOne(m => m.Menu)
                .WithMany(mi => mi.MenuItems)
                .HasForeignKey(m => m.MenuId);


            modelBuilder.Entity<IdentityRole>()
                .HasData(
                    new IdentityRole { Name = " Admin", NormalizedName = "ADMIN" },
                    new IdentityRole { Name = "User", NormalizedName = "USER" },
                    new IdentityRole { Name = "Employee", NormalizedName = "Employee" },
                    new IdentityRole { Name = "Vendor", NormalizedName = "VENDOR" }
                );



        }

    }
}
