using Bunit;
using Microsoft.Extensions.DependencyInjection;
using HR_Dashboard.Pages;

namespace TestHR_Dashboard
{
	public class TestEvents
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor();
			var componentUnderTest = ctx.RenderComponent<Events>();
			Assert.NotNull(componentUnderTest);
		}
	}
}