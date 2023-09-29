namespace Entities.Models.WorkSpareEntity
{
    public class Work
    {
        public Guid Id { get; set; }
        public string? TypeWork { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public DateTime? DateTimeOfSale { get; set; }
    }
}