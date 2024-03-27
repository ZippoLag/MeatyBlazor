namespace MeatyBlazor.Tests.Components;

using MeatyBlazor.Components;

public class CounterTests :TestContext
{
    [Fact]
    public void Counter_StartsWith_0()
    {
        // Arrange
        var cut = RenderComponent<Counter>();

        // Assert
        Assert.Contains("0", cut.Markup);
    }

    [Fact]
    public void Counter_IsIncremebted_By1_WhenClicked()
    {
        // Arrange
        var cut = RenderComponent<Counter>();

        // Act
        var buttonElement = cut.Find("button");
        buttonElement.Click();

        // Assert
        Assert.Contains("1", cut.Markup);
    }
}
