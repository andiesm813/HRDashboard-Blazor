using System.Net.Http.Json;

namespace HR_Dashboard.DashboardData
{
    public class DashboardDataService
    {
        private readonly HttpClient http;

        public DashboardDataService(HttpClient http)
        {
            this.http = http;
        }

        public async Task<NewTeamMembersListType[]?> GetNewTeamMembersList()
        {
            return await this.http.GetFromJsonAsync<NewTeamMembersListType[]>("https://excel2json.io/api/share/6371c465-f63a-4dd9-436e-08da496bf5f2");
        }

        public async Task<TeamMembersGridType[]?> GetTeamMembersGrid()
        {
            return await this.http.GetFromJsonAsync<TeamMembersGridType[]>("https://excel2json.io/api/share/d2d94130-e6aa-4387-437e-08da496bf5f2");
        }

        public async Task<TeamGrowthType[]?> GetTeamGrowth()
        {
            return await this.http.GetFromJsonAsync<TeamGrowthType[]>("https://excel2json.io/api/share/9d362c81-e18a-4fff-4355-08da496bf5f2");
        }

        public async Task<AllTeamMembersType[]?> GetAllTeamMembers()
        {
            return await this.http.GetFromJsonAsync<AllTeamMembersType[]>("https://excel2json.io/api/share/d2d94130-e6aa-4387-437e-08da496bf5f2");
        }
    }
}