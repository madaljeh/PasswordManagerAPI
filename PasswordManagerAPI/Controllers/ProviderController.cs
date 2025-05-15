using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PasswordManagerAPI.DTOs.ProviderDTO;
using PasswordManagerAPI.Entitys;
using PasswordManagerAPI.Interfaces;
using System;

namespace PasswordManagerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProviderController : ControllerBase
    {
        private readonly IProvider _Provider;
        public ProviderController(IProvider Provider)
        {
            _Provider = Provider;
        }
        public async Task<IActionResult> CreateUpdateProvider(CreateUpdateProviderDTO input)
        {
            try
            {
                var resulte = await _Provider.CreateUpdateProvider(input);
                return Ok(resulte);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        public async Task<IActionResult> GetProvider()
        {
            try
            {
                var resulte = await _Provider.GetProvider();
                return Ok(resulte);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        public async Task<IActionResult> GetProviderDetails(int Id)
        {
            try
            {
                var resulte = await _Provider.GetProviderDetails(Id);
                return Ok(resulte);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
