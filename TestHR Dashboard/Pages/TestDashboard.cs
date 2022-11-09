using Bunit;
using Microsoft.Extensions.DependencyInjection;
using HR_Dashboard.Pages;
using HR_Dashboard.DashboardData;

namespace TestHR_Dashboard
{
	public class TestDashboard
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgniteUI.Blazor.Controls.IgbCardModule),
				typeof(IgniteUI.Blazor.Controls.IgbButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
				typeof(IgniteUI.Blazor.Controls.IgbIconButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbGridModule),
				typeof(IgniteUI.Blazor.Controls.IgbCategoryChartModule));
			var mockHttpClient = new MockHttpClient().Create();
			ctx.Services.AddSingleton(new DashboardDataService(mockHttpClient));
			var componentUnderTest = ctx.RenderComponent<Dashboard>();
			Assert.NotNull(componentUnderTest);
		}
	}
}