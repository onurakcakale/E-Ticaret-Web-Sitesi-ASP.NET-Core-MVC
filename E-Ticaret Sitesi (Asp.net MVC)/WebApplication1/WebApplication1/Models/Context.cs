using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-UN0ODJU;Initial Catalog=WebTasarimDB;Integrated Security=True");
        }

        public DbSet<Products> products { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<Admin> admins { get; set; }
    }
}