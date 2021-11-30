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
    public class ProfilesController : ControllerBase
    {
        private readonly IProfileService _context;

        public ProfilesController(IProfileService context)
        {
            _context = context;
        }

        // GET: api/Profiles
        [HttpGet("GetAllProfiles")]
        public async Task<ActionResult<IEnumerable<Profile>>> GetProfile()
        {
            try
            {
                List<ProfileResponse> profilelist = await _context.GetAllProfiles();
                if (profilelist == null)
                {
                    return Problem("There is no movies in the database yet");
                }
                if (profilelist.Count == 0)
                {
                    return NoContent();
                }
                return Ok(profilelist);
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }

        // GET: api/Profiles/MyProfile
        [HttpGet("MyProfile")]
        public async Task<ActionResult<Profile>> MyProfile()
        {
            try
            {
                return Ok(await _context.MyProfile());
            } catch (Exception e)
            {
                return Problem(e.Message);
            }
        }

        // GET: api/Profiles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Profile>> GetProfile(int id)
        {
            try
            {
                return Ok(await _context.GetProfile(id));
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            };
        }

        // PUT: api/Profiles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutProfile(int id, Profile profile)
        //{
        //    if (id != profile.profileId)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(profile).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ProfileExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        // POST: api/Profiles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("CreateProfile")]
        public async Task<ActionResult<Profile>> PostProfile(Profile profile)
        {
            try
            {
                return Ok(await _context.CreateProfile(profile));
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }

        // DELETE: api/Profiles/5
        [HttpDelete("DeleteProfile/{id}")]
        public async Task<IActionResult> DeleteProfile(int id)
        {
            try
            {
                bool result = await _context.DeleteProfile(id);
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

        //private bool ProfileExists(int id)
        //{
        //    return _context.Profile.Any(e => e.profileId == id);
        //}
    }
}
