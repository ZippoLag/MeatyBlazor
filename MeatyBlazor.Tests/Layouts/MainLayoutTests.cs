namespace MeatyBlazor.Tests.Layouts;

using MeatyBlazor.Layouts;

public class MainLayoutTests : TestContext
{
    [Fact]
    public void MainLayout_RendersOk_WhenNotGivenChildContent()
    {
        // Arrange
        var cut = RenderComponent<MainLayout>();

        // Assert that the main layout can be drawn without content being given
        var mainComponent = cut.Find("main");
        Assert.Equal(string.Empty, mainComponent.InnerHtml);
    }

    [Fact]
    public void MainLayout_RendersOk_WhenGivenChildContent()
    {
        // Arrange
        string childContent = "<p>Some text</p>";
        var cut = RenderComponent<MainLayout>(parameters => parameters.Add(p => p.Body, childContent));

        // Assert that the main layout can be drawn without content being given
        var mainComponent = cut.Find("main");
        Assert.Equal(childContent, mainComponent.InnerHtml);
    }
}