using Entities.Models.Users.EmployeeProperty;

namespace Entities.Models.Users.Interfaces
{
    public interface IEmployee:IUser
    {
        public Position? EmployeePosition { get; set; }
    }
}