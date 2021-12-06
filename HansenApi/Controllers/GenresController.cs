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
    public class GenresController : ControllerBase
    {
        private readonly IGenreService _context;

        public GenresController(IGenreService context)
        {
            _context = context;
        }

        // GET: api/Genres
        [HttpGet("GetAllGenres")]
        public async Task<ActionResult<IEnumerable<Genre>>> GetGenre()
        {
            try
            {
                List<GenreResponse> genrelist = await _context.GetAllGenres();
                if (genrelist == null)
                {
                    return Problem("There is no movies in the database yet");
                }
                if (genrelist.Count == 0)
                {
                    return NoContent();
                }
                return Ok(genrelist);
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }

        // GET: api/Genres/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Genre>> GetGenre(int id)
        {
            try
            {
                return Ok(await _context.GetGenre(id));
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            };
        }

        // PUT: api/Genres/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGenre(int id, Genre genre)
        {
            try
            {
                return Ok(await _context.UpdateGenre(id, genre));
            } catch(Exception e)
            {
                return Problem(e.Message);
            }
        }

        // POST: api/Genres
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("CreateGenre")]
        public async Task<ActionResult<Genre>> PostGenre(Genre genre)
        {
            try
            {
                return Ok(await _context.CreateGenre(genre));
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }

        // DELETE: api/Genres/5
        [HttpDelete("DeleteGenre/{id}")]
        public async Task<IActionResult> DeleteGenre(int id)
        {
            try
            {
                bool result = await _context.DeleteGenre(id);
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

        //private bool GenreExists(int id)
        //{
        //    return _context.Genre.Any(e => e.genreId == id);
        //}
    }
}
