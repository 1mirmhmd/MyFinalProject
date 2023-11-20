using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    // Context: Db tabloları ile proje class'larını bağlama
    public class NorthwindContext:DbContext
    {
        // Burası projenin hangi veritabanı ile ilişkili olduğunu belirteceğimiz alan
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=DESKTOP-FJ76VKB;Database=Northwind;Trusted_Connection=true");
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-FJ76VKB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        // Hangi nesne hangi nesneye karşılık geleceği burada belirtir
        public DbSet<Product> Products{ get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Customer> Customers{ get; set; }
        public DbSet<Order> Orders{ get; set; }


    }
}
