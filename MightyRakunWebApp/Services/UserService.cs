namespace MightyRakunWebApp.Services;

using MightyRakunWebApp.Entities;

using Microsoft.EntityFrameworkCore;

public class UserService(AppDbContext db, IPasswordHasher passwordHasher) : IUserService
{
    public async Task<UserResponse> CreateAsync(string username, string email, string password, CancellationToken cancellationToken)
    {
        var user = new User
        {
            Id = Guid.NewGuid(),
            Username = username,
            Email = email,
            PasswordHash = passwordHasher.Hash(password)
        };

        db.Users.Add(user);
        await db.SaveChangesAsync(cancellationToken);
        return new UserResponse(user.Id, user.Username, user.Email);
    }
}