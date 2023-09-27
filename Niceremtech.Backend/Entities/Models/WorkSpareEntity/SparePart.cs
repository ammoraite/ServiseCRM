namespace Entities.Models.WorkSpareEntity
{
    public class SparePart: ServiceWorkSpareEntity
    {
        public DateTime DateOfPurchase { get; set; }= DateTime.Now;
        public Guid ProviderId { get; set; }
        public int PurchasePrise { get; set; }
        public int QuantityOnBallance { get; set; }
    }
}