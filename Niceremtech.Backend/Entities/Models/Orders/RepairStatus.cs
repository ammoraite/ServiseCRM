namespace Entities.Models.Orders
{
    public class RepairStatus
    {
        public Guid Id { get; set; }
        public Guid OrderID { get; set; }
        public DateTime DateTimeSet { get; set; }
        public string? Status { get; set; }
    }
}