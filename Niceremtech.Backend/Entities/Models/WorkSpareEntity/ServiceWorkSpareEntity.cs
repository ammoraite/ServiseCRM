namespace Entities.Models.WorkSpareEntity
{
    public class ServiceWorkSpareEntity
    {
        public Guid Id { get; set; }
        public Guid OrgerId {get;set;}
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
    }
}
