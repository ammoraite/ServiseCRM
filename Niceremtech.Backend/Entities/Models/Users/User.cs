namespace Entities.Models.Users
{
    public class User
    {
        public Guid Id { get; set; }
        public Guid AccountId { get; set; }
        public string? Name { get; set; }
        public string? Login { get; set; }
        public string? Email { get; set; } = String.Empty;
        public string? Password { get; set; }
        public string? PhoneNumber { get; set; }=String.Empty;
    }
}