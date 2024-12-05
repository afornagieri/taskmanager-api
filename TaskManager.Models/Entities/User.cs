using System.Text.Json.Serialization;

namespace TaskManager.Models.Entities;

public class User
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }


    [JsonPropertyName("projects")]
    public ICollection<Project> Projects { get; set; } = new List<Project>();

    [JsonPropertyName("tasks")]
    public ICollection<TaskItem> Tasks { get; set; } = new List<TaskItem>();
}
