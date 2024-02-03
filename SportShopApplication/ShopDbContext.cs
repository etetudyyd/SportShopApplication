using Microsoft.EntityFrameworkCore;
using SportShopApplication.Models;

namespace SportShopApplication
{
     public class ShopDbContext : DbContext
    {
        public DbSet<ShopEntity> Shops { get; set; }

        public DbSet<ProductEntity> Products { get; set; }

        public DbSet<EmployeeEntity> Employees { get; set; }

        public DbSet<ClientEntity> Clients { get; set; }

    }
}
