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
    }
}