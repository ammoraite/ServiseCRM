using Entities.Models.Accounts;
using Entities.Models.Users.EmployeeProperty;
using Entities.Models.Users.Interfaces;

namespace Entities.Models.Users
{

    public class Employee: IEmployee
    {
        public Guid Id { get; set; }
        public Account? Account { get; set; }
        public PersonalData? PersonalData { get; set; }
        public Position? EmployeePosition { get; set; }
    }
}