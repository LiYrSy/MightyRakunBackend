namespace MightyRakunWebApp.Services;
using MightyRakunWebApp.Entities;

public interface IUserService
{
    Task <UserResponse> CreateAsync(string username, string email, string passsord, CancellationToken cancellationToken);
}