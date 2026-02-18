using Microsoft.EntityFrameworkCore;
using MightyRakunWebApp.Entities;
namespace MightyRakunWebApp.Endpoints.Users;

class GetUsersEndpoint
{
       private static async Task GetUsers(AppDbContext dbContext)
        {
            var users = await dbContext.Users
                .Include(u => u.UserHabits)
                .ThenInclude(uh => uh.Habit)
                .AsNoTracking()
                .ToListAsync();

            if (users.Count is 0) 
            {
                Console.WriteLine("------ No users found. ------");
                return;
            }

            foreach (var user in users)
            {
                Console.WriteLine($"User ID: {user.Id}, Name: {user.Username}, Email: {user.Email}, Habits: {user.UserHabits.First().Habit.Title}");
            }
        }
}