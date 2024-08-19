using Microsoft.AspNetCore.Mvc;

namespace IssueTrackerAPI.Controllers;

public class StatusController : ControllerBase
{
    [HttpGet("/status")]
    public async Task<ActionResult> GetTheStatus()
    {
        var response = new StatusResponseModel
        {
            Message = "Looks Good Here, Boss",
            WhenChecked = DateTimeOffset.Now
        };
        return Ok(response);
    }
}

public record StatusResponseModel
{
    public string Message { get; set; } = string.Empty;
    public DateTimeOffset WhenChecked { get; set; }
}
