using HansenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HansenApi.Interfaces
{
    public interface IGenreReporsitory
    {
        public Task<Genre> CreateGenre(Genre _Genre);
        public Task<Genre> GetGenre(int GenreId);
        public Task<List<Genre>> GetAllGenres();
        public Task<Genre> UpdateGenre(int GenreId, Genre _Genre);
        public Task<Genre> DeleteGenre(int GenreId);
    }
}
