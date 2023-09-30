using Entities.Models.Accounts;

using Microsoft.Extensions.Caching.Memory;

namespace Entities.Models.Users.Interfaces
{
    public interface IUser
    {
        public Guid Id { get; set; }
        public Account? Account { get; set; }
        public PersonalData? PersonalData { get; set; }
    }
}
