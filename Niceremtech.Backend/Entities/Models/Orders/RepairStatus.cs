using Entities.Models.Users;

namespace Entities.Models.Orders
{
    public class RepairStatus
    {
        public Guid Id { get; set; }
        public Employee? EmployeeWhoSetStatus { get; set; }
        public DateTime? DateTimeSet { get; set; }
        public string? Status { get; set; }
    }
}
