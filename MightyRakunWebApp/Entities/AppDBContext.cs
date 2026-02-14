using Microsoft.EntityFrameworkCore;

namespace MightyRakunWebApp.Entities;

public class AppDbContext : DbContext
{
  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    var connectionString =
    "Server=localhost,55000;Database=AppDb;User Id=sa;Password=paanssy1234$;TrustServerCertificate=True;";
    optionsBuilder.UseSqlServer(connectionString);
    // .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
    base.OnConfiguring(optionsBuilder);
  }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);

    modelBuilder.Entity<UserHabit>()
        .HasKey(uh => new { uh.UserId, uh.HabitId });

    modelBuilder.Entity<UserHabit>()
        .HasOne(uh => uh.User)
        .WithMany(u => u.UserHabits)
        .HasForeignKey(uh => uh.UserId);

    modelBuilder.Entity<UserHabit>()
        .HasOne(uh => uh.Habit)
        .WithMany()
        .HasForeignKey(uh => uh.HabitId);
  }

  public DbSet<User> Users { get; set; }
  public DbSet<Habit> Habits { get; set; }
  public DbSet<UserHabit> UserHabits { get; set; }
}
