using HansenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HansenApi.Interfaces
{
    public interface IContactReporsitory
    {
        public Task<Contact> CreateContact(Contact _contact);
        public Task<Contact> GetContact(int contactId);
        public Task<List<Contact>> GetAllContacts();
        public Task<Contact> UpdateContact(int contactId, Contact _contact);
        public Task<Contact> DeleteContact(int contactId);
    }
}
