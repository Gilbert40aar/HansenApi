using HansenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HansenApi.Interfaces
{
    public interface ISettingReporsitory
    {
        public Task<Settings> CreateSettings(Settings _Settings);
        public Task<Settings> GetSettings(int SettingsId);
        public Task<List<Settings>> GetAllSettingss();
        public Task<Settings> UpdateSettings(int SettingsId, Settings _Settings);
        public Task<Settings> DeleteSettings(int SettingsId);
    }
}
