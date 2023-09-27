namespace Entities.Models.Orders
{
    public class Order
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Guid EmployeeOrderCreatorId { get; set; }
        public Guid EmployeeExecutorId { get; set; }
        public DateTime OrderСreationDate { get; set; }= DateTime.Now;
        public string? CurrentStatus { get; set; }
    }
}
