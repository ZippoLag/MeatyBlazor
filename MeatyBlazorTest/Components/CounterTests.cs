using MeatyBlazor.Components;

namespace MeatyBlazorTest.Components;

public class CounterTests : TestContext
{
    [Fact]
    public void Counter_StartsWith_0_ByDefault()
    {
        // Arrange
        var cut = RenderComponent<Counter>();

        // Assert
        Assert.Contains("0", cut.Markup);
    }

    [Fact]
    public void Counter_StartsWith_GivenCountParameter()
    {
        // Arrange
        int startValue = 3;
        var cut = RenderComponent<Counter>(parameters => parameters.Add(p => p.Count, startValue));

        // Assert
        Assert.Contains(startValue.ToString(), cut.Markup);
    }

    [Fact]
    public void Counter_IsIncremented_By1_WhenClicked()
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