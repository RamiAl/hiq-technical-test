using Backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UploadController : ControllerBase
    {
        [HttpPost]
        [Route("file")]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            // Check file existence
            if (file == null || file.Length == 0)
                return BadRequest("No file was uploaded.");

            // Read file content
            string fileContent;
            using (var reader = new StreamReader(file.OpenReadStream()))
            {
                fileContent = await reader.ReadToEndAsync();
            }

            // Process and return text
            var processedText = TextProcessor.ProcessContent(fileContent);
            return Ok(new { processedText });
        }
    }
}
