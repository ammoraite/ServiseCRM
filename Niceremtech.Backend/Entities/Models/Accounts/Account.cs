namespace Entities.Models.Accounts
{
    public class Account
    {
        public Guid Id { get; set; }
        public int UserRights { get; set; }
        public DateTime DateCreate { get; set; }
        public bool IsBlock { get; set; }
        public decimal Ballance { get; set; }
    }
}