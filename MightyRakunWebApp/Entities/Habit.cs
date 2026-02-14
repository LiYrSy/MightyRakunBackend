namespace MightyRakunWebApp.Entities;
public class Habit
{
    public int Id { get; set; }
    public required string Icon { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
    public required string Color { get; set; }

}