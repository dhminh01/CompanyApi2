namespace CompanyApi2.Infrastructure.Dtos
{
    public class FullEmployeeDto
    {
        public string Name { get; set; } = string.Empty;
        public Guid DepartmentId { get; set; }
        public DateTime JoinedDate { get; set; }
        public decimal Salary { get; set; }
        public List<Guid> ProjectIds { get; set; } = new();
    }
}

