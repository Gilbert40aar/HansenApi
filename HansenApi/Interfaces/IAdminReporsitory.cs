using HansenApi.DTO;
using HansenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HansenApi.Interfaces
{
    public interface IAdminReporsitory
    {
        public Task<Admin> CreateAdmin(Admin _admin);
        public Task<Admin> GetAdmin(int adminId);
        public Task<Admin> AdminLogin(string userName, string passWord);
        public Task<List<Admin>> GetAllAdmins();
        public Task<Admin> UpdateAdmin(int adminId, Admin _admin);
        public Task<Admin> DeleteAdmin(int adminId);
    }
}
