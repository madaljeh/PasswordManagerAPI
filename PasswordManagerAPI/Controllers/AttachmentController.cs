using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PasswordManagerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttachmentController : ControllerBase
    {
        [HttpPost("[action]")]
        public async Task<IActionResult> UploadImage(IFormFile file)
        {
            try
            {
                if (file == null || file.Length==0)
                {
                    throw new Exception("Invalid File");
                }
                string FileName = Guid.NewGuid().ToString()+"_"+file.FileName;
                string directory = Path.Combine(Directory.GetCurrentDirectory(),"Uploads");
                using (var fs = new FileStream(Path.Combine(directory, FileName), FileMode.Create))
                {
                    await file.CopyToAsync(fs);
                }
                return Ok($"/Uploads/{FileName}");
                 
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
