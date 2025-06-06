using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PasswordManagerAPI.DTOs.AccountDTO;
using PasswordManagerAPI.Interfaces;
using System;

namespace PasswordManagerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountInterface _account;
        public AccountController(IAccountInterface account)
        {
            _account = account;
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetDetailDTO(int Id)
        {
            try
            {
                var resulte = await _account.GetDetailDTO(Id);
                return Ok(resulte);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetMyAccount(int userId)
        {
            try
            {
                var resulte = await _account.GetMyAccount(userId);
                return Ok(resulte);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> SearchAccount(AccountSearchInputDTO input)
        {
            try
            {
                var resulte = await _account.SearchAccount(input);
                return Ok(resulte);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> CopyAccountOrignizalPassword(int Id)
        {
            try
            {
                var resulte = await _account.CopyAccountOrignizalPassword(Id);
                return Ok(resulte);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> CreateSreongPassword(int length)
        {
            try
            {
                var resulte = await _account.CreateSreongPassword(length);
                return Ok(resulte);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> CreateUpdateAccount(CreateUpdateAccountInputDTO input)
        {
            try
            {
                var resulte = await _account.CreateUpdateAccount(input);
                return Ok(resulte);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        
    }
}
