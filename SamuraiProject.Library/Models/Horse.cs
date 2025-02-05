namespace SamuraiProject.Library.Models;

public class Horse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int SamuraiId { get; set; } // FK to Samurai
    public Samurai Samurai { get; set; } // Navigation property
}
