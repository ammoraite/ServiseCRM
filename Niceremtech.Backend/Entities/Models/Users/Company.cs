using System.ComponentModel.DataAnnotations.Schema;

using Entities.Models.Accounts;
using Entities.Models.Users.Interfaces;

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