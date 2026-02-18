namespace MightyRakunWebApp.Entities;
public class UserHabit
{
    public Guid UserId { get; set; }
    public int HabitId { get; set; }
    public bool IsCompleted { get; set; }
    public virtual User User { get; set; }
    public virtual Habit Habit { get; set; }
}