using MeatyBlazor.Services;
using Microsoft.AspNetCore.Components;

namespace MeatyBlazor.Components;

public partial class CounterList
{
	[Inject]
	SharedStateService SharedState { get; set; } = null!;

	List<int> countersCounts = new();

	private void onAddButtonClickHandler()
	{
		countersCounts.Add(0);
	}

	private void onCountersCountChangedHandler(int index, int newCount)
	{
		countersCounts[index] = newCount;
		SharedState.TotalUpdate(countersCounts.Sum());
	}
}
