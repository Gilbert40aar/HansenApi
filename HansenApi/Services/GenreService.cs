using HansenApi.DTO;
using HansenApi.Interfaces;
using HansenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HansenApi.Services
{
    public class GenreService :IGenreService
    {
        private readonly IGenreReporsitory _context;
        public GenreService(IGenreReporsitory context)
        {
            _context = context;
        }

        public async Task<Genre> CreateGenre(Genre _Genre)
        {
            return await _context.CreateGenre(_Genre);
        }

        public async Task<bool> DeleteGenre(int GenreId)
        {
            var temp = await _context.DeleteGenre(GenreId);
            return temp != null;
        }

        public async Task<List<GenreResponse>> GetAllGenres()
        {
            List<Genre> genre = await _context.GetAllGenres();
            return genre.Select(obj => new GenreResponse
            {
                genreId = obj.genreId,
                genreTitle = obj.genreTitle
            }).ToList();
        }

        public async Task<Genre> GetGenre(int GenreId)
        {
            return await _context.GetGenre(GenreId);
        }

        public async Task<Genre> UpdateGenre(int GenreId, Genre _Genre)
        {
            return await _context.UpdateGenre(GenreId, _Genre);
        }
    }
}
