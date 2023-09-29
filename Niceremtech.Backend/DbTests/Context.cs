using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entities.Models.Accounts;
using Entities.Models.Orders;
using Entities.Models.Users;
using Entities.Models.Users.EmployeeProperty;
using Entities.Models.WorkSpareEntity;

using Microsoft.EntityFrameworkCore;

namespace DbTests
{
    public class Context:DbContext
    {
        
        
        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<PersonalData> PersonalDatas { get; set; }
        public DbSet<PositionRights> PositionRights { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<RepairStatus> RepairStatuses { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountRights> UserRights { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<SparePart> SpareParts { get; set; }
        public DbSet<Provider> Providers { get; set; }

        //public Context()
        //{
        //    Database.EnsureCreated ( );
        //}
        protected override void OnConfiguring ( DbContextOptionsBuilder optionsBuilder )
        {
            optionsBuilder.UseNpgsql (@"Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=04031988");
        }
    }
}
