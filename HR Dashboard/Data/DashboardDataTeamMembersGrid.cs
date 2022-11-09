//namespace HR_Dashboard.Data.DashboardData; // Razor won't recognize third level namespace
namespace HR_Dashboard.DashboardData;

public class TeamMembersGridType
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? HireDate { get; set; }
    public double? ID { get; set; }
    public string? Department { get; set; }
    public string? Position { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
}
