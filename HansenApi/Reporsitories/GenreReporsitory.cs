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
    public class GenreReporsitory : IGenreReporsitory
    {
        private readonly DatabaseContext _context;
        public GenreReporsitory(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<Genre> CreateGenre(Genre _Genre)
        {
            _context.Genre.Add(_Genre);
            await _context.SaveChangesAsync();
            return null;
        }

        public async Task<Genre> DeleteGenre(int GenreId)
        {
            var genre = _context.Genre.Find(GenreId);
            if(genre != null)
            {
                _context.Genre.Remove(genre);
                await _context.SaveChangesAsync();
            }
            return genre;
        }

        public async Task<List<Genre>> GetAllGenres()
        {
            List<Genre> genre = await _context.Genre.ToListAsync();
            return genre;
        }

        public async Task<Genre> GetGenre(int GenreId)
        {
            return await _context.Genre.FindAsync(GenreId);
        }

        public async Task<Genre> UpdateGenre(int GenreId, Genre _Genre)
        {
            _context.Entry(_Genre).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return null;
        }
    }
}
