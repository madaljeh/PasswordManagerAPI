using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PasswordManagerAPI.Helpers;
using PasswordManagerAPI.Interfaces;

namespace PasswordManagerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LookupsController : ControllerBase
    {
        private readonly ILookupItem _lookupItem;
        public LookupsController(ILookupItem lookupItem)
        {
            _lookupItem = lookupItem;
        }

        [HttpGet("Get-Lookup-Item/{typeId}")]
        public async Task<IActionResult> GetLookups([FromRoute] int typeId)
        {
            try
            {
                var resulte = await _lookupItem.GetLookupItemsByTypeId(typeId);
                return Ok(resulte);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
