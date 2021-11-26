using HansenApi.DTO;
using HansenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HansenApi.Interfaces
{
    public interface ILocationService
    {
        public Task<Location> CreateLocation(Location _Location);
        public Task<Location> GetLocation(int LocationId);
        public Task<List<Location>> GetAllLocations();
        public Task<Location> UpdateLocation(int LocationId, Location _Location);
        public Task<bool> DeleteLocation(int LocationId);
    }
}
