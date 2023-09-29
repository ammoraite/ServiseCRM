namespace Entities.Models.Users.EmployeeProperty
{
    public class PositionRights
    {
        public Guid Id { get; set; }
        public bool? ICanDeleteCompany { get; set; }
        public bool? ICanCreateCompany { get; set; }
        public bool? ICanModifyCompany { get; set; }
        public bool? ICanDeleteEmployee { get; set; }
        public bool? ICanCreateEmployee { get; set; }
        public bool? ICanModifyEmployee { get; set; }
        public bool? ICanModifyPositionRights { get; set; }
    }
}