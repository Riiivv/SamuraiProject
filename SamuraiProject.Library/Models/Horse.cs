namespace SamuraiProject.Library.Models;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations.Schema;

public class Horse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int SamuraiId { get; set; } // FK to Samurai

    [ForeignKey("SamuraiId")]
    [JsonIgnore]
    public virtual Samurai? Samurai { get; set; } // Navigation property
}
