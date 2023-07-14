using Microsoft.EntityFrameworkCore;

namespace UrbanKicks.Models
{ 
    // the MyContext class representing a session with SQL Server 
    // database allowing us to query for or save data
    public class MyContext : DbContext 
    { 
        public MyContext(DbContextOptions options) : base(options) { }
        // the "Users" table name will come from the DbSet variable name
        public DbSet<User> Users { get; set; }
        public DbSet<ShippingAddress> ShippingAddresses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ProductAndOrder> ProductAndOrders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductSize> ProductSizes { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductAndCollection> ProductAndCollections { get; set; }
        public DbSet<Collection> Collections { get; set; }
    }
}