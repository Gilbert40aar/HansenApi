using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HansenApi.Database;
using HansenApi.Models;
using HansenApi.Interfaces;
using HansenApi.DTO;

namespace HansenApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SettingsController : ControllerBase
    {
        private readonly ISettingService _context;

        public SettingsController(ISettingService context)
        {
            _context = context;
        }

        // GET: api/Settings
        [HttpGet("GetAllSettings")]
        public async Task<ActionResult<IEnumerable<Settings>>> GetSettings()
        {
            try
            {
                List<SettingsResponse> settingslist = await _context.GetAllSettingss();
                if (settingslist == null)
                {
                    return Problem("There is no movies in the database yet");
                }
                if (settingslist.Count == 0)
                {
                    return NoContent();
                }
                return Ok(settingslist);
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }

        // GET: api/Settings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Settings>> GetSettings(int id)
        {
            try
            {
                return Ok(await _context.GetSettings(id));
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            };
        }

        // PUT: api/Settings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("UpdateSettings/{id}")]
        public async Task<IActionResult> PutSettings(int id, Settings settings)
        {
            try
            {
                return Ok(await _context.UpdateSettings(id, settings));
            } catch (Exception e)
            {
                return Problem(e.Message);
            }
        }

        // POST: api/Settings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("CreateSettings")]
        public async Task<ActionResult<Settings>> PostSettings(Settings settings)
        {
            try
            {
                return Ok(await _context.CreateSettings(settings));
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }

        // DELETE: api/Settings/5
        [HttpDelete("DeleteSettings/{id}")]
        public async Task<IActionResult> DeleteSettings(int id)
        {
            try
            {
                bool result = await _context.DeleteSettings(id);
                if (!result)
                {
                    return Problem("Something went wrong, trying to delete the movie");
                }
                return Ok(result);
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }

        //private bool SettingsExists(int id)
        //{
        //    return _context.Settings.Any(e => e.settingId == id);
        //}
    }
}
