using Entities.Models.Accounts;

namespace Entities.Models.Users.Interfaces
{
    public interface IUser
    {
        public Guid Id { get; set; }
        public Account? Account { get; set; }
        public PersonalData? PersonalData { get; set; }
    }
}
