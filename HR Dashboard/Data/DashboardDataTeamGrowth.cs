//namespace HR_Dashboard.Data.DashboardData; // Razor won't recognize third level namespace
namespace HR_Dashboard.DashboardData;

public class TeamGrowthType
{
    public string? Months { get; set; }
    public double? Employee { get; set; }
    public double? Contractor { get; set; }
    public double? Talent { get; set; }
}
