using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BugManagementContext : DbContext
    {
        public DbSet<Bug> Bugs { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Message> Messages { get; set; }

        public DbSet<Logs> Logs { get; set; }

        public DbSet<Priority> Priorities { get; set; }

        public DbSet<Severity> Severities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-7C9B2416\\SQL2019EXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False; Initial Catalog= BugTracker");
        }
    }
}
