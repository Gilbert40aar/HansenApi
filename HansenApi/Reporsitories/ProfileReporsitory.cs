using HansenApi.Database;
using HansenApi.Interfaces;
using HansenApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HansenApi.Reporsitories
{
    public class ProfileReporsitory : IProfileReporsitory
    {
        private readonly DatabaseContext _context;
        public ProfileReporsitory(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<Profile> CreateProfile(Profile _Profile)
        {
            _context.Profile.Add(_Profile);
            await _context.SaveChangesAsync();
            return null;
        }

        public async Task<Profile> DeleteProfile(int ProfileId)
        {
            var profile = _context.Profile.Find(ProfileId);
            if(profile != null)
            {
                _context.Profile.Remove(profile);
                await _context.SaveChangesAsync();
            }
            return profile;
        }

        public async Task<List<Profile>> GetAllProfiles()
        {
            //List<Profile> profile = await _context.Profile.ToListAsync();
            var profile = await _context.Profile.ToListAsync();
            var profile1 = await _context.Profile.Include(p => p.Location).OrderBy(l => l.locationId).ToListAsync();
            var profile2 = await _context.Profile.Include(p => p.Status).OrderBy(s => s.statusId).ToListAsync();
            var profile3 = await _context.Profile.Include(p => p.Contact).OrderBy(c => c.contactId).ToListAsync();
            return profile;
        }

        public async Task<Profile> MyProfile()
        {
            var profile = await _context.Profile.FirstOrDefaultAsync();
            var profile1 = await _context.Profile.Include(p => p.Location).OrderBy(l => l.locationId).FirstOrDefaultAsync();
            var profile2 = await _context.Profile.Include(p => p.Status).OrderBy(s => s.statusId).FirstOrDefaultAsync();
            var profile3 = await _context.Profile.Include(p => p.Contact).OrderBy(c => c.contactId).FirstOrDefaultAsync();
            return profile;
        }

        public async Task<Profile> GetProfile(int ProfileId)
        {
            //return await _context.Profile.FindAsync(ProfileId);
            Profile profil = await _context.Profile.FindAsync(ProfileId);
            var profil1 = await _context.Profile.Include(p => p.Location).OrderBy(l => l.locationId).ToListAsync();
            var profil2 = await _context.Profile.Include(p => p.Status).OrderBy(s => s.statusId).ToListAsync();
            var profil3 = await _context.Profile.Include(p => p.Contact).OrderBy(c => c.contactId).ToListAsync();
            return profil;
        }

        public Task<Profile> UpdateProfile(int ProfileId, Profile _Profile)
        {
            throw new NotImplementedException();
        }
    }
}
