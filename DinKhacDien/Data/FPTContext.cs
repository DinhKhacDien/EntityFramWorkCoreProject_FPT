using DinKhacDien.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinKhacDien.Data
{
    public class FPTContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-045KIG4Q\\SQLEXPRESS;Database=FPT;Trusted_Connection=True;");
        }
        public DbSet<Product>? Products { get; set; }
    }
}
