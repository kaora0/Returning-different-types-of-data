using Microsoft.AspNetCore.Mvc;
using System.IO;

[ApiController]
[Route("[controller]")]
public class TestikController : ControllerBase
{
    [HttpGet("html")]
    public IActionResult GetHtml()
    {
        string htmlContent = "<html><body><h1>Hello, World!</h1></body></html>";
        return Content(htmlContent, "text/html");
    }

    [HttpGet("json")]
    public IActionResult GetJson()
    {
        var jsonData = new { Name = "Максимка", Age = 5 };
        return Ok(jsonData);
    }

    [HttpGet("file")]
    public IActionResult GetFile()
    {
        var filePath = @"..\..\file.txt";
        var fileStream = new FileStream(filePath, FileMode.Open);
        return File(fileStream, "application/octet-stream", "file.txt");
    }

    [HttpGet("notfound")]
    public IActionResult GetNotFound()
    {
        return NotFound();
    }
}
