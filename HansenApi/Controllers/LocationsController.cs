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
    public class LocationsController : ControllerBase
    {
        private readonly ILocationService _context;

        public LocationsController(ILocationService context)
        {
            _context = context;
        }

        // GET: api/Locations
        [HttpGet("GetAllLocations")]
        public async Task<ActionResult<List<Location>>> GetLocation()
        {
            try
            {
                List<Location> locationlist = await _context.GetAllLocations();
                if (locationlist == null)
                {
                    return Problem("There is no movies in the database yet");
                }
                if (locationlist.Count == 0)
                {
                    return NoContent();
                }
                return locationlist;
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }

        // GET: api/Locations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Location>> GetLocation(int id)
        {
            try
            {
                return Ok(await _context.GetLocation(id));
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            };
        }

        // PUT: api/Locations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("UpdateLocations/{id}")]
        public async Task<IActionResult> PutLocation(int id, Location location)
        {
            try
            {
                return Ok(await _context.UpdateLocation(id, location));
            } catch(Exception e)
            {
                return Problem(e.Message);
            }
        }

        // POST: api/Locations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("CreateLocation")]
        public async Task<ActionResult<Location>> PostLocation(Location location)
        {
            try
            {
                return Ok(await _context.CreateLocation(location));
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }

        // DELETE: api/Locations/5
        [HttpDelete("DeleteLocation/{id}")]
        public async Task<IActionResult> DeleteLocation(int id)
        {
            try
            {
                bool result = await _context.DeleteLocation(id);
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

        //private bool LocationExists(int id)
        //{
        //    return _context.Location.Any(e => e.locationId == id);
        //}
    }
}
