
using Microsoft.EntityFrameworkCore;
using MightyRakunWebApp.Entities;
namespace MightyRakunWebApp.Endpoints.Habits;

class AddHabitEndpoint
{
    private static void AddHabit(AppDbContext dbContext, Habit habit)
    {
        dbContext.Add(habit);
        dbContext.SaveChanges();
    }
}