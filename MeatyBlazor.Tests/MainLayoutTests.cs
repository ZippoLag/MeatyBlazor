namespace MeatyBlazor.Tests;

public class MainLayoutTests : TestContext
{
    [Fact]
    public void MainLayout_RendersOk_WithoutChildContent()
    {
        //Arrange
        var cut = RenderComponent<MainLayout>();

        // Assert
        cut.MarkupMatches("<main></main>");
    }
}