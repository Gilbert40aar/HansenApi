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
    public class EducationsController : ControllerBase
    {
        private readonly IEducationService _context;

        public EducationsController(IEducationService context)
        {
            _context = context;
        }

        // GET: api/Educations
        [HttpGet("GetAllEducations")]
        public async Task<ActionResult<IEnumerable<Education>>> GetEducation()
        {
            try
            {
                List<EducationResponse> educationlist = await _context.GetAllEducations();
                if (educationlist == null)
                {
                    return Problem("There is no movies in the database yet");
                }
                if (educationlist.Count == 0)
                {
                    return NoContent();
                }
                return Ok(educationlist);
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }

        // GET: api/Educations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Education>> GetEducation(int id)
        {
            try
            {
                return Ok(await _context.GetEducation(id));
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            };
        }

        // PUT: api/Educations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEducation(int id, Education education)
        {
            try
            {
                return Ok(await _context.UpdateEducation(id, education));
            } catch(Exception e)
            {
                return Problem(e.Message);
            }
        }

        // POST: api/Educations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("CreateEducation")]
        public async Task<ActionResult<Education>> PostEducation(Education education)
        {
            try
            {
                return Ok(await _context.CreateEducation(education));
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }

        // DELETE: api/Educations/5
        [HttpDelete("DeleteEducation/{id}")]
        public async Task<IActionResult> DeleteEducation(int id)
        {
            try
            {
                bool result = await _context.DeleteEducation(id);
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

        //private bool EducationExists(int id)
        //{
        //    return _context.Education.Any(e => e.educationId == id);
        //}
    }
}
