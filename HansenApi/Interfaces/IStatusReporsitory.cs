using HansenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HansenApi.Interfaces
{
    public interface IStatusReporsitory
    {
        public Task<Status> CreateStatus(Status _Status);
        public Task<Status> GetStatus(int StatusId);
        public Task<List<Status>> GetAllStatuss();
        public Task<Status> UpdateStatus(int StatusId, Status _Status);
        public Task<Status> DeleteStatus(int StatusId);
    }
}
