namespace MeatyBlazorTest.Pages;

using Index = MeatyBlazor.Pages.Index;

public class IndexTests : TestContext
{
    [Fact]
    public void Index_Title_RendersOk()
    {
        // Arrange
        var cut = RenderComponent<Index>();

        // Assert
        var titleComponent = cut.Find("h1");
        Assert.NotNull(titleComponent);
        Assert.Contains("Hello, world!", titleComponent.TextContent);
    }
}