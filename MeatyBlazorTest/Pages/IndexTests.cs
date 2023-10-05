using MeatyBlazor.Pages;

namespace MeatyBlazorTest.Pages;

public class CounterTests : TestContext
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

	[Fact]
	public void Index_CounterList_StartsEmpty()
	{
		// Arrange & Act
		var cut = RenderComponent<Index>();

		var counterList = cut.Find(".counter-list");

		//Assert
		Assert.NotNull(counterList);
		Assert.Equal(string.Empty, counterList.InnerHtml);
	}

	[Fact]
	public void Index_AddCounterButton_AddsNewCounter_WhenClicked()
	{
		// Arrange & Act
		var cut = RenderComponent<Index>();

		// Act
		var addCounterButton = cut.Find(".add-counter");
		addCounterButton.Click();

		// Assert
		var counterList = cut.Find(".counter-list");
		Assert.True(counterList.HasChildNodes);
	}
}