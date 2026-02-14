
using Microsoft.EntityFrameworkCore;
using MightyRakunWebApp.Entities;
namespace MightyRakunWebApp.Endpoints.Users;

class CreateUserEndpoint
{
    static IResult CreateUser(User newUser)
    {
        AddUserToDB(newUser);
        return TypedResults.Created("/users/{id}");
    }

    private static void AddUserToDB(User newUser)
    {
        AppDbContext dbContext = new();
        dbContext.Users.Add(newUser);
        dbContext.SaveChanges();
    }
}
