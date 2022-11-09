using Bunit;
using Microsoft.Extensions.DependencyInjection;
using HR_Dashboard.Pages;
using HR_Dashboard.DashboardData;

namespace TestHR_Dashboard
{
	public class TestTeam
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgniteUI.Blazor.Controls.IgbCardModule));
			var mockHttpClient = new MockHttpClient().Create();
			ctx.Services.AddSingleton(new DashboardDataService(mockHttpClient));
			var componentUnderTest = ctx.RenderComponent<Team>();
			Assert.NotNull(componentUnderTest);
		}
	}
}