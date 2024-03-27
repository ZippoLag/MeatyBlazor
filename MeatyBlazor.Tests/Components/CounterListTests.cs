namespace MeatyBlazor.Tests.Components;

using MeatyBlazor.Components;

public class CounterListTests : TestContext
{
    [Fact]
    public void CounterList_RendersOk_IsEmpty_ByDefault()
    {
        // Arrange
        var cut = RenderComponent<CounterList>();

        // Assert
        var counterListElement = cut.Find(".counterlist ul");
        Assert.NotNull(counterListElement);
        Assert.Empty(counterListElement.InnerHtml);
    }

    [Fact]
    public void CounterList_AddButton_AddsNewCounter_WhenClicked()
    {
        // Arrange
        var cut = RenderComponent<CounterList>();

        // Act
        var buttonElement = cut.Find(".counterlist button");
        buttonElement.Click();

        // Assert
        var counterElementInList = cut.Find(".counterlist ul .counter-button");
        Assert.NotNull(counterElementInList);
    }
}
