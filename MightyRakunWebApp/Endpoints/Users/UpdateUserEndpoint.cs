

using Microsoft.EntityFrameworkCore;
using MightyRakunWebApp.Entities;
namespace MightyRakunWebApp.Endpoints.Users;

class UpdateUserEndpoint
{
    private AppDbContext dbContext = new AppDbContext();
    private static void UpdateUser(AppDbContext dbContext, User user)
    {
        var userToUpdate = dbContext.Users.First(u => u.Id == user.Id);
        userToUpdate.Username = user.Username;
        userToUpdate.Email = user.Email;
        userToUpdate.UserHabits = user.UserHabits;
        dbContext.SaveChanges();
    }
}