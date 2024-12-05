using System.Text.Json.Serialization;

namespace TaskManager.Models.Entities;

public class Project
{
	[JsonPropertyName("id")]
	public int Id { get; set; }

	[JsonPropertyName("name")]
	public int Name { get; set; }

	[JsonPropertyName("description")]
	public int Description { get; set; }


	[JsonPropertyName("user_id")]
	public int UserId { get; set; }

	[JsonPropertyName("user")]
	public User? User { get; set; }
	

	[JsonPropertyName("tasks")]
	public ICollection<TaskItem> Tasks { get; set; } = new List<TaskItem>(); 
}
