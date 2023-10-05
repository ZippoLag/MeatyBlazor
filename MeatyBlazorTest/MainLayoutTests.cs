using MeatyBlazor;

namespace MeatyBlazorTest;

public class MainLayoutTests : TestContext
{
	[Fact]
	public void MainLayout_RendersOk_WithoutChildContent()
	{
		// Arrange
		var cut = RenderComponent<MainLayout>();

		// Assert that the main layout can be drawn without content being given
		cut.MarkupMatches("<main></main>");
	}
}