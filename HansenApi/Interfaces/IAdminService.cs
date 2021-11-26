using HansenApi.DTO;
using HansenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HansenApi.Interfaces
{
    public interface IAdminService
    {
        public Task<Admin> CreateAdmin(Admin _admin);
        public Task<Admin> GetAdmin(int adminId);
        public Task<LoginResponse> AdminLogin(string userName, string passWord);
        public Task<List<AdminResponse>> GetAllAdmins();
        public Task<Admin> UpdateAdmin(int adminId, Admin _admin);
        public Task<bool> DeleteAdmin(int adminId);
    }
}
