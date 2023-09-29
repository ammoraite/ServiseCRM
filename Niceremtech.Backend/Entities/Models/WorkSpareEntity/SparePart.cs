using Entities.Models.Users;

namespace Entities.Models.WorkSpareEntity
{
    public class SparePart
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public decimal? PurchasePrise { get; set; }
        public DateTime? DateOfPurchase { get; set; }= DateTime.Now;
        public DateTime? DateTimeOfSale { get; set; }
        public decimal? Price { get; set; }
        public Provider? Provider { get; set; }
        public int? QuantityOnBallance { get; set; }
        public string? Description { get; set; }
    }
}