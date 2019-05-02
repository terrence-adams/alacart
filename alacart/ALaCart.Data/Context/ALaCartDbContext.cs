using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ALaCart.Models;

namespace ALaCart.Data.Context
{
    public class ALaCartDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Server=(localdb)\mssqllocaldb;Database=alacart;Trusted_Connection=true;";
            optionsBuilder.UseSqlServer(connectionString);

        }

    }
}
