namespace MightyRakunWebApp.Entities;
public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public byte[] PasswordHash { get; set; } 
    public virtual List<UserHabit> UserHabits { get; set; } = new();

}