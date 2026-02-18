using EntityFramework.Exceptions.SqlServer;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using MightyRakunWebApp.Endpoints.Users;
using MightyRakunWebApp.Entities;
using MightyRakunWebApp.Services;
using Scalar.AspNetCore;

namespace MightyRakunWebApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(connectionString).UseExceptionProcessor());
            builder.Services.AddOpenApi();

            builder.Services.AddSingleton<IPasswordHasher, PasswordHasher>();

            builder.Services.AddScoped<IUserService, UserService>();
            var app = builder.Build();
            app.MapOpenApi();
            app.MapScalarApiReference();

            CreateUserEndpoint.AddUser(app);
            app.Run();
        }
    }
}