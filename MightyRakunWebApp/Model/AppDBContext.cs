using Microsoft.EntityFrameworkCore;

namespace SampleEntityFramework
{
    public class AppDBContext : DbContext
    {
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      var connectionString = "Data Source=appdb.db";
      optionsBuilder.UseSqlServer(connectionString);
      base.OnConfiguring(optionsBuilder);
    }
      public DbSet<User> Users { get; set; }
    }
}