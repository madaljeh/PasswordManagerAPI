using Microsoft.EntityFrameworkCore;
using PasswordManagerAPI.Context;
using PasswordManagerAPI.DTOs.UserProfileDTO;
using PasswordManagerAPI.Entitys;
using PasswordManagerAPI.Interfaces;

namespace PasswordManagerAPI.Services
{
    public class UserProfileService : IUserProfile
    {
        private readonly PasswordManagerDbContext _context;
        public UserProfileService(PasswordManagerDbContext context)
        {
            _context = context;
        }
        public async Task<ProfileDTO> GetUserProfile(int UserId)
        {
            var profile = await _context.Profiles.Where(x => x.UserId == UserId).Select(x => new ProfileDTO 
            {
                Email = x.Email,
                Phone = x.Phone,
                Image = x.Image,
                FullName = x.FirstName + " " + x.LastName,

            }).FirstOrDefaultAsync();

            return profile;
        }

        public async Task<string> UpdateImageProfile(int UserId, string url)
        {
            var profile = await _context.Profiles.Where(x => x.UserId == UserId).FirstOrDefaultAsync();
            if (profile == null)
            {
                return "Profile Not Found";
            }
            else
            {
                if (!string.IsNullOrEmpty(profile.Image))
                {
                    profile.Image = url;
                }
                _context.Update(profile);
                await _context.SaveChangesAsync();
            }
            return "Updated Done";
        }

        public async Task<string> UpdateUserProfile(UpdateProfileDTO input)
        {
            var profile = await _context.Profiles.Where(x => x.Id == input.Id).FirstOrDefaultAsync();
            if (profile == null)
            {
                return "Profile Not Found";
            }
            else
            {
                if (profile.Email != input.Email)
                {
                    profile.Email = input.Email;
                }
                if (profile.FirstName != input.FirstName)
                {
                    profile.FirstName = input.FirstName;
                }
                if (profile.LastName != input.LastName)
                {
                    profile.LastName = input.LastName;
                }
                if (!string.IsNullOrEmpty(profile.Image))
                {
                    profile.Image = input.Image;
                }
                if (!string.IsNullOrWhiteSpace(profile.Phone))
                {
                    profile.Phone = input.Phone;
                }

                _context.Update(profile);
                await _context.SaveChangesAsync();
            }

            return "Updated Done";
        }
    }
}
