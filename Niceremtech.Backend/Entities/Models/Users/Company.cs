using System.ComponentModel.DataAnnotations.Schema;

using Entities.Models.Accounts;
using Entities.Models.Users.Interfaces;

using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Primitives;

namespace Entities.Models.Users
{

    public class Company: ICompany
    {
        public Guid Id { get; set; }
        public Account? Account { get; set; }
        public PersonalData? PersonalData { get; set; }
        public ICollection<Employee>? Department { get; set; }
    }
}