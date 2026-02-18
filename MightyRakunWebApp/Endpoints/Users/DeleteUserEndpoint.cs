using Microsoft.EntityFrameworkCore;
using MightyRakunWebApp.Entities;
namespace MightyRakunWebApp.Endpoints.Users;

class DeleteUserEndpoint
{
    private static void DeleteUser(AppDbContext dbContext, User user)
    {
        var userToDelete = dbContext.Users.First(u => u.Id == user.Id);
        dbContext.Users.Remove(userToDelete);
        dbContext.SaveChanges();
    }
}