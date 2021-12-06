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
    public class SettingReporsitory : ISettingReporsitory
    {
        private readonly DatabaseContext _context;
        public SettingReporsitory(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<Settings> CreateSettings(Settings _Settings)
        {
            _context.Settings.Add(_Settings);
            await _context.SaveChangesAsync();
            return null;
        }

        public async Task<Settings> DeleteSettings(int SettingsId)
        {
            var setting = _context.Settings.Find(SettingsId);
            if(setting != null)
            {
                _context.Settings.Remove(setting);
                await _context.SaveChangesAsync();
            }
            return setting;
        }

        public async Task<List<Settings>> GetAllSettingss()
        {
            List<Settings> setting = await _context.Settings.ToListAsync();
            return setting;
        }

        public async Task<Settings> GetSettings(int SettingsId)
        {
            return await _context.Settings.FindAsync(SettingsId);
        }

        public async Task<Settings> UpdateSettings(int SettingsId, Settings _Settings)
        {
            _context.Entry(_Settings).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return null;
        }
    }
}
