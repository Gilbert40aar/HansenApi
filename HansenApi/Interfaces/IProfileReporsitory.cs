using HansenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HansenApi.Interfaces
{
    public interface IProfileReporsitory
    {
        public Task<Profile> CreateProfile(Profile _Profile);
        public Task<Profile> GetProfile(int ProfileId);
        public Task<Profile> MyProfile();
        public Task<List<Profile>> GetAllProfiles();
        public Task<Profile> UpdateProfile(int ProfileId, Profile _Profile);
        public Task<Profile> DeleteProfile(int ProfileId);
    }
}
