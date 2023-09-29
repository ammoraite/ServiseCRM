namespace Entities.Models.Users.EmployeeProperty
{
    public class Position
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public PositionRights? PositionRights { get; set; }
    }
}