using System.Text.Json.Serialization;

namespace TaskManager.Models.Entities;

public class TaskComment
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }


    [JsonPropertyName("task_id")]
    public int TaskId { get; set; }

    [JsonPropertyName("task_item")]
    public TaskItem? TaskItem { get; set; }


    [JsonPropertyName("user_id")]
    public int UserId { get; set; }

    [JsonPropertyName("user")]
    public User? User { get; set; }
}
