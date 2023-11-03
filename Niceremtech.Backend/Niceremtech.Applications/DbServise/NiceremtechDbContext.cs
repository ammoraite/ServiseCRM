using Entities.Models.Accounts;
using Entities.Models.Orders;
using Entities.Models.Users;
using Entities.Models.Users.EmployeeProperty;
using Entities.Models.WorkSpareEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;


namespace DbTests
{
    public class NiceremtechDbContext : DbContext
    {
        public NiceremtechDbContext ( DbContextOptions<NiceremtechDbContext> options )
    : base (options)
        {
           
        }
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
    }
}
