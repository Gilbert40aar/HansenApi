using HansenApi.DTO;
using HansenApi.Interfaces;
using HansenApi.Models;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace HansenApi.Services
{
    public class AdminService : IAdminService
    {
        private readonly IAdminReporsitory _context;
        private readonly JWTSettingsModel _jwtsettings;

        public AdminService(IAdminReporsitory context, IOptions<JWTSettingsModel> jwtsettings)
        {
            _context = context;
            _jwtsettings = jwtsettings.Value;
        }

        public async Task<LoginResponse> AdminLogin(string userName, string passWord)
        {
            Admin login = await _context.AdminLogin(userName, passWord);

            var tokenHandler = new JwtSecurityTokenHandler(); // Her opretter vi en nyt jwt security token handler instans som hedder tokenHandler
            var key = Encoding.ASCII.GetBytes(_jwtsettings.SecretKey); // her encodes secretkey 
            var tokenDescriptor = new SecurityTokenDescriptor // Her fortælles der hvad der skal være med af data i denne token.
            {
                // dette er et object som identificere den person som er logget ind. disse dataer bliver lagt ind i token.
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim("id", login.adminId.ToString()),
                    new Claim("rule", "admin"),
                    new Claim("firstname", login.firstName),
                    new Claim("lastname", login.lastName)

                }),
                Expires = DateTime.UtcNow.AddDays(2), // Here fortælles der hvornår at denne token udløber
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor); // Her bliver selve min token genereret og gjort klar til at blive sendt til brugeren

            //Return token
            return new LoginResponse() { token = tokenHandler.WriteToken(token) }; // her skrives token og sendt til brugeren.
        }

        public async Task<Admin> CreateAdmin(Admin _admin)
        {
            return await _context.CreateAdmin(_admin);
        }

        public async Task<bool> DeleteAdmin(int adminId)
        {
            var temp = await _context.DeleteAdmin(adminId);
            return temp != null;
        }

        public async Task<Admin> GetAdmin(int adminId)
        {
            return await _context.GetAdmin(adminId);
        }

        public async Task<List<AdminResponse>> GetAllAdmins()
        {
            List<Admin> adminlist = await _context.GetAllAdmins();
            return adminlist.Select(obj => new AdminResponse
            {
                adminId = obj.adminId,
                firstName = obj.firstName,
                lastName = obj.lastName,
                userName = obj.userName,
                passWord = obj.passWord,
                token = obj.token
            }).ToList();
        }

        public Task<Admin> UpdateAdmin(int adminId, Admin _admin)
        {
            throw new NotImplementedException();
        }
    }
}
