using HansenApi.DTO;
using HansenApi.Interfaces;
using HansenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HansenApi.Services
{
    public class LocationService :ILocationService
    {
        private readonly ILocationReporsitory _context;
        public LocationService(ILocationReporsitory context)
        {
            _context = context;
        }

        public async Task<Location> CreateLocation(Location _Location)
        {
            return await _context.CreateLocation(_Location);
        }

        public async Task<bool> DeleteLocation(int LocationId)
        {
            var temp = await _context.DeleteLocation(LocationId);
            return temp != null;
        }

        public async Task<List<Location>> GetAllLocations()
        {
            List<Location> location = await _context.GetAllLocations();
            return location.Select(obj => new Location
            {
                locationId = obj.locationId,
                addRess = obj.addRess,
                zipCode = obj.zipCode,
                city = obj.city,
                country = obj.country
            }).ToList();
        }

        public async Task<Location> GetLocation(int LocationId)
        {
            return await _context.GetLocation(LocationId);
        }

        public Task<Location> UpdateLocation(int LocationId, Location _Location)
        {
            throw new NotImplementedException();
        }
    }
}
