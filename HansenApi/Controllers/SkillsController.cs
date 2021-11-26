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
    public class SkillsController : ControllerBase
    {
        private readonly ISkillService _context;

        public SkillsController(ISkillService context)
        {
            _context = context;
        }

        // GET: api/Skills
        [HttpGet("GetAllSkills")]
        public async Task<ActionResult<IEnumerable<Skills>>> GetSkills()
        {
            try
            {
                List<SkillsResponse> skillslist = await _context.GetAllSkillss();
                if (skillslist == null)
                {
                    return Problem("There is no movies in the database yet");
                }
                if (skillslist.Count == 0)
                {
                    return NoContent();
                }
                return Ok(skillslist);
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }

        // GET: api/Skills/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Skills>> GetSkills(int id)
        {
            try
            {
                return Ok(await _context.GetSkills(id));
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            };
        }

        // PUT: api/Skills/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutSkills(int id, Skills skills)
        //{
        //    if (id != skills.skillsId)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(skills).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!SkillsExists(id))
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

        // POST: api/Skills
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("CreateSkills")]
        public async Task<ActionResult<Skills>> PostSkills(Skills skills)
        {
            try
            {
                return Ok(await _context.CreateSkills(skills));
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }

        // DELETE: api/Skills/5
        [HttpDelete("DeleteSkills/{id}")]
        public async Task<IActionResult> DeleteSkills(int id)
        {
            try
            {
                bool result = await _context.DeleteSkills(id);
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

        //private bool SkillsExists(int id)
        //{
        //    return _context.Skills.Any(e => e.skillsId == id);
        //}
    }
}
