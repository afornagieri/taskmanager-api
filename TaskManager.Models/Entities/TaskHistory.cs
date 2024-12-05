using System.Text.Json.Serialization;

namespace TaskManager.Models.Entities;

public class TaskHistory
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("changes")]
    public string? Changes { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTime UpdatedAt { get; set; }


    [JsonPropertyName("task_id")]
    public int TaskId { get; set; }

    [JsonPropertyName("task_item")]
    public TaskItem? TaskItem { get; set; }


    [JsonPropertyName("user_id")]
    public int UserId { get; set; }

    [JsonPropertyName("user")]
    public User? User { get; set; }
}
