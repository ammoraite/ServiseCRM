using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entities.Models.Users;

using Microsoft.EntityFrameworkCore;

namespace DbTests
{
    public class Context:DbContext
    {
        public Context()
        {
            Database.EnsureCreated();
        }

        public DbSet<MyCompany> Companies { get; set; }
        public DbSet<Employee> employees { get; set; }
        protected override void OnConfiguring ( DbContextOptionsBuilder optionsBuilder )
        {
            optionsBuilder.UseNpgsql (@"Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=04031988");
        }
    }
}
