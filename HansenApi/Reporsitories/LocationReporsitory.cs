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
    public class LocationReporsitory : ILocationReporsitory
    {
        private readonly DatabaseContext _context;
        public LocationReporsitory(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<Location> CreateLocation(Location _Location)
        {
            _context.Location.Add(_Location);
            await _context.SaveChangesAsync();
            return null;
        }

        public async Task<Location> DeleteLocation(int LocationId)
        {
            var location = _context.Location.Find(LocationId);
            if(location != null)
            {
                _context.Location.Remove(location);
                await _context.SaveChangesAsync();
            }
            return location;
        }

        public async Task<List<Location>> GetAllLocations()
        {
            List<Location> location = await _context.Location.ToListAsync();
            return location;
        }

        public async Task<Location> GetLocation(int LocationId)
        {
            return await _context.Location.FindAsync(LocationId);
        }

        public Task<Location> UpdateLocation(int LocationId, Location _Location)
        {
            throw new NotImplementedException();
        }
    }
}
