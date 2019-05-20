using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ALaCart.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ALaCart.Data.Context
{
    public class ALaCartDbContext : IdentityDbContext<Customer>
    {
        public DbSet<Restaurant> Restaurants { get; set; }

        public DbSet<Site> Sites { get; set; }

        public DbSet<Menu> Menus { get; set; }

        public DbSet<MenuItem> MenuItems { get; set; }





        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Server=(localdb)\mssqllocaldb;Database=alacart;Trusted_Connection=true;";
            optionsBuilder.UseSqlServer(connectionString);

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Restaurant>().HasData(
                new Restaurant { ID = 1, Name = "Old Hubbards", Description = "Soul food" },
                new Restaurant { ID = 2, Name = "Billy Ray's Burgers", Description = "Classic burgers and shakes." },
                new Restaurant { ID = 3, Name = "Thai-phun", Description = "Traditional Thai food with a twist" },
                new Restaurant { ID = 4, Name = " Chicken Matters", Description = " Your mama's chicken, served to go." },
                new Restaurant { ID = 5, Name = " Vegans 4 Life", Description = " Delicious Vegan and Veggie options" }
                );

        }

    }
}
