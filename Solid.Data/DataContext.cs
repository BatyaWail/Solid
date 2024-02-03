//using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Solid.Core.Models;
using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Solid.Data
{
    public class DataContext:DbContext
    {
        public DbSet<Product> products { get; set; }
        public DbSet<Client> clients { get; set; }
        public DbSet<Station> stations { get; set; }
        //DbContextOptionsBuilder
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=new-db");
        }
    }
}
