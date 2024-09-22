using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ДЗ1.Models;

namespace ДЗ1.DB
{
    internal class MyDbContext : DbContext
    {
        public DbSet<StandartModel> Standart {  get; set; }
        public DbSet<V1Model> V1 { get; set; }
        public DbSet<V2Model> V2 { get; set; }

        public MyDbContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=Gleb\\SQLEXPRESS;Database=П1;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
