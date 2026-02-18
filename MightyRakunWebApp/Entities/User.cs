namespace MightyRakunWebApp.Entities;
public class User
{
    public Guid Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; } 
    public virtual List<UserHabit> UserHabits { get; set; } = [];
}

public record UserResponse(Guid Id, string Username, string Email);
public record CreateUserRequest(string Username, string Email, string Password);