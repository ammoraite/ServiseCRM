namespace Entities.Models.Accounts
{
    public class PersonalData
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Patronymic { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
