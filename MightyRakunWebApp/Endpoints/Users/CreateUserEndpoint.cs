using Microsoft.EntityFrameworkCore;
using MightyRakunWebApp.Entities;
using MightyRakunWebApp.Services;

namespace MightyRakunWebApp.Endpoints.Users;

public static class CreateUserEndpoint
{
    public static void AddUser(WebApplication app)
    {
        app.MapPost("/users", async (CreateUserRequest req, IUserService svc, CancellationToken ct) =>
        {
            var user = await svc.CreateAsync(req.Username, req.Email, req.Password, ct);
            return Results.Created($"/users/", user);
        }).WithTags("Users");
    }
}