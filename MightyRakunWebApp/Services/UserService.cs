using EntityFramework.Exceptions.Common;

namespace MightyRakunWebApp.Services;

using MightyRakunWebApp.Entities;

public class UserService(AppDbContext dbContext, IPasswordHasher passwordHasher) : IUserService
{
    public async Task<IResult> CreateAsync(string username, string email, string password,
        CancellationToken cancellationToken)
    {
        var user = new User
        {
            Id = Guid.NewGuid(),
            Username = username,
            Email = email,
            PasswordHash = passwordHasher.Hash(password)
        };

        try
        {
            dbContext.Users.Add(user);
            await dbContext.SaveChangesAsync(cancellationToken);
            return Results.Created();
        }
        catch (UniqueConstraintException)
        {
            return Results.Conflict("Email or Username is already taken.");
        }
    }
}