namespace Entities.Models.Users
{
    public class Employee : Persona
    {  
        public string? Post {  get; set; }
        public Guid CompanyId { get; set; }

    }
}