using BestPrices.Site.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestPrices.Site.Data
{
    public class PriceDbContext : DbContext
    {
        public PriceDbContext(DbContextOptions options) : base(options)
        { 
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Ecommerce> Ecommerces { get; set; }
        public DbSet<UserProduct> UsersProducts { get; set; }
        public DbSet<EmailToken> EmailTokens { get; set; }
    }
}
