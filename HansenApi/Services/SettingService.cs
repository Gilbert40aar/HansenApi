using HansenApi.DTO;
using HansenApi.Interfaces;
using HansenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HansenApi.Services
{
    public class SettingService : ISettingService
    {
        private readonly ISettingReporsitory _context;
        public SettingService(ISettingReporsitory context)
        {
            _context = context;
        }

        public async Task<Settings> CreateSettings(Settings _Settings)
        {
            return await _context.CreateSettings(_Settings);
        }

        public async Task<bool> DeleteSettings(int SettingsId)
        {
            var temp = await _context.DeleteSettings(SettingsId);
            return temp != null;
        }

        public async Task<List<SettingsResponse>> GetAllSettingss()
        {
            List<Settings> setting = await _context.GetAllSettingss();
            return setting.Select(obj => new SettingsResponse
            {
                settingId = obj.settingId,
                pageTitle = obj.pageTitle,
                slogan = obj.slogan,
                tech = obj.tech,
                developer = obj.developer,
                year = obj.year
            }).ToList();
        }

        public async Task<Settings> GetSettings(int SettingsId)
        {
            return await _context.GetSettings(SettingsId);
        }

        public async Task<Settings> UpdateSettings(int SettingsId, Settings _Settings)
        {
            return await _context.UpdateSettings(SettingsId, _Settings);
        }
    }
}
