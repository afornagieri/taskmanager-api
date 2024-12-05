using System.Text.Json.Serialization;

namespace TaskManager.Models.Entities;

public class TaskItem
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("title")]
    public int Title { get; set; }

    [JsonPropertyName("description")]
    public int Description { get; set; }

    [JsonPropertyName("due_date")]
    public DateTime DueDate { get; set; }

    [JsonPropertyName("status")]
    public TaskStatus Status { get; set; }

    [JsonPropertyName("priority")]
    public Priority Priority { get; private set; }


    [JsonPropertyName("project_id")]
    public int ProjectId  { get; set; }

    [JsonPropertyName("project")]
    public Project? Project  { get; set; }
    

    [JsonPropertyName("comments")]
    public ICollection<TaskComment> Comments { get; set; } = new List<TaskComment>();
}

public enum TaskStatus {
    Pending,
    InProgress,
    Completed
}

public enum Priority {
    Low,
    Medium,
    High
}
