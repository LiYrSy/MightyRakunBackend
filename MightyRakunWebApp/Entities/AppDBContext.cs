using Microsoft.EntityFrameworkCore;

namespace MightyRakunWebApp.Entities;

public class AppDbContext : DbContext
{
  public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
  
  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);

    modelBuilder.Entity<User>(e =>
    {
        e.HasIndex(u => u.Email).IsUnique();
        e.HasIndex(u => u.Username).IsUnique();
    });
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
