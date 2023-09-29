using Entities.Models.Accounts;
using Entities.Models.Users;
using Entities.Models.WorkSpareEntity;

namespace Entities.Models.Orders
{
    public class Order
    {
        public Guid Id { get; set; }
        public Account? Customer { get; set; }
        public Employee? EmployeeOrderCreator { get; set; }
        public Employee? EmployeeExecutor { get; set; }
        public DateTime? OrderСreationDate { get; set; }= DateTime.Now;
        public ICollection<RepairStatus>? RepairStatuses { get; set; }
        public ICollection<Work>? Works { get; set; }
        public ICollection<SparePart>? SpareParts { get; set; }
    }
}
