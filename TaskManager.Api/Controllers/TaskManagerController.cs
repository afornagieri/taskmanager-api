using Microsoft.AspNetCore.Mvc;

namespace TaskManager.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TaskManagerController : ControllerBase
{
    private readonly ILogger<TaskManagerController> _logger;

    public TaskManagerController(ILogger<TaskManagerController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "TaskManager")]
    public async Task<IActionResult> Get()
    {
        return Ok();
    }
}
