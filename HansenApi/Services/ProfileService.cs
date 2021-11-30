using HansenApi.DTO;
using HansenApi.Interfaces;
using HansenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HansenApi.Services
{
    public class ProfileService : IProfileService
    {
        private readonly IProfileReporsitory _context;
        public ProfileService(IProfileReporsitory context)
        {
            _context = context;
        }

        public async Task<Profile> CreateProfile(Profile _Profile)
        {
            return await _context.CreateProfile(_Profile);
        }

        public async Task<bool> DeleteProfile(int ProfileId)
        {
            var temp = await _context.DeleteProfile(ProfileId);
            return temp != null;
        }

        public async Task<List<ProfileResponse>> GetAllProfiles()
        {
            List<Profile> profile = await _context.GetAllProfiles();
            return profile.Select(obj => new ProfileResponse
            {
                profileId = obj.profileId,
                firstName = obj.firstName,
                secondName = obj.secondName,
                lastName = obj.lastName,
                locationId = obj.locationId,
                Location = obj.Location,
                statusId = obj.statusId,
                Status = obj.Status,
                descripTion = obj.descripTion,
                contactId = obj.contactId,
                Contact = obj.Contact,
                birthDay = obj.birthDay
            }).ToList();
        }

        public async Task<Profile> MyProfile()
        {
            return await _context.MyProfile();
        }

        public async Task<Profile> GetProfile(int ProfileId)
        {
            return await _context.GetProfile(ProfileId);
        }

        public Task<Profile> UpdateProfile(int ProfileId, Profile _Profile)
        {
            throw new NotImplementedException();
        }
    }
}
