using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HansenApi.DTO
{
    public class SettingsResponse
    {
        public int settingId { get; set; }
        public string pageTitle { get; set; }
        public string slogan { get; set; }
        public string year { get; set; }
        public string developer { get; set; }
        public string tech { get; set; }
    }
}
