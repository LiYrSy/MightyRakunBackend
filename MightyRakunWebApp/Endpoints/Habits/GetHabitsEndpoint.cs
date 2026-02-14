using Microsoft.EntityFrameworkCore;
using MightyRakunWebApp.Entities;
namespace MightyRakunWebApp.Endpoints.Habits;

class GertHabitsEndpoint
{
        private static void GetHabits(AppDbContext dbContext)
        {
            var habits = dbContext.Habits.AsNoTracking();
            if (!habits.Any())
            {
                Console.WriteLine("------- No habits found. -------");
                return;
            }

            foreach (var habit in habits)
            {
                Console.WriteLine($"Habit Id: {habit.Id}, Title: {habit.Title}, Description: {habit.Description}");
            }
        }
}