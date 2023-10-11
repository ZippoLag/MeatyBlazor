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
		// Arrange
		var cut = RenderComponent<Index>();

		// Act
		var addCounterButton = cut.Find(".add-counter");
		addCounterButton.Click();

		// Assert
		var counterList = cut.Find(".counter-list");
		Assert.True(counterList.HasChildNodes);
	}

	[Fact]
	public void Index_CounterList_ButtonValueMatches_AfterIncrementing()
	{
		// Arrange
		var cut = RenderComponent<Index>();

		var addCounterButton = cut.Find(".add-counter");
		addCounterButton.Click();

		var firstCounter = cut.FindAll("li > button")[0];
		firstCounter.Click();
		firstCounter = cut.FindAll("li > button")[0];

		// Assert
		Assert.Contains("1", firstCounter.TextContent);
	}

	[Fact]
	public void Index_CounterList_ButtonValuesMatch_WhenCounterIsAdded_AfterIncrementingAnother()
	{
		// Arrange
		var cut = RenderComponent<Index>();

		var addCounterButton = cut.Find(".add-counter");
		addCounterButton.Click();

		var firstCounter = cut.FindAll("li > button")[0];
		firstCounter.Click();

		// Act
		addCounterButton.Click();

		// Assert
		firstCounter = cut.FindAll("li > button")[0];
		Assert.Contains("1", firstCounter.TextContent);
	}
}