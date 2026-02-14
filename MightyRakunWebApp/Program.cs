using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using MightyRakunWebApp.Entities;

namespace MightyRakunWebApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // var dbContext = new AppDbContext();
            // var habits = new List<UserHabit>
            // {
            //    new() { UserId = 2, HabitId = 2, IsCompleted = false },
            //    new() { UserId = 2, HabitId = 1, IsCompleted = false }

            // };
            // var newUser = new User
            // {
            //     Id = 2,
            //     Email = "sobakis@puhliy.com",
            //     Username = "Sobakis",
            //     UserHabits = habits,
            // };

            // var newHabit = new Habit
            // {
            //     Icon = "🚰",
            //     Title = "Drink water",
            //     Description = "Pour a glass of water",
            //     Color = "#427BF7",
            // };

            var builder = WebApplication.CreateBuilder(args);

            var app = builder.Build();

            app.Run();
        }
    }
}