using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PasswordManagerAPI.DTOs.UserProfileDTO;
using PasswordManagerAPI.Entitys;
using PasswordManagerAPI.Interfaces;
using System;

namespace PasswordManagerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfileController : ControllerBase
    {
        private readonly IUserProfile _userProfile;
        public UserProfileController(IUserProfile userProfile)
        {
            _userProfile = userProfile;
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> GetUserProfile(int UserId)
        {
            try
            {
                var resulte = await _userProfile.GetUserProfile(UserId);
                return Ok(resulte);
            }
            catch (Exception ex) 
            {
                return StatusCode(500, ex.Message);
            }

        }
        [HttpPost("[action]")]
        public async Task<IActionResult> UpdateImageProfile(int UserId, string url)
        {
            try
            {
                var resulte = await _userProfile.UpdateImageProfile(UserId,url);
                return Ok(resulte);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> UpdateUserProfile(UpdateProfileDTO input)
        {
            try
            {
                var resulte = await _userProfile.UpdateUserProfile(input);
                return Ok(resulte);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
