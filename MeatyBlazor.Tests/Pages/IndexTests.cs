namespace MeatyBlazorTest.Pages;

using Index = MeatyBlazor.Pages.Index;

public class IndexTests : TestContext
{
    [Fact]
    public void Index_RendersOk_ContainsAllSections()
    {
        // Arrange
        var cut = RenderComponent<Index>();

        // Assert Tile
        var titleComponent = cut.Find("h1");
        Assert.NotNull(titleComponent);
        Assert.Contains("Hello, world!", titleComponent.TextContent);

        // Assert Counter
        var counterListComponent = cut.Find(".counterlist");
        Assert.NotNull(counterListComponent);
    }
}