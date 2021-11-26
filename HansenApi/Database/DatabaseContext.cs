using HansenApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HansenApi.Database
{
    public class DatabaseContext :DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<Admin> Admin { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Education> Education { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Profile> Profile { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<Settings> Settings { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Work> Work { get; set; }
    }
}
