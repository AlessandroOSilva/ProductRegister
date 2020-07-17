using Microsoft.EntityFrameworkCore;
using ProductRegister.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRegister.Data
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySQL(@"Server=localhost;Database=productsDB;Uid=root;Pwd=admin;");
        }

    }
}
